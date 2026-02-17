using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentora.Utilities
{
    public class LayoutHelper
    {
        public static void set_FormBackground(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Panel panel = sender as Panel;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, panel.Width, panel.Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(34, 34, 34), Color.FromArgb(255, 87, 34), LinearGradientMode.ForwardDiagonal );

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
