namespace Lab_Feedback.Views
{
    partial class ExtractionProgressDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            fileCountLabel = new Label();
            cancelButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 20);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(390, 25);
            progressBar.TabIndex = 0;
            // 
            // fileCountLabel
            // 
            fileCountLabel.AutoSize = true;
            fileCountLabel.Location = new Point(20, 55);
            fileCountLabel.Name = "fileCountLabel";
            fileCountLabel.Size = new Size(67, 15);
            fileCountLabel.TabIndex = 1;
            fileCountLabel.Text = "Preparing...";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(335, 104);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 25);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(20, 80);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 15);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Extracting project files...";
            // 
            // ExtractionProgressDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 141);
            Controls.Add(statusLabel);
            Controls.Add(cancelButton);
            Controls.Add(fileCountLabel);
            Controls.Add(progressBar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExtractionProgressDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Extracting Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label fileCountLabel;
        private Button cancelButton;
        private Label statusLabel;
    }
}