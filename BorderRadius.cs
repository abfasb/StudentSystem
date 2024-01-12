using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Information_System
{
    internal static class BorderRadius
    {
        public static void ApplyBorderRadius(System.Windows.Forms.Button button, int borderRadius)
        {
            button.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int width = button.Width;
                int height = button.Height;
                int radius = borderRadius * 2;

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(width - radius, 0, radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
                path.AddArc(0, height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                button.Region = new Region(path);
            };
        }

        public static void ApplyBorderRadiusPanel(Panel panel, int borderRadius)
        {
            panel.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int width = panel.Width;
                int height = panel.Height;
                int radius = borderRadius * 2;

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(width - radius, 0, radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
                path.AddArc(0, height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            };
        }
        public static void ApplyBorderRadiusPictureBox(PictureBox pictureBox, int borderRadius)
        {
            pictureBox.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int width = pictureBox.Width;
                int height = pictureBox.Height;
                int radius = borderRadius * 2;

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(width - radius, 0, radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90); 
                path.AddArc(0, height - radius, radius, radius, 90, 90); 
                path.CloseFigure();

                pictureBox.Region = new Region(path);
            };
        }
    }
}
