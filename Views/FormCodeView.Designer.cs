namespace Lab_Feedback
{
    partial class FormCodeView
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
            richTextBoxCodeFullView = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxCodeFullView
            // 
            richTextBoxCodeFullView.Dock = DockStyle.Fill;
            richTextBoxCodeFullView.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxCodeFullView.Location = new Point(0, 0);
            richTextBoxCodeFullView.Name = "richTextBoxCodeFullView";
            richTextBoxCodeFullView.Size = new Size(800, 450);
            richTextBoxCodeFullView.TabIndex = 0;
            richTextBoxCodeFullView.Text = "";
            // 
            // FormCodeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxCodeFullView);
            Name = "FormCodeView";
            Text = "FormCodeView";
            Load += FormCodeView_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxCodeFullView;
    }
}