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
            statusStrip1 = new StatusStrip();
            toolStripStatusSpacerLabel = new ToolStripStatusLabel();
            toolStripStatusBuildsLabel = new ToolStripStatusLabel();
            toolStripStatusBuildsValue = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusViolationsCount = new ToolStripStatusLabel();
            toolStripStatusScoreLabel = new ToolStripStatusLabel();
            toolStripStatusScoreValue = new ToolStripStatusLabel();
            contextMenuStripNewWindow = new ContextMenuStrip(components);
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panelStudents = new Panel();
            listBoxStudents = new ListBox();
            labelStudents = new Label();
            panelAssignments = new Panel();
            listBoxAssignments = new ListBox();
            labelAssignments = new Label();
            panelCodeView = new Panel();
            richTextBoxCodeView = new RichTextBox();
            buttonOpenWindow = new Button();
            labelCodeView = new Label();
            menuStripMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStripNewWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panelStudents.SuspendLayout();
            panelAssignments.SuspendLayout();
            panelCodeView.SuspendLayout();
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusSpacerLabel, toolStripStatusBuildsLabel, toolStripStatusBuildsValue, toolStripStatusLabel1, toolStripStatusViolationsCount, toolStripStatusScoreLabel, toolStripStatusScoreValue });
            statusStrip1.Location = new Point(0, 656);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 22);
            statusStrip1.TabIndex = 11;
            // 
            // toolStripStatusSpacerLabel
            // 
            toolStripStatusSpacerLabel.Name = "toolStripStatusSpacerLabel";
            toolStripStatusSpacerLabel.Size = new Size(781, 17);
            toolStripStatusSpacerLabel.Spring = true;
            toolStripStatusSpacerLabel.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(112, 17);
            toolStripStatusLabel1.Text = "Potential Violations:";
            // 
            // toolStripStatusViolationsCount
            // 
            toolStripStatusViolationsCount.Name = "toolStripStatusViolationsCount";
            toolStripStatusViolationsCount.Size = new Size(13, 17);
            toolStripStatusViolationsCount.Text = "0";
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
            // contextMenuStripNewWindow
            // 
            contextMenuStripNewWindow.Items.AddRange(new ToolStripItem[] { openNewWindowToolStripMenuItem });
            contextMenuStripNewWindow.Name = "contextMenuStripNewWindow";
            contextMenuStripNewWindow.Size = new Size(191, 26);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelCodeView);
            splitContainer1.Size = new Size(1100, 656);
            splitContainer1.SplitterDistance = 523;
            splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panelStudents);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(panelAssignments);
            splitContainer2.Size = new Size(523, 656);
            splitContainer2.SplitterDistance = 224;
            splitContainer2.TabIndex = 0;
            // 
            // panelStudents
            // 
            panelStudents.BackColor = SystemColors.MenuHighlight;
            panelStudents.Controls.Add(listBoxStudents);
            panelStudents.Controls.Add(labelStudents);
            panelStudents.Dock = DockStyle.Fill;
            panelStudents.Location = new Point(0, 0);
            panelStudents.Margin = new Padding(1);
            panelStudents.Name = "panelStudents";
            panelStudents.Padding = new Padding(0, 2, 0, 0);
            panelStudents.Size = new Size(224, 656);
            panelStudents.TabIndex = 9;
            // 
            // listBoxStudents
            // 
            listBoxStudents.BorderStyle = BorderStyle.None;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(12, 26);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(208, 630);
            listBoxStudents.TabIndex = 2;
            listBoxStudents.SelectedIndexChanged += ListBoxStudentsSelectedIndexChanged;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudents.Location = new Point(10, 7);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(68, 15);
            labelStudents.TabIndex = 4;
            labelStudents.Text = "STUDENTS";
            // 
            // panelAssignments
            // 
            panelAssignments.BackColor = SystemColors.Window;
            panelAssignments.Controls.Add(listBoxAssignments);
            panelAssignments.Controls.Add(labelAssignments);
            panelAssignments.Dock = DockStyle.Fill;
            panelAssignments.Location = new Point(0, 0);
            panelAssignments.Name = "panelAssignments";
            panelAssignments.Padding = new Padding(0, 2, 0, 0);
            panelAssignments.Size = new Size(295, 656);
            panelAssignments.TabIndex = 10;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.BorderStyle = BorderStyle.None;
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.ItemHeight = 15;
            listBoxAssignments.Location = new Point(13, 26);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(279, 630);
            listBoxAssignments.TabIndex = 3;
            listBoxAssignments.SelectedIndexChanged += ListBoxAssignments_SelectedIndexChanged;
            // 
            // labelAssignments
            // 
            labelAssignments.AutoSize = true;
            labelAssignments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAssignments.Location = new Point(13, 7);
            labelAssignments.Name = "labelAssignments";
            labelAssignments.Size = new Size(91, 15);
            labelAssignments.TabIndex = 5;
            labelAssignments.Text = "ASSIGNMENTS";
            // 
            // panelCodeView
            // 
            panelCodeView.BackColor = SystemColors.Window;
            panelCodeView.Controls.Add(richTextBoxCodeView);
            panelCodeView.Controls.Add(buttonOpenWindow);
            panelCodeView.Controls.Add(labelCodeView);
            panelCodeView.Dock = DockStyle.Fill;
            panelCodeView.Location = new Point(0, 0);
            panelCodeView.Name = "panelCodeView";
            panelCodeView.Padding = new Padding(0, 2, 0, 0);
            panelCodeView.Size = new Size(573, 656);
            panelCodeView.TabIndex = 11;
            // 
            // richTextBoxCodeView
            // 
            richTextBoxCodeView.BorderStyle = BorderStyle.None;
            richTextBoxCodeView.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxCodeView.Location = new Point(13, 36);
            richTextBoxCodeView.Name = "richTextBoxCodeView";
            richTextBoxCodeView.Size = new Size(557, 617);
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
            // 
            // labelCodeView
            // 
            labelCodeView.AutoSize = true;
            labelCodeView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodeView.Location = new Point(13, 7);
            labelCodeView.Name = "labelCodeView";
            labelCodeView.Size = new Size(71, 15);
            labelCodeView.TabIndex = 7;
            labelCodeView.Text = "CODE VIEW";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 678);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStripMain);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStripNewWindow.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panelStudents.ResumeLayout(false);
            panelStudents.PerformLayout();
            panelAssignments.ResumeLayout(false);
            panelAssignments.PerformLayout();
            panelCodeView.ResumeLayout(false);
            panelCodeView.PerformLayout();
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
        private GroupBox groupBoxAssignments;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusSpacerLabel;
        private ToolStripStatusLabel toolStripStatusScoreLabel;
        private ToolStripStatusLabel toolStripStatusBuildsLabel;
        private ToolStripStatusLabel toolStripStatusScoreValue;
        private ToolStripStatusLabel toolStripStatusBuildsValue;
        private ContextMenuStrip contextMenuStripNewWindow;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusViolationsCount;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Panel panelStudents;
        private ListBox listBoxStudents;
        private Label labelStudents;
        private Panel panelAssignments;
        private ListBox listBoxAssignments;
        private Label labelAssignments;
        private Panel panelCodeView;
        private RichTextBox richTextBoxCodeView;
        private Button buttonOpenWindow;
        private Label labelCodeView;
    }
}