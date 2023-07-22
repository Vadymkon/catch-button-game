using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Убегайка
{
    public partial class Убегайка : Form
    {
        int speed = 10, smth = 1;


       // System.Drawing.Color[] arr = { "red","white" ,"blue", "yellow", "control"};
        public Убегайка()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\background.mp3";
            wplayer.controls.play();
        }

        public void winning()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\win.mp3";
            wplayer.controls.play();
        }
        void button1_Click(object sender, EventArgs e)
        {
            winning();
            button1.Enabled = false;
            BackColor = Color.Gray;
            button1.Text = "Поздравляем! Вы победили!";
            label1.Text = "Вау! Вы молодец, это было непросто!\nЧтобы попробовать снова, поймайте этот текст.";
            label1.Left = Left / 2; label1.Top = Top / 2;
            Thread.Sleep(1000);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            label2.Text = "ПЕРЕЗАГРУЗКА\n(также скорость уменьшает)";

        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (button1.Left < 12) button1.Left = Width - 200; if (button1.Left > Width - 200) button1.Left = 12;
            if (button1.Top < 12) button1.Top = Height - 200; if (button1.Top > Height - 200) button1.Top = 12;
        }

        public void checkboxsound()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\labelchange.mp3";
            wplayer.controls.play();
        }
        public void song()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\background.mp3";
            wplayer.controls.play();
        }
        void label1_Click(object sender, EventArgs e)
        {
            button1.Left = Width / 2; button1.Top = Height / 2;
            button1.Width -= 3; button1.Height -= 3;
            button1.Enabled = true;
            button1.Text = "TAKEME";
            label1.Left = Left / 2; label1.Top = Top / 2;
            label1.Text = "Нажав на текст вы сделаете режим сложнее.\nНо его то поймать ещё нужно))0)";
           
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\labelchange.mp3";
            wplayer.controls.play();
            
            checkBox1.Text = "Кнопка уменьшена на 3 пикселя";
            checkBox1.Visible = true;
        }

        void label1_MouseMove(object sender, MouseEventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\label.mp3";
            wplayer.controls.play();
            var Arraylist = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Azure, Color.Aqua, Color.Chocolate };
            List<Color[]> color = new List<Color[]>();

            Random rand = new Random();
            smth++;
            if (smth % 20 == 0) speed++; //увеличиваем скорость
            BackColor = Arraylist[rand.Next(7)]; //меняем на случайный цвет
            label1.BackColor = Arraylist[rand.Next(7)]; //меняем на случайный цвет
            //меняем положение
            if (rand.Next(2) == 1) label1.Top += rand.Next(2, speed);
            else label1.Top += rand.Next(-speed, -2);
            if (rand.Next(2) == 1) label1.Left += rand.Next(2, speed);
            else label1.Left += rand.Next(-speed, -2);
            if (label1.Left < 12) label1.Left = Width - 200; if (label1.Left > Width - 200) label1.Left = 12;
            if (label1.Top < 12) label1.Top = Height - 200; if (label1.Top > Height - 200) label1.Top = 12;
        }

        void Убегайка_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            if (rand.Next(10) == 4)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = @"mp3\missed.mp3";
                wplayer.controls.play();
            }
            if (button1.Left < 12) button1.Left = Width - 200; if (button1.Left > Width - 200) button1.Left = 12;
            if (button1.Top < 12) button1.Top = Height - 200; if (button1.Top > Height - 200) button1.Top = 12;
            if (label1.Left < 12) label1.Left = Width - 200; if (label1.Left > Width - 200) label1.Left = 12;
            if (label1.Top < 12) label1.Top = Height - 200; if (label1.Top > Height - 200) label1.Top = 12;
        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {
            checkBox1.Visible = false;
        }

        private void Убегайка_Load(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\Start.mp3";
            wplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speed = 10;
            button1.Left = Width / 2; button1.Top = Height / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            song();
        }

        void button1_MouseMove(object sender, MouseEventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"mp3\button.mp3";
            wplayer.controls.play();

            var Arraylist = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Azure, Color.Aqua, Color.Chocolate };
        List<Color[]> color = new List<Color[]>();

        Random rand = new Random();
            smth++; 
            if (smth % 20 == 0) speed++; //увеличиваем скорость
            BackColor = Arraylist[rand.Next(7)]; //меняем на случайный цвет
            button1.BackColor = Arraylist[rand.Next(7)]; //меняем на случайный цвет
            //меняем положение
            if (rand.Next(2) == 1) button1.Top += rand.Next(2,speed); 
                else button1.Top += rand.Next(-speed, -2);
            if (rand.Next(2) == 1) button1.Left += rand.Next(2, speed);
                else button1.Left += rand.Next(-speed, -2);
            if (button1.Left < 12) button1.Left = Width - 200; if (button1.Left > Width-200) button1.Left = 12;
            if (button1.Top < 12) button1.Top = Height-200; if (button1.Top > Height-200) button1.Top = 12;
            //Thread.Sleep(1);
        }
    }
}
