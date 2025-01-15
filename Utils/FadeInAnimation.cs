using System.Windows.Forms;

namespace R6Schulprojekt.Utils
{
    public static class FadeInAnimation
    {
        public static void Start(Form form)
        {
            form.Opacity = 0;
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 20;
            fadeInTimer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                    form.Opacity += 0.05;
                else
                    fadeInTimer.Stop();
            };
            fadeInTimer.Start();
        }
    }
}
