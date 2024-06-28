using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Feedback
{
    internal class ZipFileHandler
    {
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
                    catch (Exception ex)
                    {
                        // MessageBox.Show($"An error occurred while processing {Path.GetFileName(zipFile)}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
