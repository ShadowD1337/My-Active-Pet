using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myactivepett
{
    public partial class MainP : Form
    {
        public MainP()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            //this.panel1.BackgroundImage = Image.FromFile(Form1.user.avatar);
        }

        /*void NextAvatar()
        {
            Form1.NextAvatar();
            this.panel1.BackgroundImage = Image.FromFile(Form1.user.avatar);
        }

        void PreviousAvatar()
        {
            Form1.PreviousAvatar();
            this.panel1.BackgroundImage = Image.FromFile(Form1.user.avatar);
        }*/

        private void btn_paw_Click(object sender, EventArgs e)
        {
            Form1.SwitchToStress();
            this.Hide();
            this.Visible = false;
        }
        private void btn_cup_Click(object sender, EventArgs e)
        {
            /*PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile("Food.jpg"),
                Location = new Point(0, 0),
                Size = new Size(1920, 1080)
            };
            pictureBox.Show();
            pictureBox.BringToFront();
            Image oldImage = panel1.BackgroundImage;
            panel1.BackgroundImage = Image.FromFile("transparent.png");
            this.Controls.Add(pictureBox);*/

            Image oldImage = panel1.BackgroundImage;
            panel1.BackgroundImage = Image.FromFile("Food.jpg");
        }
        private void btn_sport_Click(object sender, EventArgs e)
        {
            Image oldImage = panel1.BackgroundImage;
            panel1.BackgroundImage = Image.FromFile("Sport.png");
        }
    }
}
