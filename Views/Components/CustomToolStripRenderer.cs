using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Feedback.Views.Components
{
    internal class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color _menuItemBackColor;
        private readonly Color _menuItemForeColor;

        public CustomToolStripRenderer(Color menuItemBackColor, Color menuItemForeColor)
        {
            _menuItemBackColor = menuItemBackColor;
            _menuItemForeColor = menuItemForeColor;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(_menuItemForeColor), e.Item.Bounds);
                e.Item.ForeColor = _menuItemBackColor;
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(_menuItemBackColor), e.Item.Bounds);
                e.Item.ForeColor = _menuItemForeColor;
            }
        }
    }
}
