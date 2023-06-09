﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class fwldom : Form
    {
        public int AmtPlayer = 0;
        public int Amtcomputer = 0;

        public fwldom()
        {
            InitializeComponent();
        }
        private void lblwinstate_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region sang-click
        private void sang_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            picboxplayer.BackColor = Color.LightBlue;
            picboxcomputer.BackColor = Color.LightBlue;
            panelplayer.BackColor = Color.LightGray;
            panelcomputer.BackColor = Color.LightGray;
            int computerchoise;
            picboxplayer.Image = picboxsang.Image;
            int randnum = rand.Next(100, 4000);
            computerchoise = (randnum % 3) + 1;

            switch (computerchoise)
            {
                case 1:

                    picboxcomputer.Image = picboxsang.Image;
                    lblwinstate.Text = "بازی مساوی شد";
                    listBox1.Items.Add("مساوی");

                    break;
                case 2:

                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = " کامپیوتر برنده شد";
                    listBox1.Items.Add("کامپیوتر برنده شد : کاغذ به دور سنگ می پیچد");
                    picboxplayer.BackColor = Color.Red;
                    picboxcomputer.BackColor = Color.Green;
                    Amtcomputer++;

                    break;
                case 3:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = " بازیکن برنده شد";
                    listBox1.Items.Add("بازیکن برنده شد : سنگ قیچی را له می کند ");
                    picboxplayer.BackColor = Color.Green;
                    picboxcomputer.BackColor = Color.Red;
                    AmtPlayer++;
                    break;

            }
        }
        #endregion sang-click
        #region Ghaeychiey
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            picboxplayer.BackColor = Color.LightBlue;
            picboxcomputer.BackColor = Color.LightBlue;
            panelplayer.BackColor = Color.LightGray;
            panelcomputer.BackColor = Color.LightGray;
            int computerchoise;
            picboxplayer.Image = picboxsang.Image;
            int randnum = rand.Next(100, 4000);
            computerchoise = (randnum % 3) + 1;
            switch (computerchoise)
            {
                case 1:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = "کامپیوتر برنده شد";
                    listBox1.Items.Add("کامپیوتر برنده شد : سنگ قیچی را له میکند ");
                    picboxplayer.BackColor = Color.Red;
                    picboxcomputer.BackColor = Color.Green;
                    Amtcomputer++;
                    break;
                case 2:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = " بازیکن برنده شد";
                    listBox1.Items.Add("بازیکن برنده شد : قیچی کاغذ را قطعه قطعه می کند");
                    picboxplayer.BackColor = Color.Green;
                    picboxcomputer.BackColor = Color.Red;
                    AmtPlayer++;
                    break;
                case 3:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = "بازی مساوی شد";
                    listBox1.Items.Add("مساوی");

                    break;

            }
        }
        #endregion
        #region kaghaz-click
        private void picboxkaghaz_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            picboxplayer.BackColor = Color.LightBlue;
            picboxcomputer.BackColor = Color.LightBlue;
            panelplayer.BackColor = Color.LightGray;
            panelcomputer.BackColor = Color.LightGray;
            int computerchoise;
            picboxplayer.Image = picboxsang.Image;
            int randnum = rand.Next(100, 4000);
            computerchoise = (randnum % 3) + 1;
            switch (computerchoise)
            {
                case 1:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = " بازیکن برنده شد";
                    listBox1.Items.Add("بازیکن برنده شد : کاغذ به دور سنگ می پیچد");
                    picboxplayer.BackColor = Color.Green;
                    picboxcomputer.BackColor = Color.Red;
                    AmtPlayer++;
                    break;
                case 2:

                    picboxcomputer.Image = picboxsang.Image;
                    lblwinstate.Text = "بازی مساوی شد";
                    listBox1.Items.Add("مساوی");
                    break;
                case 3:
                    picboxcomputer.Image = picboxkaghaz.Image;
                    lblwinstate.Text = " کامپیوتر برنده شد";
                    listBox1.Items.Add("کامپیوتر برنده شد : قیچی کاغذ را قطعه قطعه می کند");
                    picboxplayer.BackColor = Color.Red;
                    picboxcomputer.BackColor = Color.Green;
                    Amtcomputer++;
                    break;

            }
        }
        #endregion
        #region Reset Game
        private void Reset()
        {
            picboxcomputer.BackColor = Color.LightGray;
            picboxplayer.BackColor = Color.LightGray;
            lblwinstate.Text = null;
            panelplayer.BackColor = Color.LightGray;
            panelcomputer.BackColor = Color.LightGray;
            listBox1.Items.Clear();
        }
        #endregion
        #region End game
        private void Endgame()
        {
            if (AmtPlayer == Amtcomputer)
            {
                Endtext.Text = "بازی  مساوی شد ";

            }
            if (Amtcomputer > AmtPlayer)
            {
                Endtext.Text = "کامپیوتر بازی را برد ";
            }
            if (AmtPlayer > Amtcomputer)
            {
                Endtext.Text = "بازیکن بازی را برد";
            }
        }
#endregion
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void بازیجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endgame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
//made in fwldom
//for freedom
//death to dictator
//fwldom