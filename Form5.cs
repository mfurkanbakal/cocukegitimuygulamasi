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
using System.Threading;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form5 : Form
    {
        bool yukarıgit = false, aşagıgit=false;
        int hız = 15;   
        int a = 0;
        int benzin = 100;
        int sonuc=0;
        int toplanan_yıldız = 0;
        List<PictureBox> yıldızlar = new List<PictureBox>();
        Random rastgele = new Random();
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            label22.Text = toplanan_yıldız.ToString();
            progressBar1.Value = benzin;
            if (benzin == 0)
            {
                benzinbitti();
            }
            if (yukarıgit == true && pictureBox1.Top>40)
            {
                
                pictureBox1.Top -= hız;
            }

            if (aşagıgit == true && pictureBox1.Top<600)
            {
                pictureBox1.Top += hız;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is PictureBox && (string)a.Tag == "yıldız")
                {
                    if (a.Bounds.IntersectsWith(pictureBox1.Bounds))
                    {
                        toplanan_yıldız++;
                        this.Controls.Remove(a);
                        ((PictureBox)a).Dispose();
                        SoundPlayer ses6 = new SoundPlayer();
                        string dizin6 = Application.StartupPath + "\\y.wav";
                        ses6.SoundLocation = dizin6;
                        ses6.Play();
                    }

                    if (a.Left < 5)
                    {
                        this.Controls.Remove(a);
                        ((PictureBox)a).Dispose();
                    }
                }
                if (a is PictureBox && (string)a.Tag == "kuş")
                {
                    if (a.Bounds.IntersectsWith(pictureBox1.Bounds))
                    {
                        this.Controls.Remove(a);
                        ((PictureBox)a).Dispose();
                       if(benzin>5)
                        {
                            benzin = benzin - 4;
                        }
                       

                        SoundPlayer ses6 = new SoundPlayer();
                        string dizin6 = Application.StartupPath + "\\yanlış2.wav";
                        ses6.SoundLocation = dizin6;
                        ses6.Play();
                    }

                    if (a.Left < 5)
                    {
                        this.Controls.Remove(a);
                        ((PictureBox)a).Dispose();
                    }
                }


                if (a is PictureBox && (string)a.Tag == "yıldız")

                {
                    if (a.Left > 0)
                    {
                        a.Left -= hız;

                    }

                }
                if (a is PictureBox && (string)a.Tag == "kuş")

                {
                    if (a.Left > 0)
                    {
                        a.Left -= hız - 5;

                    }

                }
            }
        }
     
        private void timer3_Tick(object sender, EventArgs e)
        {
           
            yıldızspawn();
          
            if(benzin>0)
            {

             benzin = benzin - 4;
            }
            
        }

     

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
                yukarıgit = false;

            }
            if (e.KeyCode == Keys.Down)
            {
              
                aşagıgit = false;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == sonuc.ToString())
            {

                label6.BackColor = Color.Green;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\doğru.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                
                benzindoldu();
            }
            else
            {
                label6.BackColor = Color.Red;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\yanlış.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == sonuc.ToString())
            {

                label7.BackColor = Color.Green;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\doğru.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                
                benzindoldu();
            }
            else
            {
                label7.BackColor = Color.Red;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\yanlış.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == sonuc.ToString())
            {

                label8.BackColor = Color.Green;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\doğru.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                
                benzindoldu();
            }
            else
            {
                label8.BackColor = Color.Red;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\yanlış.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
           if(label9.Text==sonuc.ToString())
            {

                label9.BackColor = Color.Green;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\doğru.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                
                benzindoldu();
            }
            else
            {
                label9.BackColor = Color.Red;
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\yanlış.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\motoruçma.wav";
        }
        private void benzindoldu()
        {
            label6.BackColor = Color.PeachPuff;
            label7.BackColor = Color.PeachPuff;
            label8.BackColor = Color.PeachPuff;
            label9.BackColor = Color.PeachPuff;


            pictureBox1.Left = 29;
            pictureBox1.Top = 300;
          if (pictureBox1.Left==29)
            {
                benzin = 100;
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                pictureBox2.Visible = false;
                label10.Visible = false;
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\motoruçma.wav";
            }
            

        }
        private void benzinbitti()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\benzinbitti.wav";
            ses.SoundLocation = dizin;
            ses.Play();

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            pictureBox2.Visible = true;
            label10.Visible = true ;
            while (pictureBox1.Top < 498)
            {
              
                pictureBox1.Top += hız;
                pictureBox1.Left += hız;
                System.Threading.Thread.Sleep(100);
            }
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            int sayı1, sayı2, işlem;
            int a, b;

            sayı1 = rastgele.Next(1, 10);
            sayı2 = rastgele.Next(1, 10);
            işlem = rastgele.Next(0, 2);
            int seçenek;

            while (işlem == 1 && (sayı2 > sayı1))
            {
                sayı1 = rastgele.Next(1, 10);
                sayı2 = rastgele.Next(1, 10);
                işlem = rastgele.Next(0, 2);
            }

            label1.Text = sayı1.ToString();
            label5.Text = sayı2.ToString();

            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label5.Text);


            if (işlem == 0)
            {
                label2.Text = "+";
                sonuc= a + b;
                

            }
            if (işlem == 1)
            {
                label2.Text = "-";
                sonuc = a - b;
                
            }
            seçenek = rastgele.Next(6, 10);

            if (seçenek == 6)
            {
                label6.Text = sonuc.ToString();
                label7.Text = (sonuc + 2).ToString();
                label8.Text = (sonuc - 2).ToString();
                label9.Text = (sonuc + 1).ToString();
            }
            if (seçenek == 7)
            {
                label7.Text = sonuc.ToString();
                label6.Text = (sonuc + 2).ToString();
                label8.Text = (sonuc - 2).ToString();
                label9.Text = (sonuc + 1).ToString();
            }
            if (seçenek == 8)
            {
                label8.Text = sonuc.ToString();
                label7.Text = (sonuc + 2).ToString();
                label6.Text = (sonuc - 2).ToString();
                label9.Text = (sonuc + 1).ToString();
            }
            if (seçenek == 9)
            {
                label9.Text = sonuc.ToString();
                label7.Text = (sonuc + 2).ToString();
                label8.Text = (sonuc - 2).ToString();
                label6.Text = (sonuc + 1).ToString();
            }




        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

        {
            if (keyData == Keys.Up)
            {
               
                yukarıgit = true;
            }
            if (keyData == Keys.Down)
            {

                aşagıgit = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
     

        private void yıldızspawn()
        {
            PictureBox yıldız = new PictureBox();
            yıldız.Tag = "yıldız";
            yıldız.Image = Properties.Resources.yıldız;


            yıldız.Left = 870;
            yıldız.Top = rastgele.Next(0, 785);
            yıldız.SizeMode = PictureBoxSizeMode.StretchImage;
            yıldızlar.Add(yıldız);
            this.Controls.Add(yıldız);
            pictureBox1.BringToFront();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            kuşspawn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            a++;
            if(a==13)
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\motoruçma.wav";
                a = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void kuşspawn()
        {
            PictureBox kuş = new PictureBox();
            kuş.Tag = "kuş";
            kuş.Image = Properties.Resources.kuş_gif;


            kuş.Left = 870;
            kuş.Top = rastgele.Next(0, 785);
            kuş.SizeMode = PictureBoxSizeMode.StretchImage;
            yıldızlar.Add(kuş);
            this.Controls.Add(kuş);
            pictureBox1.BringToFront();

        }

    }
}
