namespace Lab_Feedback
{
    sealed partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            openNewWindowToolStripMenuItem = new ToolStripMenuItem();
            listBoxStudents = new ListBox();
            listBoxAssignments = new ListBox();
            labelStudents = new Label();
            labelAssignments = new Label();
            labelCodeView = new Label();
            panelStudents = new Panel();
            panelAssignments = new Panel();
            panelCodeView = new Panel();
            richTextBoxCodeView = new RichTextBox();
            buttonOpenWindow = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusSpacerLabel = new ToolStripStatusLabel();
            toolStripStatusScoreLabel = new ToolStripStatusLabel();
            toolStripStatusScoreValue = new ToolStripStatusLabel();
            toolStripStatusBuildsLabel = new ToolStripStatusLabel();
            toolStripStatusBuildsValue = new ToolStripStatusLabel();
            contextMenuStripNewWindow = new ContextMenuStrip(components);
            menuStripMain.SuspendLayout();
            panelStudents.SuspendLayout();
            panelAssignments.SuspendLayout();
            panelCodeView.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStripNewWindow.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Dock = DockStyle.None;
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(45, 24);
            menuStripMain.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(139, 22);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += OpenFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // openNewWindowToolStripMenuItem
            // 
            openNewWindowToolStripMenuItem.Name = "openNewWindowToolStripMenuItem";
            openNewWindowToolStripMenuItem.Size = new Size(190, 22);
            openNewWindowToolStripMenuItem.Text = "Open in New Window";
            openNewWindowToolStripMenuItem.Click += OpenNewWindowToolStripMenuItem_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.BorderStyle = BorderStyle.None;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(12, 36);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(194, 390);
            listBoxStudents.TabIndex = 2;
            listBoxStudents.SelectedIndexChanged += ListBoxStudentsSelectedIndexChanged;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.BorderStyle = BorderStyle.None;
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.ItemHeight = 15;
            listBoxAssignments.Location = new Point(13, 36);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(190, 390);
            listBoxAssignments.TabIndex = 3;
            listBoxAssignments.SelectedIndexChanged += ListBoxAssignments_SelectedIndexChanged;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudents.Location = new Point(10, 5);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(68, 15);
            labelStudents.TabIndex = 4;
            labelStudents.Text = "STUDENTS";
            // 
            // labelAssignments
            // 
            labelAssignments.AutoSize = true;
            labelAssignments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAssignments.Location = new Point(13, 5);
            labelAssignments.Name = "labelAssignments";
            labelAssignments.Size = new Size(91, 15);
            labelAssignments.TabIndex = 5;
            labelAssignments.Text = "ASSIGNMENTS";
            // 
            // labelCodeView
            // 
            labelCodeView.AutoSize = true;
            labelCodeView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodeView.Location = new Point(13, 5);
            labelCodeView.Name = "labelCodeView";
            labelCodeView.Size = new Size(71, 15);
            labelCodeView.TabIndex = 7;
            labelCodeView.Text = "CODE VIEW";
            // 
            // panelStudents
            // 
            panelStudents.BackColor = SystemColors.MenuHighlight;
            panelStudents.Controls.Add(listBoxStudents);
            panelStudents.Controls.Add(labelStudents);
            panelStudents.Location = new Point(0, 27);
            panelStudents.Margin = new Padding(1);
            panelStudents.Name = "panelStudents";
            panelStudents.Padding = new Padding(0, 2, 0, 0);
            panelStudents.Size = new Size(211, 427);
            panelStudents.TabIndex = 8;
            // 
            // panelAssignments
            // 
            panelAssignments.BackColor = SystemColors.Window;
            panelAssignments.Controls.Add(listBoxAssignments);
            panelAssignments.Controls.Add(labelAssignments);
            panelAssignments.Location = new Point(212, 27);
            panelAssignments.Name = "panelAssignments";
            panelAssignments.Padding = new Padding(0, 2, 0, 0);
            panelAssignments.Size = new Size(207, 427);
            panelAssignments.TabIndex = 9;
            // 
            // panelCodeView
            // 
            panelCodeView.BackColor = SystemColors.Window;
            panelCodeView.Controls.Add(richTextBoxCodeView);
            panelCodeView.Controls.Add(buttonOpenWindow);
            panelCodeView.Controls.Add(labelCodeView);
            panelCodeView.Location = new Point(421, 27);
            panelCodeView.Name = "panelCodeView";
            panelCodeView.Padding = new Padding(0, 2, 0, 0);
            panelCodeView.Size = new Size(632, 427);
            panelCodeView.TabIndex = 10;
            // 
            // richTextBoxCodeView
            // 
            richTextBoxCodeView.BorderStyle = BorderStyle.None;
            richTextBoxCodeView.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxCodeView.Location = new Point(13, 36);
            richTextBoxCodeView.Name = "richTextBoxCodeView";
            richTextBoxCodeView.Size = new Size(605, 388);
            richTextBoxCodeView.TabIndex = 10;
            richTextBoxCodeView.Text = "";
            // 
            // buttonOpenWindow
            // 
            buttonOpenWindow.FlatAppearance.BorderSize = 0;
            buttonOpenWindow.FlatStyle = FlatStyle.Flat;
            buttonOpenWindow.Location = new Point(567, 5);
            buttonOpenWindow.Name = "buttonOpenWindow";
            buttonOpenWindow.Size = new Size(51, 22);
            buttonOpenWindow.TabIndex = 9;
            buttonOpenWindow.Text = "· · ·";
            buttonOpenWindow.UseVisualStyleBackColor = true;
            buttonOpenWindow.Visible = false;
            buttonOpenWindow.Click += ButtonOpenWindow_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusSpacerLabel, toolStripStatusScoreLabel, toolStripStatusScoreValue, toolStripStatusBuildsLabel, toolStripStatusBuildsValue });
            statusStrip1.Location = new Point(0, 452);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1051, 22);
            statusStrip1.TabIndex = 11;
            // 
            // toolStripStatusSpacerLabel
            // 
            toolStripStatusSpacerLabel.Name = "toolStripStatusSpacerLabel";
            toolStripStatusSpacerLabel.Size = new Size(857, 17);
            toolStripStatusSpacerLabel.Spring = true;
            toolStripStatusSpacerLabel.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // toolStripStatusScoreLabel
            // 
            toolStripStatusScoreLabel.Name = "toolStripStatusScoreLabel";
            toolStripStatusScoreLabel.Padding = new Padding(0, 0, 5, 0);
            toolStripStatusScoreLabel.Size = new Size(44, 17);
            toolStripStatusScoreLabel.Text = "Score:";
            // 
            // toolStripStatusScoreValue
            // 
            toolStripStatusScoreValue.Name = "toolStripStatusScoreValue";
            toolStripStatusScoreValue.Padding = new Padding(0, 0, 15, 0);
            toolStripStatusScoreValue.Size = new Size(44, 17);
            toolStripStatusScoreValue.Text = "N/A";
            // 
            // toolStripStatusBuildsLabel
            // 
            toolStripStatusBuildsLabel.Name = "toolStripStatusBuildsLabel";
            toolStripStatusBuildsLabel.Padding = new Padding(0, 0, 5, 0);
            toolStripStatusBuildsLabel.Size = new Size(47, 17);
            toolStripStatusBuildsLabel.Text = "Builds:";
            // 
            // toolStripStatusBuildsValue
            // 
            toolStripStatusBuildsValue.Name = "toolStripStatusBuildsValue";
            toolStripStatusBuildsValue.Padding = new Padding(0, 0, 15, 0);
            toolStripStatusBuildsValue.Size = new Size(44, 17);
            toolStripStatusBuildsValue.Text = "N/A";
            // 
            // contextMenuStripNewWindow
            // 
            contextMenuStripNewWindow.Items.AddRange(new ToolStripItem[] { openNewWindowToolStripMenuItem });
            contextMenuStripNewWindow.Name = "contextMenuStripNewWindow";
            contextMenuStripNewWindow.Size = new Size(191, 26);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1051, 474);
            Controls.Add(statusStrip1);
            Controls.Add(panelAssignments);
            Controls.Add(menuStripMain);
            Controls.Add(panelStudents);
            Controls.Add(panelCodeView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            panelStudents.ResumeLayout(false);
            panelStudents.PerformLayout();
            panelAssignments.ResumeLayout(false);
            panelAssignments.PerformLayout();
            panelCodeView.ResumeLayout(false);
            panelCodeView.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStripNewWindow.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openNewWindowToolStripMenuItem;
        private GroupBox groupBoxStudents;
        private ListBox listBoxStudents;
        private GroupBox groupBoxAssignments;
        private ListBox listBoxAssignments;
        private ToolStripSeparator toolStripSeparator1;
        private Label labelStudents;
        private Label labelAssignments;
        private Label labelCodeView;
        private Panel panelStudents;
        private Panel panelAssignments;
        private Panel panelCodeView;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusSpacerLabel;
        private ToolStripStatusLabel toolStripStatusScoreLabel;
        private ToolStripStatusLabel toolStripStatusBuildsLabel;
        private ToolStripStatusLabel toolStripStatusScoreValue;
        private ToolStripStatusLabel toolStripStatusBuildsValue;
        private Button buttonOpenWindow;
        private RichTextBox richTextBoxCodeView;
        private ContextMenuStrip contextMenuStripNewWindow;
    }
}