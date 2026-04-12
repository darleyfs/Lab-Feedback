using System.Runtime.InteropServices;
using Lab_Feedback.Services;

namespace Lab_Feedback
{
    public sealed partial class Form1 : IThemeable
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string? pszSubIdList);

        public void ApplyTheme(bool isLightTheme)
        {
            ApplyCodeViewTheme(isLightTheme);
            ApplyStatusStripTheme(isLightTheme);
            ApplyScrollBarTheme(isLightTheme);
        }

        private void ApplyCodeViewTheme(bool isLightTheme)
        {
            var colors = isLightTheme
                ? ThemeHelper.MonokaiColors.Light
                : ThemeHelper.MonokaiColors.Dark;

            labelCodeView.BackColor = colors.BACKGROUND;
            labelCodeView.ForeColor = colors.FOREGROUND;

            foreach (var label in panelCodeView.Controls.OfType<Label>()
                         .Where(l => l.Name != "labelCodeView"))
            {
                label.BackColor = colors.BACKGROUND;
                label.ForeColor = colors.FOREGROUND;
            }
        }

        private void ApplyStatusStripTheme(bool isLightTheme)
        {
            var isNeutral = toolStripStatusViolationsCount.ForeColor != Color.Red
                         && toolStripStatusViolationsCount.ForeColor != Color.Orange;

            if (isNeutral)
            {
                toolStripStatusViolationsCount.ForeColor = isLightTheme
                    ? ThemeHelper.LightForeground
                    : ThemeHelper.DarkForeground;
            }
        }

        private void ApplyScrollBarTheme(bool isLightTheme)
        {
            var theme = isLightTheme ? "Explorer" : "DarkMode_Explorer";

            SetWindowTheme(richTextBoxCodeView.Handle, theme, null);
            SetWindowTheme(listBoxStudents.Handle, theme, null);
            SetWindowTheme(listBoxAssignments.Handle, theme, null);
        }
    }
}