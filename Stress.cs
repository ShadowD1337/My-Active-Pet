using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myactivepett
{
    public partial class Stress : Form
    {
        //Form1 main = new Form1();
        public Stress()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //main.ButtonPreviousClicked();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //main.ButtonNextClicked();
        }

        private void btn_Back1_Click(object sender, EventArgs e)
        {
            Form1.ButtonPreviousClicked();
        }

        private void btn_Next1_Click(object sender, EventArgs e)
        {
            Form1.ButtonNextClicked();
        }

        private void lbl_constant_Click(object sender, EventArgs e)
        {

        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }
    }
}
