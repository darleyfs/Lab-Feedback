using Microsoft.Win32;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab_Feedback {

    internal class ThemeHelper
    {
        public static Color LightBackground = Color.FromArgb(245, 245, 245); // Light gray
        public static Color LightForeground = Color.FromArgb(30, 30, 30);    // Dark gray

        public static Color DarkBackground = Color.FromArgb(30, 30, 30);     // Dark gray
        public static Color DarkForeground = Color.FromArgb(180, 180, 180);  // Light gray

        public static void ApplyTheme(Form form)
        {
            var isLightTheme = ThemeHelper.IsLightTheme();

            if (isLightTheme)
            {
                form.BackColor = LightBackground;
                form.ForeColor = LightForeground;

                // Apply light theme styles to other controls
                ApplyLightThemeToControls(form);
            }
            else
            {
                form.BackColor = DarkBackground;
                form.ForeColor = DarkForeground;

                // Apply dark theme styles to other controls
                ApplyDarkThemeToControls(form);
            }
        }

        public static bool IsLightTheme()
        {
            try
            {
                var registryKey =
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
                if (registryKey != null)
                {
                    var themeValue = registryKey.GetValue("AppsUseLightTheme");
                    if (themeValue != null)
                    {
                        return (int)themeValue == 1;
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            // Default to light theme if there's an issue accessing the registry
            return true;
        }

        private static void ApplyLightThemeToControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                ApplyLightThemeToControl(control);
                ApplyThemeToContextMenus(form, true);
            }
        }

        private static void ApplyDarkThemeToControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                ApplyDarkThemeToControl(control);
                ApplyThemeToContextMenus(form);
            }

            var studentPanel = form.Controls.Find("panelStudents", false);
            if(studentPanel.Length > 0) studentPanel[0].BackColor = Color.FromArgb(26, 26, 26);

            var studentLabel = form.Controls.Find("labelStudents", false);
            if(studentLabel.Length > 0) studentLabel[0].BackColor = Color.FromArgb(26, 26, 26);
        }

        public static void ApplyBackColorToListBox(ListBox listBox)
        {
            listBox.BackColor = IsLightTheme() ?
                Color.FromArgb(225, 225, 225) :
                Color.FromArgb(26, 26, 26);
        }

        private static void ApplyLightThemeToControl(Control control)
        {
            control.BackColor = LightBackground;
            control.ForeColor = LightForeground;

            if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = LightForeground;
                foreach (Control subControl in groupBox.Controls)
                {
                    ApplyLightThemeToControl(subControl);
                }
            }
            else
            {
                foreach (Control subControl in control.Controls)
                {
                    ApplyLightThemeToControl(subControl);
                }
            }
        }

        private static void ApplyDarkThemeToControl(Control control)
        {
            control.BackColor = DarkBackground;
            control.ForeColor = DarkForeground;

            if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = DarkForeground;
                foreach (Control subControl in groupBox.Controls)
                {
                    ApplyDarkThemeToControl(subControl);
                }
            }
            else
            {
                foreach (Control subControl in control.Controls)
                {
                    ApplyDarkThemeToControl(subControl);
                }
            }
        }

        private static void ApplyThemeToContextMenus(Form form, bool isLightTheme = false)
        {
            var backColor = isLightTheme ? LightBackground : DarkBackground;
            var foreColor = isLightTheme ? LightForeground : DarkForeground;

            var renderer = new CustomToolStripRenderer(backColor, foreColor);

            foreach (Control control in form.Controls)
            {
                if (control is ContextMenuStrip contextMenuStrip)
                {
                    contextMenuStrip.Renderer = renderer;
                }
                ApplyRendererToSubControls(control, renderer);
            }
        }

        private static void ApplyRendererToSubControls(Control control, ToolStripRenderer renderer)
        {
            foreach (Control subControl in control.Controls)
            {
                if (subControl is ContextMenuStrip contextMenuStrip)
                {
                    contextMenuStrip.Renderer = renderer;
                }
                ApplyRendererToSubControls(subControl, renderer);
            }
        }

        public static class MonokaiColors
        {
            public static readonly ColorSet Dark = new()
            {
                BACKGROUND = Color.FromArgb(39, 40, 34),
                FOREGROUND = Color.FromArgb(248, 248, 242),
                GREY = Color.FromArgb(100, 100, 100),
                PINK = Color.FromArgb(249, 38, 114),
                GREEN = Color.FromArgb(166, 226, 46),
                PURPLE = Color.FromArgb(174, 129, 255),
                ORANGE = Color.FromArgb(253, 151, 31),
                BLUE = Color.FromArgb(120, 220, 232),
                YELLOW = Color.FromArgb(255, 216, 102)
            };

            public static readonly ColorSet Light = new()
            {
                BACKGROUND = Color.White,
                FOREGROUND = Color.FromArgb(39, 40, 34),
                GREY = Color.FromArgb(100, 100, 100),
                PINK = Color.FromArgb(249, 38, 114),
                GREEN = Color.FromArgb(106, 175, 25),
                PURPLE = Color.FromArgb(174, 129, 255),
                ORANGE = Color.FromArgb(242, 90, 0),
                BLUE = Color.FromArgb(40, 198, 228),
                YELLOW = Color.FromArgb(100, 100, 100)
            };
        }

        public class ColorSet
        {
            public Color BACKGROUND { get; set; }
            public Color FOREGROUND { get; set; }
            public Color GREY { get; set; }
            public Color PURPLE { get; set; }
            public Color ORANGE { get; set; }
            public Color GREEN { get; set; }
            public Color YELLOW { get; set; }
            public Color PINK { get; set; }
            public Color BLUE { get; set; }
        }

    }
}
