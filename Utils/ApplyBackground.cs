using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Schulprojekt.Utils
{
    public class ApplyBackground
    {
        public static void ApplyGradient(Form form, PaintEventArgs e)
        {
            //using (LinearGradientBrush brush = new LinearGradientBrush(form.ClientRectangle, Color.DarkSlateGray, Color.Black, LinearGradientMode.Vertical))
            //{
            //    e.Graphics.FillRectangle(brush, form.ClientRectangle);
            //}

            using (LinearGradientBrush brush = new LinearGradientBrush(form.ClientRectangle, Color.Navy, Color.DarkSlateGray, 45f))
            {
                e.Graphics.FillRectangle(brush, form.ClientRectangle);
            }
        }
    }
}
