using System.Runtime.CompilerServices;

namespace myactivepett
{
    public partial class Form67 : Form
    {
        public Form67()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Show();
            panel3.BringToFront();
            panel1.Visible = false;
        }
        static bool charsVisible = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (charsVisible == false)
            {
                textBox3.UseSystemPasswordChar = false;
                charsVisible = true;
                button4.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\" + "EyeYes2.png");
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                charsVisible = false;
                button4.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\" + "EyeNo2.png");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (charsVisible == false)
            {
                textBox5.UseSystemPasswordChar = false;
                charsVisible = true;
                button5.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\" + "EyeYes2.png");
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
                charsVisible = false;
                button5.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\" + "EyeNo2.png");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1.Register(textBox4.Text, textBox5.Text, false, 0, 0, 0, "");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Login(this.textBox2.Text, this.textBox3.Text);
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}