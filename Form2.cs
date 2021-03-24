using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form2 : Form
    {
        Image[] resimler =
        {
                Properties.Resources.akın,
                Properties.Resources.hale,
                Properties.Resources.hayri,
                Properties.Resources.kamil,
                Properties.Resources.mert,
                Properties.Resources.sevim,
                Properties.Resources.usta,
                Properties.Resources.yumak
        };
        Random rastgele = new Random();
        int[] indexler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4,5,5,6,6,7,7};
        PictureBox firstbox;
        int firstindex,correct=0,attemps=0,a=0;
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            a = 0;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL= Application.StartupPath + "\\rafadanmüzik.wav";
            correct = 0;
            attemps = 0;
            karıştır();
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox1.Image = Properties.Resources.rafadan;
            pictureBox2.Image = Properties.Resources.rafadan;
            pictureBox3.Image = Properties.Resources.rafadan;
            pictureBox4.Image = Properties.Resources.rafadan;
            pictureBox5.Image = Properties.Resources.rafadan;
            pictureBox6.Image = Properties.Resources.rafadan;
            pictureBox7.Image = Properties.Resources.rafadan;
            pictureBox8.Image = Properties.Resources.rafadan;
            pictureBox9.Image = Properties.Resources.rafadan;
            pictureBox10.Image = Properties.Resources.rafadan;
            pictureBox11.Image = Properties.Resources.rafadan;
            pictureBox12.Image = Properties.Resources.rafadan;
            pictureBox13.Image = Properties.Resources.rafadan;
            pictureBox14.Image = Properties.Resources.rafadan;
            pictureBox15.Image = Properties.Resources.rafadan;
            pictureBox16.Image = Properties.Resources.rafadan;
           

        }



        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL = "";
            axWindowsMediaPlayer1.close();
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void karıştır()
        {
            for(int i=0;i<16;i++)
            {
                int sayi = rastgele.Next(15);
                int temp = indexler[i];
                indexler[i] = indexler[sayi];
                indexler[sayi] = temp;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox rafadan = (PictureBox)sender;
            int kutuindex = int.Parse(rafadan.Name.Substring(10));
            int resimno = indexler[kutuindex-1];
            rafadan.Image = resimler[resimno];
            rafadan.Refresh(); 
            if(firstbox==null)
            {
                firstbox = rafadan;
                firstindex = resimno;
                attemps++;
            }
            else 
            {
                System.Threading.Thread.Sleep(500);

                firstbox.Image = Properties.Resources.rafadan;
                rafadan.Image = Properties.Resources.rafadan;

                if (firstindex== resimno)
                {
                    correct++;
                    firstbox.Visible = false;
                    rafadan.Visible = false;
                    SoundPlayer ses6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\y.wav";
                    ses6.SoundLocation = dizin6;
                    ses6.Play();
                   

                    if (correct==8)
                    {
                        axWindowsMediaPlayer1.URL = "";
                        pictureBox18.Visible = true;
                        pictureBox19.Visible = true;
                        pictureBox20.Visible = true;
                        pictureBox21.Visible = true;
                        pictureBox22.Visible = true;
                        pictureBox23.Visible = true;
                        SoundPlayer ses = new SoundPlayer();
                        string dizin = Application.StartupPath + "\\alkışş.wav";
                        ses.SoundLocation = dizin;
                        ses.Play();
                        MessageBox.Show("Tebrikler oyunu " + attemps + " denemede kazandın!!!");
                        Form2 abc = new Form2();
                        abc.Show();
                        this.Hide();
                        correct = 0;

                        attemps = 0;

                       
                        foreach (Control kontrol in Controls )
                        {
                            kontrol.Visible = true;
                        }
                    }
                }
                firstbox = null;

            }


        }
    }
}
