namespace MusicPlayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedButton7 = new MusicPlayer.RoundedButton();
            this.roundedButton4 = new MusicPlayer.RoundedButton();
            this.roundedButton5 = new MusicPlayer.RoundedButton();
            this.roundedButton6 = new MusicPlayer.RoundedButton();
            this.roundedButton3 = new MusicPlayer.RoundedButton();
            this.roundedButton2 = new MusicPlayer.RoundedButton();
            this.roundedButton1 = new MusicPlayer.RoundedButton();
            this.trackBarCustom2 = new MusicPlayer.TrackBarCustom();
            this.trackBarCustom1 = new MusicPlayer.TrackBarCustom();
            this.customTextBox1 = new MusicPlayer.CustomTextBox();
            this.customComboBox1 = new MusicPlayer.CustomComboBox();
            this.roundedToggleButton4 = new MusicPlayer.RoundedToggleButton();
            this.roundedToggleButton3 = new MusicPlayer.RoundedToggleButton();
            this.roundedToggleButton2 = new MusicPlayer.RoundedToggleButton();
            this.roundedToggleButton1 = new MusicPlayer.RoundedToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustom1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Now Playing: Nothing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Music Player By UniquezHD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(548, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "X";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(516, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "_";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Binds";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Loop";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mute";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Remote";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 341);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 197);
            this.listBox1.TabIndex = 61;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(11, 37);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(558, 163);
            this.player.TabIndex = 10;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(487, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 26);
            this.label11.TabIndex = 77;
            this.label11.Text = "...";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton7.BorderColor = System.Drawing.Color.Black;
            this.roundedButton7.BorderRadius = 5;
            this.roundedButton7.BorderSize = 0;
            this.roundedButton7.FlatAppearance.BorderSize = 0;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.ForeColor = System.Drawing.Color.White;
            this.roundedButton7.Location = new System.Drawing.Point(15, 278);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Size = new System.Drawing.Size(75, 23);
            this.roundedButton7.TabIndex = 76;
            this.roundedButton7.Text = "Back";
            this.roundedButton7.UseVisualStyleBackColor = false;
            this.roundedButton7.Click += new System.EventHandler(this.roundedButton7_Click);
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton4.BorderColor = System.Drawing.Color.Black;
            this.roundedButton4.BorderRadius = 5;
            this.roundedButton4.BorderSize = 0;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(256, 248);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(75, 23);
            this.roundedButton4.TabIndex = 75;
            this.roundedButton4.Text = "+ 10 Sec";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton5.BorderColor = System.Drawing.Color.Black;
            this.roundedButton5.BorderRadius = 5;
            this.roundedButton5.BorderSize = 0;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.ForeColor = System.Drawing.Color.White;
            this.roundedButton5.Location = new System.Drawing.Point(176, 277);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Size = new System.Drawing.Size(75, 23);
            this.roundedButton5.TabIndex = 74;
            this.roundedButton5.Text = "Shuffle";
            this.roundedButton5.UseVisualStyleBackColor = false;
            this.roundedButton5.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton6.BorderColor = System.Drawing.Color.Black;
            this.roundedButton6.BorderRadius = 5;
            this.roundedButton6.BorderSize = 0;
            this.roundedButton6.FlatAppearance.BorderSize = 0;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.ForeColor = System.Drawing.Color.White;
            this.roundedButton6.Location = new System.Drawing.Point(96, 278);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Size = new System.Drawing.Size(75, 23);
            this.roundedButton6.TabIndex = 73;
            this.roundedButton6.Text = "Next";
            this.roundedButton6.UseVisualStyleBackColor = false;
            this.roundedButton6.Click += new System.EventHandler(this.roundedButton6_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton3.BorderColor = System.Drawing.Color.Black;
            this.roundedButton3.BorderRadius = 5;
            this.roundedButton3.BorderSize = 0;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(176, 248);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(75, 23);
            this.roundedButton3.TabIndex = 72;
            this.roundedButton3.Text = "- 10 Sec";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.BorderColor = System.Drawing.Color.Black;
            this.roundedButton2.BorderRadius = 5;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(96, 249);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(75, 23);
            this.roundedButton2.TabIndex = 71;
            this.roundedButton2.Text = "Stop";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.BorderRadius = 5;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(15, 248);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(75, 23);
            this.roundedButton1.TabIndex = 70;
            this.roundedButton1.Text = "Play";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // trackBarCustom2
            // 
            this.trackBarCustom2.AutoSize = false;
            this.trackBarCustom2.KnobColor = System.Drawing.Color.MediumSlateBlue;
            this.trackBarCustom2.Location = new System.Drawing.Point(333, 248);
            this.trackBarCustom2.Maximum = 100;
            this.trackBarCustom2.Name = "trackBarCustom2";
            this.trackBarCustom2.Size = new System.Drawing.Size(233, 22);
            this.trackBarCustom2.TabIndex = 69;
            this.trackBarCustom2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCustom2.Scroll += new System.EventHandler(this.trackBarCustom2_Scroll);
            // 
            // trackBarCustom1
            // 
            this.trackBarCustom1.AutoSize = false;
            this.trackBarCustom1.KnobColor = System.Drawing.Color.MediumSlateBlue;
            this.trackBarCustom1.Location = new System.Drawing.Point(50, 202);
            this.trackBarCustom1.Name = "trackBarCustom1";
            this.trackBarCustom1.Size = new System.Drawing.Size(479, 22);
            this.trackBarCustom1.TabIndex = 68;
            this.trackBarCustom1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCustom1.Scroll += new System.EventHandler(this.trackBarCustom1_Scroll);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderRadius = 5;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.White;
            this.customTextBox1.Location = new System.Drawing.Point(14, 307);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "Search";
            this.customTextBox1.Size = new System.Drawing.Size(311, 28);
            this.customTextBox1.TabIndex = 67;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            this.customTextBox1._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            this.customTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBox1_KeyPress);
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.customComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.BorderRadius = 5;
            this.customComboBox1.BorderSize = 2;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBox1.ForeColor = System.Drawing.Color.White;
            this.customComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.White;
            this.customComboBox1.Location = new System.Drawing.Point(333, 309);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 26);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBox1.Size = new System.Drawing.Size(239, 26);
            this.customComboBox1.TabIndex = 66;
            this.customComboBox1.Texts = "";
            this.customComboBox1.OnSelectedIndexChanged += new System.EventHandler(this.customComboBox1_OnSelectedIndexChanged);
            // 
            // roundedToggleButton4
            // 
            this.roundedToggleButton4.AutoSize = false;
            this.roundedToggleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedToggleButton4.Fill = true;
            this.roundedToggleButton4.Location = new System.Drawing.Point(528, 279);
            this.roundedToggleButton4.MinimumSize = new System.Drawing.Size(10, 5);
            this.roundedToggleButton4.Name = "roundedToggleButton4";
            this.roundedToggleButton4.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton4.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton4.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton4.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton4.Size = new System.Drawing.Size(41, 21);
            this.roundedToggleButton4.TabIndex = 65;
            this.roundedToggleButton4.Text = "roundedToggleButton4";
            this.roundedToggleButton4.UseVisualStyleBackColor = true;
            this.roundedToggleButton4.CheckedChanged += new System.EventHandler(this.roundedToggleButton4_CheckedChanged);
            // 
            // roundedToggleButton3
            // 
            this.roundedToggleButton3.AutoSize = false;
            this.roundedToggleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedToggleButton3.Fill = true;
            this.roundedToggleButton3.Location = new System.Drawing.Point(437, 279);
            this.roundedToggleButton3.MinimumSize = new System.Drawing.Size(10, 5);
            this.roundedToggleButton3.Name = "roundedToggleButton3";
            this.roundedToggleButton3.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton3.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton3.Size = new System.Drawing.Size(41, 21);
            this.roundedToggleButton3.TabIndex = 64;
            this.roundedToggleButton3.Text = "roundedToggleButton3";
            this.roundedToggleButton3.UseVisualStyleBackColor = true;
            this.roundedToggleButton3.CheckedChanged += new System.EventHandler(this.roundedToggleButton3_CheckedChanged);
            // 
            // roundedToggleButton2
            // 
            this.roundedToggleButton2.AutoSize = false;
            this.roundedToggleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedToggleButton2.Fill = true;
            this.roundedToggleButton2.Location = new System.Drawing.Point(362, 279);
            this.roundedToggleButton2.MinimumSize = new System.Drawing.Size(10, 5);
            this.roundedToggleButton2.Name = "roundedToggleButton2";
            this.roundedToggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton2.Size = new System.Drawing.Size(41, 21);
            this.roundedToggleButton2.TabIndex = 63;
            this.roundedToggleButton2.Text = "roundedToggleButton2";
            this.roundedToggleButton2.UseVisualStyleBackColor = true;
            this.roundedToggleButton2.CheckedChanged += new System.EventHandler(this.roundedToggleButton2_CheckedChanged);
            // 
            // roundedToggleButton1
            // 
            this.roundedToggleButton1.AutoSize = false;
            this.roundedToggleButton1.Checked = true;
            this.roundedToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.roundedToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedToggleButton1.Fill = true;
            this.roundedToggleButton1.Location = new System.Drawing.Point(289, 280);
            this.roundedToggleButton1.MinimumSize = new System.Drawing.Size(10, 5);
            this.roundedToggleButton1.Name = "roundedToggleButton1";
            this.roundedToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton1.Size = new System.Drawing.Size(41, 21);
            this.roundedToggleButton1.TabIndex = 62;
            this.roundedToggleButton1.Text = "roundedToggleButton1";
            this.roundedToggleButton1.UseVisualStyleBackColor = true;
            this.roundedToggleButton1.CheckedChanged += new System.EventHandler(this.roundedToggleButton1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(581, 550);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.roundedButton7);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.roundedButton5);
            this.Controls.Add(this.roundedButton6);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.trackBarCustom2);
            this.Controls.Add(this.trackBarCustom1);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.roundedToggleButton4);
            this.Controls.Add(this.roundedToggleButton3);
            this.Controls.Add(this.roundedToggleButton2);
            this.Controls.Add(this.roundedToggleButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer2;
        private RoundedToggleButton roundedToggleButton1;
        private RoundedToggleButton roundedToggleButton2;
        private RoundedToggleButton roundedToggleButton3;
        private RoundedToggleButton roundedToggleButton4;
        private CustomComboBox customComboBox1;
        private CustomTextBox customTextBox1;
        private TrackBarCustom trackBarCustom1;
        private TrackBarCustom trackBarCustom2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton4;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton7;
        private System.Windows.Forms.Label label11;
    }
}

