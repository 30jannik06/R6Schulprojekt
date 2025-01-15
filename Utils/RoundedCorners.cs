using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace R6Schulprojekt.Utils
{
    public static class RoundedCorners
    {
        public static void SetRoundedCorners(Form form, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);
            path.AddArc(new Rectangle(form.Width - diameter, 0, diameter, diameter), 270, 90);
            path.AddArc(new Rectangle(form.Width - diameter, form.Height - diameter, diameter, diameter), 0, 90);
            path.AddArc(new Rectangle(0, form.Height - diameter, diameter, diameter), 90, 90);
            path.CloseFigure();

            form.Region = new Region(path);
        }
    }
}
