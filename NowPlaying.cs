using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class NowPlaying : Form
    {

        public string nowPlaying  { get; set; }
        public string nowPlayingVolume { get; set; }
        public string nowPlayingTotalDuration { get; set; }
        public string nowPlayingCurrentDuration { get; set; }
        public NowPlaying()
        {
            InitializeComponent();

            timer1.Start();

            RePaint();
        }

        protected void RePaint()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 25, 25, 180, 90);
            graphicpath.AddLine(25, 0, this.Width - 25, 0);
            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);
            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void NowPlaying_Load(object sender, EventArgs e)
        {
            label4.Text = nowPlaying;
            label2.Text = nowPlayingVolume;
            label6.Text = $"{nowPlayingCurrentDuration}/{nowPlayingTotalDuration}";

            this.Location = new Point(5, 5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = nowPlaying;
            label2.Text = nowPlayingVolume;
            label6.Text = $"{nowPlayingCurrentDuration}/{nowPlayingTotalDuration}";
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
