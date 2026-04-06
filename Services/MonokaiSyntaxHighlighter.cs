using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSyntaxHighlighter;

namespace Lab_Feedback.Services
{
    internal class MonokaiSyntaxHighlighter : SyntaxHighlighter
    {
        public MonokaiSyntaxHighlighter(RichTextBox richTextBox) : base(richTextBox)
        {

        }

        public static MonokaiSyntaxHighlighter NewInstance(RichTextBox richTextBox)
        {
            return NewInstance(richTextBox, null, null);
        }

        public static MonokaiSyntaxHighlighter NewInstance(RichTextBox richTextBox, Panel? panel, Label? label)
        {
            MonokaiSyntaxHighlighter syntaxHighlighter = new(richTextBox);

            if (ThemeHelper.IsLightTheme())
            {
                SetLightThemeColors(richTextBox, panel, label);
                return InitializeSyntaxHighlighter(syntaxHighlighter, true);
            }
            else
            {
                SetDarkThemeColors(richTextBox, panel, label);
                return InitializeSyntaxHighlighter(syntaxHighlighter, false);
            }
        }

        private static void SetLightThemeColors(RichTextBox richTextBox, Panel? panel, Label? label)
        {
            richTextBox.BackColor = Color.White;
            if (panel != null) panel.BackColor = Color.White;
            if (label != null) label.BackColor = Color.White;
        }

        private static void SetDarkThemeColors(RichTextBox richTextBox, Panel? panel, Label? label)
        {
            richTextBox.BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
            if (panel != null)
            {
                panel.BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
                var buttonNewWindow = panel.Controls.Find("buttonOpenWindow", false);
                if (buttonNewWindow.Length > 0) buttonNewWindow[0].BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
            }
            if (label != null) label.BackColor = ThemeHelper.MonokaiColors.Dark.BACKGROUND;
        }

        private static MonokaiSyntaxHighlighter InitializeSyntaxHighlighter(MonokaiSyntaxHighlighter syntaxHighlighter, bool isLightTheme)
        {
            var colors = isLightTheme ? ThemeHelper.MonokaiColors.Light : ThemeHelper.MonokaiColors.Dark;

            AddSyntaxPatterns(syntaxHighlighter, colors);

            return syntaxHighlighter;
        }

        private static void AddSyntaxPatterns(MonokaiSyntaxHighlighter syntaxHighlighter, ThemeHelper.ColorSet colors)
        {
            // single-line comments
            syntaxHighlighter.AddPattern(
                new PatternDefinition(new Regex(@"//.*?$", RegexOptions.Multiline | RegexOptions.Compiled)),
                new SyntaxStyle(colors.GREY, bold: false, italic: true));

            // multiple-line comments
            syntaxHighlighter.AddPattern(
                new PatternDefinition(new Regex(@"/\*[^*]*\*+(?:[^/*][^*]*\*+)*/", RegexOptions.Singleline)),
                new SyntaxStyle(colors.GREY, bold: false, italic: true));

            // returns; purple
            syntaxHighlighter.AddPattern(
                new PatternDefinition("return"),
                new SyntaxStyle(colors.PURPLE));

            // Methods lime
            syntaxHighlighter.AddPattern(
                new PatternDefinition(new Regex(@"\b(?!for\b|while\b|if\b|switch\b)\w+\b(?=\s*\()", RegexOptions.Compiled)),
                new SyntaxStyle(colors.GREEN));

            // numbers; purple
            syntaxHighlighter.AddPattern(
                new PatternDefinition(@"\d+\.\d+|\d+"),
                new SyntaxStyle(colors.PURPLE));
            syntaxHighlighter.AddPattern(
                new PatternDefinition(new Regex(@"^(?:\d*\.?\d+f?|\d+\.\d*|\.\d+)$", RegexOptions.Compiled)),
                new SyntaxStyle(colors.PURPLE));

            // double quote strings; yellow
            syntaxHighlighter.AddPattern(
                new PatternDefinition(@"\""([^""]|\""\"")+\"""),
                new SyntaxStyle(colors.YELLOW));

            // single quote strings; salmon
            syntaxHighlighter.AddPattern(
                new PatternDefinition(@"\'([^']|\'\')+\'"),
                new SyntaxStyle(Color.Salmon));

            // 1st set of keywords; blue
            syntaxHighlighter.AddPattern(
                new PatternDefinition("for", "each", "if", "else", "switch", "case", "ifdef", "endif", "do", "while", "include", "define"),
                new SyntaxStyle(colors.PINK));

            // set of types; blue
            syntaxHighlighter.AddPattern(
                new PatternDefinition("bool", "int", "float", "double", "long", "string", "vector", "class", "enum", "void", "char"),
                new SyntaxStyle(colors.BLUE, false, true));
            syntaxHighlighter.AddPattern(
                new PatternDefinition("std"),
                new SyntaxStyle(colors.BLUE));

            // 2nd set of keywords; bold navy, case insensitive
            syntaxHighlighter.AddPattern(
                new CaseInsensitivePatternDefinition("public", "partial", "using", "namespace", "signed", "static", "unsigned"),
                new SyntaxStyle(colors.PINK, false, true));

            // Classes
            syntaxHighlighter.AddPattern(
                new PatternDefinition(new Regex(@"^(.*?)(?=::)", RegexOptions.Compiled)),
                new SyntaxStyle(colors.BLUE));

            // Operators
            syntaxHighlighter.AddPattern(
                new PatternDefinition("+", "-", ">", "<", "|", "=", "%", "::", "/", "*", ",", "!", "&&"),
                new SyntaxStyle(colors.PINK));

            // Structure operators
            syntaxHighlighter.AddPattern(
                new PatternDefinition("#", ";", ":"),
                new SyntaxStyle(colors.GREY));

            // Flags
            syntaxHighlighter.AddPattern(
                new PatternDefinition(
                    "&", "const", "static_cast", "reinterpret_cast", "dynamic_cast",
                    "resize()", "ignore()", "clear()", "auto", "try", "size_t", "goto", 
                    "catch", "\0", "(...)", "var", "continue", "iterator"),
                new SyntaxStyle(Color.Red, true, false));
        }
    }
}
