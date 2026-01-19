using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Main : Form
    {
        private static readonly HttpClient client = new HttpClient();

        bool isLooping = false;
        bool isMuted = false;
        bool isBindsActive = true;
        bool isRemoteActive = false;

        string currentSongName;

        readonly int NEXT = 1;
        readonly int BACK = 0;

        readonly int CMD = 0;
        readonly int SONG = 1;

        private static globalKeyboardHook gkh;

        NowPlaying np = new NowPlaying();

        DiscoMode discoMode = new DiscoMode();

        SadMode sadMode = new SadMode();

        List<string> songPaths = new List<string>();

        string playlistPath = $"{Environment.CurrentDirectory}\\";

        public Main()
        {
            InitializeComponent();

            InitListbox();

            player.enableContextMenu = false;
            player.settings.mute = false;
            player.settings.volume = 100;
            np.nowPlayingVolume = $"{player.settings.volume}%";
            player.uiMode = "none";
            
            this.Text = $"Music Player By UniquezHD Found: {listBox1.Items.Count} Songs";
            label4.Text = $"Music Player By UniquezHD Found: {listBox1.Items.Count} Songs";

            gkh = new globalKeyboardHook();
            GC.KeepAlive(gkh);

            // til at hook keys
            gkh.HookedKeys.Add(Keys.Right);
            gkh.HookedKeys.Add(Keys.Left);
            gkh.HookedKeys.Add(Keys.Up);
            gkh.HookedKeys.Add(Keys.Down);
            gkh.HookedKeys.Add(Keys.Delete);
            gkh.HookedKeys.Add(Keys.Insert);
            gkh.HookedKeys.Add(Keys.End);
            gkh.HookedKeys.Add(Keys.RShiftKey);

            gkh.HookedKeys.Add(Keys.RControlKey);

            // event handler til hooked keys
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            RePaint();

            this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void InitListbox()
        {
            if (Properties.Settings.Default.playlistPath == null)
            {
                
            }
            else
            {
                playlistPath = Properties.Settings.Default.playlistPath;
            }

            try
            {
                foreach (var playlist in Directory.GetDirectories(playlistPath))
                {
                    customComboBox1.Items.Add(playlist.TrimEnd('\\').Split('\\').Last());
                }

                foreach (var song in Directory.GetFiles($"{playlistPath}/{customComboBox1.Texts}"))
                {
                    songPaths.Add(song);
                }

                foreach (var song in songPaths)
                {              
                    string item = song.TrimEnd('\\').Split('\\').Last();
                    listBox1.Items.Add(item.Remove(item.Length - 4));
                }
            }
            catch { }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (isBindsActive)
            {
                switch (e.KeyCode.ToString())
                {
                    case "RShiftKey":
                        player.Ctlcontrols.play();
                        break;
                
                    case "Delete":
                        player.Ctlcontrols.currentPosition -= 10;
                        break;
                
                    case "Insert":
                        player.Ctlcontrols.currentPosition += 10;
                        break;
                
                    case "End":
                        player.Ctlcontrols.stop();
                        break;
                
                    case "RControlKey":
                        roundedToggleButton3_CheckedChanged(sender, e);
                        break;
                
                    case "Left":
                        ChangeSong(BACK);
                        break;
                
                    case "Right":
                        ChangeSong(NEXT);
                        break;
                
                    case "Up":
                        if (trackBarCustom2.Value + 5 < 100)
                        {
                            trackBarCustom2.Value += 5;
                            player.settings.volume = trackBarCustom2.Value;
                            np.nowPlayingVolume = $"{player.settings.volume}%";
                        }
                        else
                        {
                            trackBarCustom2.Value = 100;
                            player.settings.volume = trackBarCustom2.Value;
                            np.nowPlayingVolume = $"{player.settings.volume}%";
                        }
                        break;
                
                    case "Down":
                        if (trackBarCustom2.Value - 5 > 0)
                        {
                            trackBarCustom2.Value -= 5;
                            player.settings.volume = trackBarCustom2.Value;
                            np.nowPlayingVolume = $"{player.settings.volume}%";
                        }
                        else
                        {
                            trackBarCustom2.Value = 1;
                            player.settings.volume = trackBarCustom2.Value;
                            np.nowPlayingVolume = $"{player.settings.volume}%";
                        }
                        break;
                
                }
            }          
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                customComboBox1.SelectedIndex = 0;
                listBox1.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Playlist folder missing");
            }
        }

        private void PlayMusic()
        {
            timer1.Stop();

            player.URL = songPaths[listBox1.SelectedIndex];

            currentSongName = listBox1.Items[listBox1.SelectedIndex].ToString();

            player.Ctlcontrols.play();

            DecideMood(currentSongName);

            if (isRemoteActive)
            {
                _ = InvokeApiAsync($"{currentSongName}#{player.Ctlcontrols.currentPositionString}/{player.currentMedia.durationString}", SONG);
            }

            if (isMuted)
            {
                player.settings.mute = true;
            }

            timer1.Start();
        }
      
        private void DecideMood(string song)
        {
            if(Properties.Settings.Default.moodMode == true)
            {
                HttpClient client = new HttpClient();
                var result = client.GetStringAsync(@"xxxxxxx").Result;

                dynamic data = JsonConvert.DeserializeObject(result);

                sadMode.Hide();
                discoMode.Hide();

                foreach (var item in data.disco)
                {
                    
                    if (song.Contains(item.song.ToString()))
                    {
                        discoMode.Show();
                        player.settings.volume = 80;
                        return;
                    }
                }

                foreach (var item in data.sad)
                {
                    if (song.Contains(item.song.ToString()))
                    {
                        sadMode.Show();
                        return;
                    }
                }  
            }
        }

        private void StopMusic() 
        {
            player.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void ChangeSong(int x)
        {
            if(x == 0) //back
            {
                if (0 <= listBox1.SelectedIndex - 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                    PlayMusic();
                }
            }

            else if(x == 1) //next
            {
                if(listBox1.Items.Count > listBox1.SelectedIndex + 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    PlayMusic();
                }
            }
        }

        private void Shuffle()
        {
            listBox1.Items.Clear();

            songPaths.Clear();

            foreach (var song in Directory.GetFiles($"{playlistPath}/{customComboBox1.SelectedItem}").OrderBy(i => Guid.NewGuid()).ToList())
            {
                songPaths.Add(song);
                string item = song.TrimEnd('\\').Split('\\').Last();
                listBox1.Items.Add(item.Remove(item.Length - 4));
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition += 10;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition -= 10;
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            ChangeSong(BACK);
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            ChangeSong(NEXT);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMusic();
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsStopped && isLooping == true)
            {
                player.Ctlcontrols.play();
            } 
            else
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    BeginInvoke(new Action(() => {
                        ChangeSong(NEXT);
                    }));
                }
            }
            
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label1.Text = player.currentMedia.durationString;
                label2.Text = $"Now Playing: {player.currentMedia.name}";
                this.Text = $"Now Playing: {player.currentMedia.name}";
                label4.Text = $"Now Playing: {player.currentMedia.name}";
                np.nowPlaying = $"{player.currentMedia.name}";
                np.nowPlayingCurrentDuration = $"{player.Ctlcontrols.currentPositionString}";
                np.nowPlayingTotalDuration = $"{player.currentMedia.durationString}";
            }

            if (player.openState == WMPLib.WMPOpenState.wmposMediaOpen)
            {
                trackBarCustom1.Maximum = (int)player.currentMedia.duration;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = player.Ctlcontrols.currentPositionString;
            np.nowPlayingCurrentDuration = player.Ctlcontrols.currentPositionString;
            trackBarCustom1.Value = (int)player.Ctlcontrols.currentPosition;

            //Console.WriteLine(currentSongName);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Environment.Exit(0);
            }
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
                np.Show();
            }
        }

        private void trackBarCustom1_Scroll(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition = trackBarCustom1.Value;
        }

        private void trackBarCustom2_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBarCustom2.Value;
            np.nowPlayingVolume = $"{player.settings.volume}%";
        }

        private void roundedToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            isBindsActive = !isBindsActive;
        }

        private void roundedToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            isLooping = !isLooping;  
        }

        private void roundedToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            isMuted = !isMuted;

            if (isMuted)
            {
                player.settings.mute = true;
            }
            else if (!isMuted)
            {
                player.settings.mute = false;
            }
        }

        private void roundedToggleButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                isRemoteActive = !isRemoteActive;

                if (isRemoteActive)
                {
                    _ = InvokeApiAsync("none", CMD);
                    timer2.Start();
                    return;
                }

                timer2.Stop();
            }
            catch
            {
                MessageBox.Show("No internet connection");
            }

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            //foreach (string str in songPaths)
            //{
            //    if (str.ToUpper().Contains(customTextBox1.Texts.ToUpper()))
            //    {
            //        string item = str.TrimEnd('\\').Split('\\').Last();
            //        listBox1.SelectedItem = item.Remove(item.Length - 4);
            //    }
            //}
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            songPaths.Clear();

            foreach (var song in Directory.GetFiles($"{playlistPath}/{customComboBox1.SelectedItem}"))
            {
                songPaths.Add(song);
            }

            foreach (var song in songPaths)
            {
                string item = song.TrimEnd('\\').Split('\\').Last();
                listBox1.Items.Add(item.Remove(item.Length - 4));
            }

            this.Text = $"Music Player By UniquezHD Found: {listBox1.Items.Count} Songs";
            label4.Text = $"Music Player By UniquezHD Found: {listBox1.Items.Count} Songs";
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // If the item is selected them change the back color.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.MediumSlateBlue); // Choose the color.

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            // Draw the current item text
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync(@"xxxxxxxxx").Result;

            //Console.WriteLine(result);

            //Console.WriteLine("Looping: " + isLooping);

            if(listBox1.SelectedIndex != 0 && listBox1.SelectedIndex != -1)
            {
                currentSongName = listBox1.Items[listBox1.SelectedIndex].ToString();
                try
                {
                    _ = InvokeApiAsync($"{currentSongName}#{player.Ctlcontrols.currentPositionString}/{player.currentMedia.durationString}", SONG);
                }
                catch { }
            }

            if (result == "none")
            {
                return;
            }

            if (result.Contains("loop"))
            {
                if (isLooping)
                {
                    isLooping = false;
                }
                else if (isLooping == false)
                {
                    isLooping = true;
                }
                
                Console.WriteLine("Loop triggered");

                roundedToggleButton2.Checked = isLooping;

                _ = InvokeApiAsync("none", CMD);
            }

            if (result.Contains("m10sec"))
            {
                player.Ctlcontrols.currentPosition -= 10;

                _ = InvokeApiAsync("none", CMD);
            }

            if (result.Contains("p10sec"))
            {
                player.Ctlcontrols.currentPosition += 10;

                _ = InvokeApiAsync("none", CMD);
            }

            if (result.Contains("search?"))
            {
                string search = result.Split('?')[1];

                Console.WriteLine(search);

                foreach (string str in songPaths)
                {
                    if (str.ToUpper().Contains(search.Trim().ToUpper()))
                    {
                        Console.WriteLine(str);

                        string item = str.TrimEnd('\\').Split('\\').Last();

                        int index = listBox1.FindString(item.Remove(item.Length - 4));

                        listBox1.SetSelected(index, true);

                        timer1.Stop();

                        player.URL = str;

                        player.Ctlcontrols.play();

                        DecideMood(currentSongName);

                        try
                        {
                            _ = InvokeApiAsync($"{currentSongName}#{player.Ctlcontrols.currentPositionString}/{player.currentMedia.durationString}", SONG);
                        }
                        catch { }

                        timer1.Start();
                    }
                }

                _ = InvokeApiAsync("none", CMD);
            }

            if (result.Contains("volume"))
            {
                string valueString = result.Split(' ')[1];
                int value = int.Parse(valueString);
                if(value >= 1)
                {
                    player.settings.volume = value;
                    trackBarCustom2.Value = value;
                    np.nowPlayingVolume = $"{player.settings.volume}%";
                    _ = InvokeApiAsync("none", CMD);
                } 
            }
  
            if(result.Contains("next"))
            {
                ChangeSong(NEXT);

                _ = InvokeApiAsync("none", CMD);
            }

            if (result.Contains("back"))
            {
                ChangeSong(BACK);

                _ = InvokeApiAsync("none", CMD);
            }
        }

        private async Task InvokeApiAsync(string input, int mode)
        {
            var values = new Dictionary<string, string>
            {
                { "cmd", input },
                { "operation", mode.ToString() },
                { "key", "xxxxxxxxxxxxxxxxxxxxx" },
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("xxxxxxxxx", content);

            var responseString = await response.Content.ReadAsStringAsync();

            await Console.Out.WriteLineAsync(responseString);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                foreach (string str in songPaths)
                {
                    if (str.ToUpper().Contains(customTextBox1.Texts.ToUpper()))
                    {
                        string item = str.TrimEnd('\\').Split('\\').Last();
                        listBox1.SelectedItem = item.Remove(item.Length - 4);
                    }
                }

                PlayMusic();

                e.Handled = true;
            }
        }
    }
}