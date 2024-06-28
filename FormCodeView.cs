using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Lab_Feedback
{
    public partial class FormCodeView : Form
    {
        private string codeText;
        private string titleText;

        public FormCodeView(string codeText, string filename)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            this.codeText = codeText;
            titleText = filename;

            MonokaiSyntaxHighlighter.NewInstance(richTextBoxCodeFullView);
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

        private void FormCodeView_Load(object sender, EventArgs e)
        {
            richTextBoxCodeFullView.Text = codeText;
            Text = titleText;
        }
    }
}
