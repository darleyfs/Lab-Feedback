using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using WinFormsSyntaxHighlighter;
using System.DirectoryServices.ActiveDirectory;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Lab_Feedback
{
    public sealed partial class Form1 : Form
    {
        ContextMenuStrip contextMenu;
        ToolStripMenuItem openInFileExplorer;
        Panel titleBar;
        Label titleLabel;
        Button closeButton;
        Button minimizeButton;
        Button maximizeButton;

        private Label selectedLabel;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomTitleBar();
            InitializeContextMenu();

            ThemeHelper.ApplyTheme(this);
            ThemeHelper.ApplyBackColorToListBox(listBoxStudents);
            SystemEvents.UserPreferenceChanged += OnUserPreferenceChanged;
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            (new DropShadow()).ApplyShadows(this);

            var syntaxHighlighter = MonokaiSyntaxHighlighter.NewInstance(richTextBoxCodeView, panelCodeView, labelCodeView);
        }

        private void InitializeCustomTitleBar()
        {
            titleBar = new Panel();
            titleLabel = new Label();
            closeButton = new Button();
            minimizeButton = new Button();
            maximizeButton = new Button();

            // Title bar
            titleBar.BackColor = Color.FromArgb(37, 37, 38);
            titleBar.Dock = DockStyle.Top;
            titleBar.Height = 30;
            titleBar.Width = 100;
            titleBar.MouseDown += TitleBar_MouseDown;

            // Title label
            // titleLabel.Text = "My Modern App";
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(10, 7);
            titleLabel.AutoSize = true;

            // Minimize button
            minimizeButton.Text = "—";
            minimizeButton.ForeColor = Color.White;
            minimizeButton.BackColor = Color.FromArgb(37, 37, 38);
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Location = new Point(this.Width - 150, 0);
            minimizeButton.Size = new Size(45, 30);
            minimizeButton.Click += new EventHandler(MinimizeButton_Click);

            // Maximize button
            maximizeButton.Text = "◻";
            maximizeButton.ForeColor = Color.White;
            maximizeButton.BackColor = Color.FromArgb(37, 37, 38);
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.Location = new Point(this.Width - 105, 0);
            maximizeButton.Size = new Size(45, 30);
            maximizeButton.Click += new EventHandler(MaximizeButton_Click);

            // Close button
            closeButton.Text = "✕";
            closeButton.ForeColor = Color.White;
            closeButton.BackColor = Color.FromArgb(37, 37, 38);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(this.Width - 60, 0);
            closeButton.Size = new Size(45, 30);
            closeButton.Click += new EventHandler(CloseButton_Click);
            closeButton.MouseEnter += CloseButton_OnMouseOverEnter;
            closeButton.MouseLeave += CloseButton_OnMouseOverExit;

            // Add controls to title bar
            titleBar.Controls.Add(menuStripMain);
            titleBar.Controls.Add(titleLabel);
            titleBar.Controls.Add(closeButton);
            titleBar.Controls.Add(minimizeButton);
            titleBar.Controls.Add(maximizeButton);
            menuStripMain.Margin = new Padding(0, 0, closeButton.Width * 5, 0);

            // Add title bar to form
            Controls.Add(titleBar);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxStudents.DisplayMember = "FullName";
            listBoxStudents.ValueMember = "Folder";

            listBoxAssignments.DisplayMember = "Name";
            listBoxAssignments.ValueMember = "Folder";
        }

        private void InitializeContextMenu()
        {
            // Create context menu and menu item
            contextMenu = new ContextMenuStrip();
            openInFileExplorer = new ToolStripMenuItem("Open in File Explorer");

            // Add menu item to context menu
            contextMenu.Items.Add(openInFileExplorer);

            // Attach context menu to ListBox
            listBoxStudents.ContextMenuStrip = contextMenu;

            // Attach event handler for menu item click
            openInFileExplorer.Click += OpenInFileExplorer_Click;
        }

        private void OpenInFileExplorer_Click(object? sender, EventArgs e)
        {

            // Ensure an item is selected
            if (listBoxStudents.SelectedItem == null) return;

            // Get the file path from the selected item's Value property
            var filePath = ((Student)listBoxStudents.SelectedItem).Folder;

            // Check if the file path is valid
            if (!string.IsNullOrEmpty(filePath) && System.IO.Directory.Exists(filePath))
            {
                // Open the file in File Explorer
                Process.Start("explorer.exe", filePath);
            }
            else
            {
                MessageBox.Show("Invalid file path or file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                ThemeHelper.ApplyTheme(this);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= OnUserPreferenceChanged;
            base.OnFormClosed(e);
        }

        private void ListBoxStudentsSelectedIndexChanged(object sender, EventArgs e)
        {
            var path = ((Student)listBoxStudents.SelectedItem!)?.Folder;

            // Search folder for Lab projects
            if (path == null) return;

            // Search folder for ZIP files, extract and delete them
            ZipFileHandler.ExtractZipFilesInFolder(path);

            var assignments = Assignment.FindLabOrPracticalSubfolders(path);

            // Clear Assignment list
            listBoxAssignments.Items.Clear();

            // Populate with assignments
            foreach (var assignment in assignments)
            {
                listBoxAssignments.Items.Add(assignment);
            }
        }

        private void ListBoxAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveExistingLabels();

            if (listBoxAssignments.SelectedItem is not Assignment selectedAssignment) return;

            var name = selectedAssignment.Name;
            var path = selectedAssignment.Folder;
            string? filePath = null;

            if (name == null || path == null) return;

            // Ignore boiler-plate files
            var exclusions = new List<string>
            {
                "Source.cpp",
                "Test.cpp",
                "Test.h",
                "Tester.cpp",
                "Tester.h",
                "Utility.cpp",
                "Utility.h",
                "UI.h",
                "ShopUtils.cpp",
                "ShopUtils.h",
                "LabUI.h",
                "resource.h",
                "LLMChecker.h",
                "ProgressBar.h",
                "Result.h",
                "Results.h",
                "ResultsLib.h",
                "LabTestUtils.h",
                "Console.h",
                "Console.cpp"
            };

            

            if (name.StartsWith("Lab ") || name.StartsWith("Midterm") || name.StartsWith("Final"))
            {
                PopulateCodeViewLabels(name, path, exclusions);

                // If the project is a lab
                if (name.StartsWith("Lab "))
                {
                    // First, check for StudentWork.h (new format)
                    if (FileHandler.SearchFile(path, "StudentWork.h") != "")
                    {
                        filePath = FileHandler.SearchFile(path, "StudentWork.h");
                    }

                    // Then, check for Submission.cpp (old format)
                    if (FileHandler.SearchFile(path, "Submission.cpp") != "")
                    {
                        filePath = FileHandler.SearchFile(path, "Submission.cpp");
                    }
                }

                // TODO: Make this more generic eventually.
                if (name.StartsWith("Midterm"))
                {
                    filePath = FileHandler.SearchFile(path, "HighScore_Table.cpp");
                }

                if (name.StartsWith("Final"))
                {
                    filePath = FileHandler.SearchFile(path, "RPG_Shop.cpp");
                }

                // TODO: Why is this still firing?
                //else
                //{
                //    // Otherwise, it's a Practical and use the CPP.
                //    filePath = FileHandler.SearchFile(path, $"{name}.cpp");
                //    MessageBox.Show(filePath);
                //}
            }

            if (string.IsNullOrEmpty(path)) return;

            if (!string.IsNullOrEmpty(filePath))
            {
                var text = System.IO.File.ReadAllText(@filePath);

                richTextBoxCodeView.Text = (string.IsNullOrEmpty(text)) ? "" : text;
                richTextBoxCodeView.ReadOnly = true;
                buttonOpenWindow.Visible = true;
            }
            else
            {
                MessageBox.Show( "There may be a problem with the folder structure.\n\nDo you want to open this folder? (This isn't implemented yet)", "Error opening file path.");
            }
        }

        private void RemoveExistingLabels()
        {
            var labelsToRemove = panelCodeView.Controls.OfType<Label>()
                .Where(label => label.Name != "labelCodeView")
                .ToArray();

            foreach (var label in labelsToRemove)
            {
                panelCodeView.Controls.Remove(label);
                label.Dispose();
            }
        }


        private Label CreateCodeViewLabel(string filepath, int xPos, bool first = false)
        {
            // Create a new label
            var labelFileName = new Label {
                // Fill out the file properties
                Text = Path.GetFileName(filepath),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
                Padding = new Padding(5, 2, 5, 2),
                Location = new Point(xPos + 20, 3),
                AutoSize = true,
                ForeColor = ThemeHelper.DarkForeground,
                BackColor = first ? Color.FromArgb(15, 255, 255, 255) : ThemeHelper.MonokaiColors.Dark.BACKGROUND
            };

            // Add listeners and filepath as data-tag
            labelFileName.MouseEnter += FileLabel_OnMouseOver;
            labelFileName.MouseLeave += FileLabel_OnMouseExit;
            labelFileName.Click += FileLabel_OnClick;
            labelFileName.Tag = filepath;

            return labelFileName;
        }

        private void PopulateCodeViewLabels(string name, string path, List<string> exclusions)
        {
            // Position first label
            var xPos = labelCodeView.Width;
            var first = true;

            var resultsPath = FileHandler.SearchFile(path, "hdkvkt.txt");

            // If it's a lab, we need to ignore the main method container file.
            if (name.StartsWith("Lab"))
            {
                exclusions.Add(name + ".cpp");
                exclusions.Add(name.Replace(" ", "") + ".cpp");
                SetResultStatusLabels(resultsPath, name);
            }

            // Capture paths of located project files
            // var filePaths = FileHandler.SearchCppFiles(path, exclusions);
            var filePaths = FileHandler.SearchHeaderFiles(path, exclusions);

            // For each found file
            foreach (var fp in filePaths)
            {
                // Create a new label
                var labelFileName = CreateCodeViewLabel(fp, xPos, first);

                // Add the label to the panel
                panelCodeView.Controls.Add(labelFileName);

                // If it's the first file mark it as selected
                if (first)
                {
                    selectedLabel = labelFileName;
                }

                // Offset additional label positions.
                xPos += labelFileName.Width;
                first = false;
            }
        }

        private void SetResultStatusLabels(string resultsPath, string projectName)
        {
            if (resultsPath.Length > 0)
            {
                var results = FileHandler.ParseFile(resultsPath);

                var resultsSize = results.Count;

                toolStripStatusBuildsValue.Text = results.Count.ToString();
                toolStripStatusScoreValue.Text = results[resultsSize - 1].Number.ToString();
            }
            else
            {
                MessageBox.Show("Build logs not found for " + projectName + ".");
                toolStripStatusBuildsValue.Text = "N/A";
                toolStripStatusScoreValue.Text = "N/A";
            }
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            var subfolders = Student.GetStudentsFromFolders(folderBrowserDialog1.SelectedPath);

            listBoxStudents.Items.Clear();

            foreach (var student in subfolders)
            {
                listBoxStudents.Items.Add(student);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileLabel_OnMouseOver(object sender, EventArgs e)
        {
            if (selectedLabel != sender) ((Label)sender).BackColor =
                Color.FromArgb(20, 255, 255, 255);
        }

        private void FileLabel_OnMouseExit(object sender, EventArgs e)
        {
            if (selectedLabel != sender) ((Label)sender).BackColor =
                ((Label)sender).BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
        }

        private void FileLabel_OnClick(object sender, EventArgs e)
        {
            selectedLabel.BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
            selectedLabel = (Label)sender;


            var path = (string)((Label)sender).Tag!;
            var text = System.IO.File.ReadAllText(@path);

            richTextBoxCodeView.Text = (string.IsNullOrEmpty(text)) ? "" : text;
            richTextBoxCodeView.ReadOnly = true;
        }

        private void CloseButton_OnMouseOverEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(175, 255, 50, 50);
            closeButton.ForeColor = Color.FromArgb(225, 225, 225);
        }

        private void CloseButton_OnMouseOverExit(object sender, EventArgs e)
        {
            closeButton.BackColor = ThemeHelper.DarkBackground;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState =
                WindowState == FormWindowState.Maximized ?
                    FormWindowState.Normal :
                    FormWindowState.Maximized;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            ReleaseCapture();

            SendMessageW(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // _BoarderRadius can be adjusted to your needs, try 15 to start.
            System.IntPtr ptr =
                CreateRoundRectRgn(0, 0, Width, Height, 15, 15);

            Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        private void ButtonOpenWindow_Click(object sender, EventArgs e)
        {
            contextMenuStripNewWindow.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        private void OpenNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCodeView(richTextBoxCodeView.Text, "test.cpp");
            form.Show();
        }

        // P/Invoke declarations
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [LibraryImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool ReleaseCapture();

        [LibraryImport("user32.dll", StringMarshalling = StringMarshalling.Utf16)]
        private static partial IntPtr SendMessageW(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Rounded corners
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static partial System.IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        [LibraryImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool DeleteObject(System.IntPtr hObject);
    }
}