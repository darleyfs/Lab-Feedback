using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_Feedback.Views;

namespace Lab_Feedback.Services
{
    internal class ZipFileHandler
    {
        // Your original method (kept for backward compatibility)
        public static void ExtractZipFilesInFolder(string? folderPath)
        {
            // Ensure the folder exists
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The specified folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get all ZIP files in the folder
            var zipFiles = Directory.GetFiles(folderPath, "*.zip");
            // If no ZIP files found, inform the user and exit
            if (zipFiles.Length == 0)
            {
                // MessageBox.Show("No ZIP files found in the specified folder.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Prompt the user to extract the ZIP files
            var result = MessageBox.Show("ZIP files found. Would you like to extract them?", "Extract ZIP Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (var zipFile in zipFiles)
                {
                    try
                    {
                        // Extract the ZIP file to the specified folder
                        using (var archive = ZipFile.OpenRead(zipFile))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                var destinationPath = Path.Combine(folderPath, entry.FullName);
                                try
                                {
                                    // Ensure the directory exists
                                    if (entry.Name == "")
                                    {
                                        // This is a directory
                                        Directory.CreateDirectory(destinationPath);
                                    }
                                    else
                                    {
                                        // This is a file
                                        entry.ExtractToFile(destinationPath, overwrite: true);
                                    }
                                }
                                catch (UnauthorizedAccessException)
                                {
                                    continue;
                                }
                            }
                        }
                        // Delete the ZIP file after extraction
                        File.Delete(zipFile);
                        // MessageBox.Show($"Extracted and deleted: {Folder.GetFileName(zipFile)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show($"An error occurred while processing {Path.GetFileName(zipFile)}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // NEW: Enhanced method with progress dialog
        public static async Task<bool> ExtractZipFilesInFolderWithProgressAsync(string? folderPath, Form parentForm = null)
        {
            // Ensure the folder exists
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The specified folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Get all ZIP files in the folder
            var zipFiles = Directory.GetFiles(folderPath, "*.zip");

            // If no ZIP files found, inform the user and exit
            if (zipFiles.Length == 0)
            {
                return true; // No files to process is considered success
            }

            // Prompt the user to extract the ZIP files
            var result = MessageBox.Show($"Found {zipFiles.Length} ZIP files. Would you like to extract them?",
                                       "Extract ZIP Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return false;

            // Create and show progress dialog
            using (var progressDialog = new ExtractionProgressDialog())
            {
                progressDialog.Text = "Extracting ZIP Files";

                // Show the dialog
                if (parentForm != null)
                    progressDialog.Show(parentForm);
                else
                    progressDialog.Show();

                try
                {
                    // Setup progress
                    progressDialog.SetTotalFiles(zipFiles.Length);

                    for (int i = 0; i < zipFiles.Length; i++)
                    {
                        // Check for cancellation
                        if (progressDialog.IsCancellationRequested)
                        {
                            MessageBox.Show("Extraction cancelled by user.", "Cancelled",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        var zipFile = zipFiles[i];
                        var fileName = Path.GetFileName(zipFile);

                        // Update progress dialog
                        progressDialog.UpdateProgress(i + 1, $"Extracting: {fileName}");

                        try
                        {
                            // Extract the ZIP file
                            await ExtractSingleZipFileAsync(zipFile, folderPath, progressDialog.CancellationToken);

                            // Delete the ZIP file after extraction
                            File.Delete(zipFile);

                            progressDialog.UpdateStatus($"Completed: {fileName}");
                        }
                        catch (OperationCanceledException)
                        {
                            return false; // User cancelled
                        }
                        catch (Exception ex)
                        {
                            progressDialog.UpdateStatus($"Error with {fileName}: {ex.Message}");
                            // Continue with next file instead of stopping completely
                            await Task.Delay(1000); // Brief pause to show error
                        }
                    }

                    // Show completion
                    progressDialog.UpdateStatus("Extraction completed successfully!");
                    await Task.Delay(1500); // Show completion message briefly

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during extraction: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private static async Task ExtractSingleZipFileAsync(string zipFile, string folderPath, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                using (var archive = ZipFile.OpenRead(zipFile))
                {
                    foreach (var entry in archive.Entries)
                    {
                        // Check for cancellation
                        cancellationToken.ThrowIfCancellationRequested();

                        var destinationPath = Path.Combine(folderPath, entry.FullName);

                        try
                        {
                            // Ensure the directory exists
                            if (entry.Name == "")
                            {
                                // This is a directory
                                Directory.CreateDirectory(destinationPath);
                            }
                            else
                            {
                                // Ensure parent directory exists
                                var parentDir = Path.GetDirectoryName(destinationPath);
                                if (!string.IsNullOrEmpty(parentDir) && !Directory.Exists(parentDir))
                                {
                                    Directory.CreateDirectory(parentDir);
                                }

                                // This is a file
                                entry.ExtractToFile(destinationPath, overwrite: true);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            continue; // Skip files we can't access
                        }
                    }
                }
            }, cancellationToken);
        }
    }
}