using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{  
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL ="";
            Form2 abc = new Form2();
            abc.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL = "";
            Form5 abc = new Form5();
            abc.Show();
            this.Hide();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 0;
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\menü.wav";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL = "";
            Form4 abc = new Form4();
            abc.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if(a==32)
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\menü.wav";
                a=0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
