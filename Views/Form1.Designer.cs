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
            Panel panelCodeViewTop;
            buttonOpenWindow = new Button();
            labelCodeView = new Label();
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
            tableLayoutStudents = new TableLayoutPanel();
            listBoxStudents = new ListBox();
            panelStudentsTop = new Panel();
            labelStudents = new Label();
            panelAssignments = new Panel();
            tableLayoutAssignments = new TableLayoutPanel();
            listBoxAssignments = new ListBox();
            panelAssignmentsTop = new Panel();
            labelAssignments = new Label();
            panelCodeView = new Panel();
            tableLayoutCodeView = new TableLayoutPanel();
            richTextBoxCodeView = new RichTextBox();
            panelCodeViewTop = new Panel();
            panelCodeViewTop.SuspendLayout();
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
            tableLayoutStudents.SuspendLayout();
            panelStudentsTop.SuspendLayout();
            panelAssignments.SuspendLayout();
            tableLayoutAssignments.SuspendLayout();
            panelAssignmentsTop.SuspendLayout();
            panelCodeView.SuspendLayout();
            tableLayoutCodeView.SuspendLayout();
            SuspendLayout();
            // 
            // panelCodeViewTop
            // 
            panelCodeViewTop.Controls.Add(buttonOpenWindow);
            panelCodeViewTop.Controls.Add(labelCodeView);
            panelCodeViewTop.Dock = DockStyle.Fill;
            panelCodeViewTop.Location = new Point(15, 3);
            panelCodeViewTop.Name = "panelCodeViewTop";
            panelCodeViewTop.Size = new Size(555, 24);
            panelCodeViewTop.TabIndex = 17;
            // 
            // buttonOpenWindow
            // 
            buttonOpenWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenWindow.FlatAppearance.BorderSize = 0;
            buttonOpenWindow.FlatStyle = FlatStyle.Flat;
            buttonOpenWindow.Location = new Point(507, 0);
            buttonOpenWindow.Name = "buttonOpenWindow";
            buttonOpenWindow.Size = new Size(51, 22);
            buttonOpenWindow.TabIndex = 16;
            buttonOpenWindow.Text = "· · ·";
            buttonOpenWindow.UseVisualStyleBackColor = true;
            buttonOpenWindow.Visible = false;
            buttonOpenWindow.Click += ButtonOpenWindow_Click;
            // 
            // labelCodeView
            // 
            labelCodeView.AutoSize = true;
            labelCodeView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodeView.Location = new Point(3, 4);
            labelCodeView.Name = "labelCodeView";
            labelCodeView.Size = new Size(71, 15);
            labelCodeView.TabIndex = 15;
            labelCodeView.Text = "CODE VIEW";
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
            panelStudents.BackColor = SystemColors.Window;
            panelStudents.Controls.Add(tableLayoutStudents);
            panelStudents.Dock = DockStyle.Fill;
            panelStudents.Location = new Point(0, 0);
            panelStudents.Margin = new Padding(1);
            panelStudents.Name = "panelStudents";
            panelStudents.Padding = new Padding(0, 2, 0, 0);
            panelStudents.Size = new Size(224, 656);
            panelStudents.TabIndex = 9;
            // 
            // tableLayoutStudents
            // 
            tableLayoutStudents.ColumnCount = 1;
            tableLayoutStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutStudents.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutStudents.Controls.Add(listBoxStudents, 0, 1);
            tableLayoutStudents.Controls.Add(panelStudentsTop, 0, 0);
            tableLayoutStudents.Dock = DockStyle.Fill;
            tableLayoutStudents.Location = new Point(0, 2);
            tableLayoutStudents.Name = "tableLayoutStudents";
            tableLayoutStudents.Padding = new Padding(12, 0, 0, 0);
            tableLayoutStudents.RowCount = 2;
            tableLayoutStudents.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutStudents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutStudents.Size = new Size(224, 654);
            tableLayoutStudents.TabIndex = 5;
            // 
            // listBoxStudents
            // 
            listBoxStudents.BorderStyle = BorderStyle.None;
            listBoxStudents.Dock = DockStyle.Fill;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(15, 33);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(206, 618);
            listBoxStudents.TabIndex = 3;
            listBoxStudents.SelectedIndexChanged += ListBoxStudentsSelectedIndexChanged;
            // 
            // panelStudentsTop
            // 
            panelStudentsTop.Controls.Add(labelStudents);
            panelStudentsTop.Dock = DockStyle.Fill;
            panelStudentsTop.Location = new Point(15, 3);
            panelStudentsTop.Name = "panelStudentsTop";
            panelStudentsTop.Size = new Size(206, 24);
            panelStudentsTop.TabIndex = 0;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudents.Location = new Point(-3, 4);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(68, 15);
            labelStudents.TabIndex = 5;
            labelStudents.Text = "STUDENTS";
            // 
            // panelAssignments
            // 
            panelAssignments.BackColor = SystemColors.Window;
            panelAssignments.Controls.Add(tableLayoutAssignments);
            panelAssignments.Dock = DockStyle.Fill;
            panelAssignments.Location = new Point(0, 0);
            panelAssignments.Name = "panelAssignments";
            panelAssignments.Padding = new Padding(0, 2, 0, 0);
            panelAssignments.Size = new Size(295, 656);
            panelAssignments.TabIndex = 10;
            // 
            // tableLayoutAssignments
            // 
            tableLayoutAssignments.ColumnCount = 1;
            tableLayoutAssignments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAssignments.Controls.Add(listBoxAssignments, 0, 1);
            tableLayoutAssignments.Controls.Add(panelAssignmentsTop, 0, 0);
            tableLayoutAssignments.Dock = DockStyle.Fill;
            tableLayoutAssignments.Location = new Point(0, 2);
            tableLayoutAssignments.Name = "tableLayoutAssignments";
            tableLayoutAssignments.Padding = new Padding(12, 0, 0, 0);
            tableLayoutAssignments.RowCount = 2;
            tableLayoutAssignments.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutAssignments.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAssignments.Size = new Size(295, 654);
            tableLayoutAssignments.TabIndex = 6;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.BorderStyle = BorderStyle.None;
            listBoxAssignments.Dock = DockStyle.Fill;
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.ItemHeight = 15;
            listBoxAssignments.Location = new Point(15, 33);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(277, 618);
            listBoxAssignments.TabIndex = 7;
            listBoxAssignments.SelectedIndexChanged += ListBoxAssignments_SelectedIndexChanged;
            // 
            // panelAssignmentsTop
            // 
            panelAssignmentsTop.Controls.Add(labelAssignments);
            panelAssignmentsTop.Dock = DockStyle.Fill;
            panelAssignmentsTop.Location = new Point(15, 3);
            panelAssignmentsTop.Name = "panelAssignmentsTop";
            panelAssignmentsTop.Size = new Size(277, 24);
            panelAssignmentsTop.TabIndex = 8;
            // 
            // labelAssignments
            // 
            labelAssignments.AutoSize = true;
            labelAssignments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAssignments.Location = new Point(0, 4);
            labelAssignments.Name = "labelAssignments";
            labelAssignments.Size = new Size(91, 15);
            labelAssignments.TabIndex = 7;
            labelAssignments.Text = "ASSIGNMENTS";
            // 
            // panelCodeView
            // 
            panelCodeView.BackColor = SystemColors.Window;
            panelCodeView.Controls.Add(tableLayoutCodeView);
            panelCodeView.Dock = DockStyle.Fill;
            panelCodeView.Location = new Point(0, 0);
            panelCodeView.Name = "panelCodeView";
            panelCodeView.Padding = new Padding(0, 2, 0, 0);
            panelCodeView.Size = new Size(573, 656);
            panelCodeView.TabIndex = 11;
            // 
            // tableLayoutCodeView
            // 
            tableLayoutCodeView.ColumnCount = 1;
            tableLayoutCodeView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCodeView.Controls.Add(richTextBoxCodeView, 0, 1);
            tableLayoutCodeView.Controls.Add(panelCodeViewTop, 0, 0);
            tableLayoutCodeView.Dock = DockStyle.Fill;
            tableLayoutCodeView.Location = new Point(0, 2);
            tableLayoutCodeView.Name = "tableLayoutCodeView";
            tableLayoutCodeView.Padding = new Padding(12, 0, 0, 0);
            tableLayoutCodeView.RowCount = 2;
            tableLayoutCodeView.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutCodeView.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutCodeView.Size = new Size(573, 654);
            tableLayoutCodeView.TabIndex = 15;
            // 
            // richTextBoxCodeView
            // 
            richTextBoxCodeView.BorderStyle = BorderStyle.None;
            richTextBoxCodeView.Dock = DockStyle.Fill;
            richTextBoxCodeView.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxCodeView.ImeMode = ImeMode.Off;
            richTextBoxCodeView.Location = new Point(15, 33);
            richTextBoxCodeView.Name = "richTextBoxCodeView";
            richTextBoxCodeView.Size = new Size(555, 618);
            richTextBoxCodeView.TabIndex = 18;
            richTextBoxCodeView.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1100, 678);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStripMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            panelCodeViewTop.ResumeLayout(false);
            panelCodeViewTop.PerformLayout();
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
            tableLayoutStudents.ResumeLayout(false);
            panelStudentsTop.ResumeLayout(false);
            panelStudentsTop.PerformLayout();
            panelAssignments.ResumeLayout(false);
            tableLayoutAssignments.ResumeLayout(false);
            panelAssignmentsTop.ResumeLayout(false);
            panelAssignmentsTop.PerformLayout();
            panelCodeView.ResumeLayout(false);
            tableLayoutCodeView.ResumeLayout(false);
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
        private Panel panelAssignments;
        private Panel panelCodeView;
        private Panel panelCodeViewTop;
        private TableLayoutPanel tableLayoutCodeView;
        private RichTextBox richTextBoxCodeView;
        private Button buttonOpenWindow;
        private Label labelCodeView;
        private TableLayoutPanel tableLayoutAssignments;
        private ListBox listBoxAssignments;
        private Panel panelAssignmentsTop;
        private Label labelAssignments;
        private TableLayoutPanel tableLayoutStudents;
        private ListBox listBoxStudents;
        private Panel panelStudentsTop;
        private Label labelStudents;
    }
}