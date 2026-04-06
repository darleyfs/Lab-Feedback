using Lab_Feedback.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Feedback.Views
{
    public partial class ExtractionProgressDialog : Form
    {

        CancellationTokenSource cancellationTokenSource;

        public CancellationToken CancellationToken => cancellationTokenSource.Token;
        public bool IsCancellationRequested => cancellationTokenSource.IsCancellationRequested;

        public ExtractionProgressDialog()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
        }

        // Apply theme on load
        private void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                ThemeHelper.ApplyTheme(this);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Enabled = false;
            cancelButton.Text = "Cancelling...";
            cancellationTokenSource.Cancel();
        }

        public void SetTotalFiles(int totalFiles)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Maximum = totalFiles;
                    progressBar.Value = 0;
                }));
            }
            else
            {
                progressBar.Maximum = totalFiles;
                progressBar.Value = 0;
            }
        }

        public void UpdateProgress(int currentFile, string currentFileName)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateProgress(currentFile, currentFileName)));
                return;
            }

            progressBar.Value = Math.Min(currentFile, progressBar.Maximum);
            fileCountLabel.Text = $"File {currentFile} of {progressBar.Maximum}";
            statusLabel.Text = currentFileName;

            // Process events to keep UI responsive
            Application.DoEvents();
        }

        public void UpdateStatus(string status)
        {
            if (statusLabel.InvokeRequired)
            {
                statusLabel.Invoke(new Action(() => statusLabel.Text = status));
            }
            else
            {
                statusLabel.Text = status;
            }

            Application.DoEvents();
        }

        private void ExtractionProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Cancel();
            }
        }
    }
}
