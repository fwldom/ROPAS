namespace WindowsFormsApplication1
{
    partial class fwldom
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
            this.picboxkaghaz = new System.Windows.Forms.PictureBox();
            this.picboxGhaeychiey = new System.Windows.Forms.PictureBox();
            this.picboxsang = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblwinstate = new System.Windows.Forms.Label();
            this.panelplayer = new System.Windows.Forms.Panel();
            this.picboxplayer = new System.Windows.Forms.PictureBox();
            this.panelcomputer = new System.Windows.Forms.Panel();
            this.picboxcomputer = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.بازیجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndGame = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Label();
            this.Endtext = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxkaghaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGhaeychiey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxplayer)).BeginInit();
            this.panelcomputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcomputer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxkaghaz
            // 
            this.picboxkaghaz.Image = global::WindowsFormsApplication1.Properties.Resources.Paper;
            this.picboxkaghaz.Location = new System.Drawing.Point(118, 140);
            this.picboxkaghaz.Name = "picboxkaghaz";
            this.picboxkaghaz.Size = new System.Drawing.Size(102, 96);
            this.picboxkaghaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxkaghaz.TabIndex = 1;
            this.picboxkaghaz.TabStop = false;
            this.picboxkaghaz.Click += new System.EventHandler(this.picboxkaghaz_Click);
            // 
            // picboxGhaeychiey
            // 
            this.picboxGhaeychiey.Image = global::WindowsFormsApplication1.Properties.Resources.Scissor;
            this.picboxGhaeychiey.Location = new System.Drawing.Point(118, 242);
            this.picboxGhaeychiey.Name = "picboxGhaeychiey";
            this.picboxGhaeychiey.Size = new System.Drawing.Size(102, 94);
            this.picboxGhaeychiey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxGhaeychiey.TabIndex = 2;
            this.picboxGhaeychiey.TabStop = false;
            this.picboxGhaeychiey.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picboxsang
            // 
            this.picboxsang.BackColor = System.Drawing.Color.LavenderBlush;
            this.picboxsang.Image = global::WindowsFormsApplication1.Properties.Resources.Rock;
            this.picboxsang.Location = new System.Drawing.Point(118, 42);
            this.picboxsang.Name = "picboxsang";
            this.picboxsang.Size = new System.Drawing.Size(102, 92);
            this.picboxsang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxsang.TabIndex = 3;
            this.picboxsang.TabStop = false;
            this.picboxsang.Click += new System.EventHandler(this.sang_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources._123;
            this.pictureBox3.Location = new System.Drawing.Point(862, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblwinstate
            // 
            this.lblwinstate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblwinstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblwinstate.ForeColor = System.Drawing.Color.Black;
            this.lblwinstate.Location = new System.Drawing.Point(98, 360);
            this.lblwinstate.Name = "lblwinstate";
            this.lblwinstate.Size = new System.Drawing.Size(463, 37);
            this.lblwinstate.TabIndex = 5;
            this.lblwinstate.Click += new System.EventHandler(this.lblwinstate_Click);
            // 
            // panelplayer
            // 
            this.panelplayer.BackColor = System.Drawing.Color.Transparent;
            this.panelplayer.Controls.Add(this.picboxplayer);
            this.panelplayer.Location = new System.Drawing.Point(464, 62);
            this.panelplayer.Name = "panelplayer";
            this.panelplayer.Size = new System.Drawing.Size(78, 81);
            this.panelplayer.TabIndex = 6;
            // 
            // picboxplayer
            // 
            this.picboxplayer.Location = new System.Drawing.Point(3, 3);
            this.picboxplayer.Name = "picboxplayer";
            this.picboxplayer.Size = new System.Drawing.Size(72, 75);
            this.picboxplayer.TabIndex = 0;
            this.picboxplayer.TabStop = false;
            // 
            // panelcomputer
            // 
            this.panelcomputer.BackColor = System.Drawing.Color.Transparent;
            this.panelcomputer.Controls.Add(this.picboxcomputer);
            this.panelcomputer.Location = new System.Drawing.Point(467, 228);
            this.panelcomputer.Name = "panelcomputer";
            this.panelcomputer.Size = new System.Drawing.Size(78, 81);
            this.panelcomputer.TabIndex = 7;
            // 
            // picboxcomputer
            // 
            this.picboxcomputer.Location = new System.Drawing.Point(3, 3);
            this.picboxcomputer.Name = "picboxcomputer";
            this.picboxcomputer.Size = new System.Drawing.Size(72, 75);
            this.picboxcomputer.TabIndex = 1;
            this.picboxcomputer.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(632, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 298);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازیجدیدToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // بازیجدیدToolStripMenuItem
            // 
            this.بازیجدیدToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.بازیجدیدToolStripMenuItem.Name = "بازیجدیدToolStripMenuItem";
            this.بازیجدیدToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.بازیجدیدToolStripMenuItem.Text = "بازی جدید";
            this.بازیجدیدToolStripMenuItem.Click += new System.EventHandler(this.بازیجدیدToolStripMenuItem_Click);
            // 
            // EndGame
            // 
            this.EndGame.Location = new System.Drawing.Point(362, 12);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(88, 35);
            this.EndGame.TabIndex = 10;
            this.EndGame.Text = "اعلام نتایج";
            this.EndGame.UseVisualStyleBackColor = true;
            this.EndGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(368, 174);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(0, 38);
            this.End.TabIndex = 11;
            this.End.Click += new System.EventHandler(this.label1_Click);
            // 
            // Endtext
            // 
            this.Endtext.BackColor = System.Drawing.Color.Transparent;
            this.Endtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Endtext.ForeColor = System.Drawing.Color.Black;
            this.Endtext.Location = new System.Drawing.Point(364, 161);
            this.Endtext.Name = "Endtext";
            this.Endtext.Size = new System.Drawing.Size(181, 40);
            this.Endtext.TabIndex = 12;
            this.Endtext.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // rock
            // 
            this.rock.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.rock.Location = new System.Drawing.Point(37, 79);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 36);
            this.rock.TabIndex = 13;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // Paper
            // 
            this.Paper.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.Paper.Location = new System.Drawing.Point(37, 165);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 36);
            this.Paper.TabIndex = 14;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // scissors
            // 
            this.scissors.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.scissors.Location = new System.Drawing.Point(37, 270);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 36);
            this.scissors.TabIndex = 15;
            this.scissors.Text = "scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // fwldom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bgg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 455);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.Endtext);
            this.Controls.Add(this.End);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelcomputer);
            this.Controls.Add(this.panelplayer);
            this.Controls.Add(this.lblwinstate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picboxsang);
            this.Controls.Add(this.picboxGhaeychiey);
            this.Controls.Add(this.picboxkaghaz);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fwldom";
            this.Text = "ROPAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxkaghaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGhaeychiey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelplayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxplayer)).EndInit();
            this.panelcomputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxcomputer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxkaghaz;
        private System.Windows.Forms.PictureBox picboxGhaeychiey;
        private System.Windows.Forms.PictureBox picboxsang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblwinstate;
        private System.Windows.Forms.Panel panelplayer;
        private System.Windows.Forms.Panel panelcomputer;
        private System.Windows.Forms.PictureBox picboxplayer;
        private System.Windows.Forms.PictureBox picboxcomputer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بازیجدیدToolStripMenuItem;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label Endtext;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button scissors;
    }
}

