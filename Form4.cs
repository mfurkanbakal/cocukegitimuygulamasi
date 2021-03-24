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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       

        Image[] resimler =
       {        Properties.Resources.inek,
                Properties.Resources.at,
                Properties.Resources.kuzu,
                Properties.Resources.fil,
                 Properties.Resources.aslan,
                  Properties.Resources.kaplan,
                   Properties.Resources.köpek,
                    Properties.Resources.ördek,
                    Properties.Resources._1,
        Properties.Resources._2,
        Properties.Resources._3,
        Properties.Resources._4,
        Properties.Resources._5,
        Properties.Resources._6,
        Properties.Resources._7,
        Properties.Resources._8,
        Properties.Resources._9,
        Properties.Resources._10,


        };
     
        Random rastgele = new Random();
        int[] indexler = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17 };  
        
       
        bool hareket_durumu = false;
        bool şart1 = false;
        bool şart2 = false;
        bool şart3 = false;
        bool şart4 = false;
        Point ilk;
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            hareket_durumu = true;
            pictureBox6.Cursor = Cursors.SizeAll;
            ilk = e.Location;
        }
        private void yerlerikarıştır()
        {
           switch(pictureBox6.Name)
            {
                case "0":
                    pictureBox6.Location = pictureBox1.Location;
                    break;
                case "1":
                    pictureBox6.Location = pictureBox2.Location;
                    break;
                case "2":
                    pictureBox6.Location = pictureBox3.Location;
                    break;
                case "3":
                    pictureBox6.Location = pictureBox8.Location;
                    break;
            }
            switch (pictureBox5.Name)
            {
                case "0":
                    pictureBox5.Location = pictureBox1.Location;
                    break;
                case "1":
                    pictureBox5.Location = pictureBox2.Location;
                    break;
                case "2":
                    pictureBox5.Location = pictureBox3.Location;
                    break;
                case "3":
                    pictureBox5.Location = pictureBox8.Location;
                    break;
            }
            switch (pictureBox4.Name)
            {
                case "0":
                    pictureBox4.Location = pictureBox1.Location;
                    break;
                case "1":
                    pictureBox4.Location = pictureBox2.Location;
                    break;
                case "2":
                    pictureBox4.Location = pictureBox3.Location;
                    break;
                case "3":
                    pictureBox4.Location = pictureBox8.Location;
                    break;
            }
            switch (pictureBox7.Name)
            {
                case "0":
                    pictureBox7.Location = pictureBox1.Location;
                    break;
                case "1":
                    pictureBox7.Location = pictureBox2.Location;
                    break;
                case "2":
                    pictureBox7.Location = pictureBox3.Location;
                    break;
                case "3":
                    pictureBox7.Location = pictureBox8.Location;
                    break;

            }




        }
        private void karıştır()
        {
            for (int i = 0; i < 17; i++)
            {
                int sayi = rastgele.Next(17);
                int temp = indexler[i];
                indexler[i] = indexler[sayi];
                indexler[sayi] = temp;

            }
           


            pictureBox4.Image = resimler[indexler[0]];
            pictureBox6.Image = resimler[indexler[2]];
            pictureBox5.Image = resimler[indexler[1]];
            pictureBox7.Image = resimler[indexler[3]];
            pictureBox4.Name = indexler[0].ToString();
            pictureBox5.Name = indexler[1].ToString();
            pictureBox6.Name = indexler[2].ToString();
            pictureBox7.Name = indexler[3].ToString();

            label1.Name = indexler[0].ToString();
            label4.Name = indexler[1].ToString();
            label3.Name = indexler[2].ToString();
            label5.Name = indexler[3].ToString();

        }
        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if(hareket_durumu== true)
            {
                pictureBox6.Left = e.X + pictureBox6.Left - (ilk.X);
                pictureBox6.Top = e.Y + pictureBox6.Top - (ilk.Y);

            }

            
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            hareket_durumu = false;
            pictureBox6.Cursor = Cursors.Default;
            if (pictureBox6.Bounds.IntersectsWith(label1.Bounds) )
            {
                if(pictureBox6.Name== label1.Name)
                {
                    label1.BackColor = Color.Green;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    
                    şart2 = true;
                }
                else
                {
                    label1.BackColor = Color.Red;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
              

            }
            else
            {

                label1.BackColor = Color.Transparent;

            }
               
            if (pictureBox6.Bounds.IntersectsWith(label4.Bounds) )
            {
                if (pictureBox6.Name == label4.Name)
                {
                    label4.BackColor = Color.Green;
                    şart2 = true;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label4.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label4.BackColor = Color.Transparent;

            }
            if (pictureBox6.Bounds.IntersectsWith(label3.Bounds) )
            {
               
                if (pictureBox6.Name == label3.Name)
                {
                    label3.BackColor = Color.Green;
                    şart2 = true;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label3.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label3.BackColor = Color.Transparent;

            }


            if (pictureBox6.Bounds.IntersectsWith(label5.Bounds))
            {

                if (pictureBox6.Name == label5.Name)
                {
                    label5.BackColor = Color.Green;
                    şart2 = true;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label5.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label5.BackColor = Color.Transparent;

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            karıştır();
            yerlerikarıştır();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            switch (label1.Name)
            {
                case "0":
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath+ "\\inek.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    break;

                case "1":
                    SoundPlayer ses1 = new SoundPlayer();
                    string dizin1 = Application.StartupPath + "\\at.wav";
                    ses1.SoundLocation = dizin1;
                    ses1.Play();
                    break;
                case "2":

                    SoundPlayer ses2 = new SoundPlayer();
                    string dizin2 = Application.StartupPath + "\\kuzu.wav";
                    ses2.SoundLocation = dizin2;
                    ses2.Play();
                    break;
                case "3":
                    SoundPlayer ses3 = new SoundPlayer();
                    string dizin3 = Application.StartupPath +"\\fil.wav";
                    ses3.SoundLocation = dizin3;
                    ses3.Play();

                    break;
                case "4":
                    SoundPlayer ses4 = new SoundPlayer();
                    string dizin4 = Application.StartupPath + "\\aslan.wav";
                    ses4.SoundLocation = dizin4;
                    ses4.Play();

                    break;
                case "5":
                    SoundPlayer ses5 = new SoundPlayer();
                    string dizin5 = Application.StartupPath + "\\kaplan.wav";
                    ses5.SoundLocation = dizin5;
                    ses5.Play();

                    break;
                case "6":
                    SoundPlayer ses6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\köpek.wav";
                    ses6.SoundLocation = dizin6;
                    ses6.Play();

                    break;
                case "7":
                    SoundPlayer ses7 = new SoundPlayer();
                    string dizin7 = Application.StartupPath + "\\ördek.wav";
                    ses7.SoundLocation = dizin7;
                    ses7.Play();

                    break;
                case "8":
                    SoundPlayer ses8 = new SoundPlayer();
                    string dizin8 = Application.StartupPath + "\\1.wav";
                    ses8.SoundLocation = dizin8;
                    ses8.Play();

                    break;
                case "9":
                    SoundPlayer ses9 = new SoundPlayer();
                    string dizin9 = Application.StartupPath + "\\2.wav";
                    ses9.SoundLocation = dizin9;
                    ses9.Play();

                    break;
                case "10":
                    SoundPlayer ses10 = new SoundPlayer();
                    string dizin10 = Application.StartupPath + "\\3.wav";
                    ses10.SoundLocation = dizin10;
                    ses10.Play();

                    break;
                case "11":
                    SoundPlayer ses11 = new SoundPlayer();
                    string dizin11 = Application.StartupPath + "\\4.wav";
                    ses11.SoundLocation = dizin11;
                    ses11.Play();

                    break;
                case "12":
                    SoundPlayer ses12 = new SoundPlayer();
                    string dizin12 = Application.StartupPath + "\\5.wav";
                    ses12.SoundLocation = dizin12;
                    ses12.Play();

                    break;
                case "13":
                    SoundPlayer ses13 = new SoundPlayer();
                    string dizin13 = Application.StartupPath + "\\6.wav";
                    ses13.SoundLocation = dizin13;
                    ses13.Play();

                    break;
                case "14":
                    SoundPlayer ses14 = new SoundPlayer();
                    string dizin14 = Application.StartupPath + "\\7.wav";
                    ses14.SoundLocation = dizin14;
                    ses14.Play();

                    break;
                case "15":
                    SoundPlayer ses15 = new SoundPlayer();
                    string dizin15= Application.StartupPath + "\\8.wav";
                    ses15.SoundLocation = dizin15;
                    ses15.Play();

                    break;
                case "16":
                    SoundPlayer ses16 = new SoundPlayer();
                    string dizin16 = Application.StartupPath + "\\9.wav";
                    ses16.SoundLocation = dizin16;
                    ses16.Play();

                    break;
                case "17":
                    SoundPlayer ses17 = new SoundPlayer();
                    string dizin17 = Application.StartupPath + "\\10.wav";
                    ses17.SoundLocation = dizin17;
                    ses17.Play();

                    break;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            switch (label4.Name)
            {
                case "0":
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\inek.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    break;

                case "1":
                    SoundPlayer ses1 = new SoundPlayer();
                    string dizin1 = Application.StartupPath + "\\at.wav";
                    ses1.SoundLocation = dizin1;
                    ses1.Play();
                    break;
                case "2":

                    SoundPlayer ses2 = new SoundPlayer();
                    string dizin2 = Application.StartupPath + "\\kuzu.wav";
                    ses2.SoundLocation = dizin2;
                    ses2.Play();
                    break;
                case "3":
                    SoundPlayer ses3 = new SoundPlayer();
                    string dizin3 = Application.StartupPath + "\\fil.wav";
                    ses3.SoundLocation = dizin3;
                    ses3.Play();

                    break;
                case "4":
                    SoundPlayer ses4 = new SoundPlayer();
                    string dizin4 = Application.StartupPath + "\\aslan.wav";
                    ses4.SoundLocation = dizin4;
                    ses4.Play();

                    break;
                case "5":
                    SoundPlayer ses5 = new SoundPlayer();
                    string dizin5 = Application.StartupPath + "\\kaplan.wav";
                    ses5.SoundLocation = dizin5;
                    ses5.Play();

                    break;
                case "6":
                    SoundPlayer ses6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\köpek.wav";
                    ses6.SoundLocation = dizin6;
                    ses6.Play();

                    break;
                case "7":
                    SoundPlayer ses7 = new SoundPlayer();
                    string dizin7 = Application.StartupPath + "\\ördek.wav";
                    ses7.SoundLocation = dizin7;
                    ses7.Play();

                    break;
                case "8":
                    SoundPlayer ses8 = new SoundPlayer();
                    string dizin8 = Application.StartupPath + "\\1.wav";
                    ses8.SoundLocation = dizin8;
                    ses8.Play();

                    break;
                case "9":
                    SoundPlayer ses9 = new SoundPlayer();
                    string dizin9 = Application.StartupPath + "\\2.wav";
                    ses9.SoundLocation = dizin9;
                    ses9.Play();

                    break;
                case "10":
                    SoundPlayer ses10 = new SoundPlayer();
                    string dizin10 = Application.StartupPath + "\\3.wav";
                    ses10.SoundLocation = dizin10;
                    ses10.Play();

                    break;
                case "11":
                    SoundPlayer ses11 = new SoundPlayer();
                    string dizin11 = Application.StartupPath + "\\4.wav";
                    ses11.SoundLocation = dizin11;
                    ses11.Play();

                    break;
                case "12":
                    SoundPlayer ses12 = new SoundPlayer();
                    string dizin12 = Application.StartupPath + "\\5.wav";
                    ses12.SoundLocation = dizin12;
                    ses12.Play();

                    break;
                case "13":
                    SoundPlayer ses13 = new SoundPlayer();
                    string dizin13 = Application.StartupPath + "\\6.wav";
                    ses13.SoundLocation = dizin13;
                    ses13.Play();

                    break;
                case "14":
                    SoundPlayer ses14 = new SoundPlayer();
                    string dizin14 = Application.StartupPath + "\\7.wav";
                    ses14.SoundLocation = dizin14;
                    ses14.Play();

                    break;
                case "15":
                    SoundPlayer ses15 = new SoundPlayer();
                    string dizin15 = Application.StartupPath + "\\8.wav";
                    ses15.SoundLocation = dizin15;
                    ses15.Play();

                    break;
                case "16":
                    SoundPlayer ses16 = new SoundPlayer();
                    string dizin16 = Application.StartupPath + "\\9.wav";
                    ses16.SoundLocation = dizin16;
                    ses16.Play();

                    break;
                case "17":
                    SoundPlayer ses17 = new SoundPlayer();
                    string dizin17 = Application.StartupPath + "\\10.wav";
                    ses17.SoundLocation = dizin17;
                    ses17.Play();

                    break;
            }
        }

       
        private void label3_Click(object sender, EventArgs e)
        {
            switch (label3.Name)
            {
                case "0":
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\inek.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    break;

                case "1":
                    SoundPlayer ses1 = new SoundPlayer();
                    string dizin1 = Application.StartupPath + "\\at.wav";
                    ses1.SoundLocation = dizin1;
                    ses1.Play();
                    break;
                case "2":

                    SoundPlayer ses2 = new SoundPlayer();
                    string dizin2 = Application.StartupPath + "\\kuzu.wav";
                    ses2.SoundLocation = dizin2;
                    ses2.Play();
                    break;
                case "3":
                    SoundPlayer ses3 = new SoundPlayer();
                    string dizin3 = Application.StartupPath + "\\fil.wav";
                    ses3.SoundLocation = dizin3;
                    ses3.Play();

                    break;
                case "4":
                    SoundPlayer ses4 = new SoundPlayer();
                    string dizin4 = Application.StartupPath + "\\aslan.wav";
                    ses4.SoundLocation = dizin4;
                    ses4.Play();

                    break;
                case "5":
                    SoundPlayer ses5 = new SoundPlayer();
                    string dizin5 = Application.StartupPath + "\\kaplan.wav";
                    ses5.SoundLocation = dizin5;
                    ses5.Play();

                    break;
                case "6":
                    SoundPlayer ses6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\köpek.wav";
                    ses6.SoundLocation = dizin6;
                    ses6.Play();

                    break;
                case "7":
                    SoundPlayer ses7 = new SoundPlayer();
                    string dizin7 = Application.StartupPath + "\\ördek.wav";
                    ses7.SoundLocation = dizin7;
                    ses7.Play();

                    break;
                case "8":
                    SoundPlayer ses8 = new SoundPlayer();
                    string dizin8 = Application.StartupPath + "\\1.wav";
                    ses8.SoundLocation = dizin8;
                    ses8.Play();

                    break;
                case "9":
                    SoundPlayer ses9 = new SoundPlayer();
                    string dizin9 = Application.StartupPath + "\\2.wav";
                    ses9.SoundLocation = dizin9;
                    ses9.Play();

                    break;
                case "10":
                    SoundPlayer ses10 = new SoundPlayer();
                    string dizin10 = Application.StartupPath + "\\3.wav";
                    ses10.SoundLocation = dizin10;
                    ses10.Play();

                    break;
                case "11":
                    SoundPlayer ses11 = new SoundPlayer();
                    string dizin11 = Application.StartupPath + "\\4.wav";
                    ses11.SoundLocation = dizin11;
                    ses11.Play();

                    break;
                case "12":
                    SoundPlayer ses12 = new SoundPlayer();
                    string dizin12 = Application.StartupPath + "\\5.wav";
                    ses12.SoundLocation = dizin12;
                    ses12.Play();

                    break;
                case "13":
                    SoundPlayer ses13 = new SoundPlayer();
                    string dizin13 = Application.StartupPath + "\\6.wav";
                    ses13.SoundLocation = dizin13;
                    ses13.Play();

                    break;
                case "14":
                    SoundPlayer ses14 = new SoundPlayer();
                    string dizin14 = Application.StartupPath + "\\7.wav";
                    ses14.SoundLocation = dizin14;
                    ses14.Play();

                    break;
                case "15":
                    SoundPlayer ses15 = new SoundPlayer();
                    string dizin15 = Application.StartupPath + "\\8.wav";
                    ses15.SoundLocation = dizin15;
                    ses15.Play();

                    break;
                case "16":
                    SoundPlayer ses16 = new SoundPlayer();
                    string dizin16 = Application.StartupPath + "\\9.wav";
                    ses16.SoundLocation = dizin16;
                    ses16.Play();

                    break;
                case "17":
                    SoundPlayer ses17 = new SoundPlayer();
                    string dizin17 = Application.StartupPath + "\\10.wav";
                    ses17.SoundLocation = dizin17;
                    ses17.Play();

                    break;

            }

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            hareket_durumu = true;
            pictureBox5.Cursor = Cursors.SizeAll;
            ilk = e.Location;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket_durumu == true)
            {
                pictureBox5.Left = e.X + pictureBox5.Left - (ilk.X);
                pictureBox5.Top = e.Y + pictureBox5.Top - (ilk.Y);

            }

        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            hareket_durumu = false;
            pictureBox5.Cursor = Cursors.Default;
            if (pictureBox5.Bounds.IntersectsWith(label1.Bounds) )
            {
                if (pictureBox5.Name == label1.Name)
                {
                    label1.BackColor = Color.Green;
                     şart1 = true;
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label1.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label1.BackColor = Color.Transparent;

            }
            if (pictureBox5.Bounds.IntersectsWith(label4.Bounds))
            {

                
                if (pictureBox5.Name == label4.Name)
                {
                    label4.BackColor = Color.Green;
                     şart1 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label4.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
            }
            else
            {

                label4.BackColor = Color.Transparent;

            }
            if (pictureBox5.Bounds.IntersectsWith(label3.Bounds) )
            {
               
                if (pictureBox5.Name == label3.Name)
                {
                    label3.BackColor = Color.Green;
                     şart1 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label3.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
            }
            else
            {

                label3.BackColor = Color.Transparent;

            }
            if (pictureBox5.Bounds.IntersectsWith(label5.Bounds))
            {

                if (pictureBox5.Name == label5.Name)
                {
                    label5.BackColor = Color.Green;
                    şart1 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label5.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label5.BackColor = Color.Transparent;

            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            hareket_durumu = true;
            pictureBox4.Cursor = Cursors.SizeAll;
            ilk = e.Location;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket_durumu == true)
            {
                pictureBox4.Left = e.X + pictureBox4.Left - (ilk.X);
                pictureBox4.Top = e.Y + pictureBox4.Top - (ilk.Y);

            }

        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            hareket_durumu = false;
            pictureBox4.Cursor = Cursors.Default;
            if (pictureBox4.Bounds.IntersectsWith(label1.Bounds))
            {
                if (pictureBox4.Name == label1.Name)
                {
                    label1.BackColor = Color.Green;
                    şart3 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label1.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label1.BackColor = Color.Transparent;

            }
            if (pictureBox4.Bounds.IntersectsWith(label4.Bounds) )
            {

              
                if (pictureBox4.Name == label4.Name)
                {
                    label4.BackColor = Color.Green;
                    şart3 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label4.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label4.BackColor = Color.Transparent;

            }
            if (pictureBox4.Bounds.IntersectsWith(label3.Bounds))
            {
              
                if (pictureBox4.Name == label3.Name)
                {
                    label3.BackColor = Color.Green;
                    şart3 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label3.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label3.BackColor = Color.Transparent;

            }
            if (pictureBox4.Bounds.IntersectsWith(label5.Bounds))
            {

                if (pictureBox4.Name == label5.Name)
                {
                    label5.BackColor = Color.Green;
                    şart3 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label5.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label5.BackColor = Color.Transparent;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label1.BackColor==Color.Green)
            {
                label7.BackColor = Color.Green;
            }
            if (label4.BackColor == Color.Green)
            {
                label2.BackColor = Color.Green;
            }
            if (label3.BackColor == Color.Green)
            {
                label6.BackColor = Color.Green;
            }
            if (label5.BackColor == Color.Green)
            {
                label8.BackColor = Color.Green;
            }

            if (şart1 == true && şart2 == true && şart3 == true&& şart4==true)
            {
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\alkışş.wav";
                ses.SoundLocation = dizin;
                ses.Play();
               
                timer1.Enabled = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox9.Visible = false;
                pictureBox16.Visible = true;

            }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            hareket_durumu = true;
            pictureBox7.Cursor = Cursors.SizeAll;
            ilk = e.Location;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket_durumu == true)
            {
                pictureBox7.Left = e.X + pictureBox7.Left - (ilk.X);
                pictureBox7.Top = e.Y + pictureBox7.Top - (ilk.Y);

            }
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            hareket_durumu = false;
            pictureBox7.Cursor = Cursors.Default;
            if (pictureBox7.Bounds.IntersectsWith(label1.Bounds))
            {
                if (pictureBox7.Name == label1.Name)
                {
                    label1.BackColor = Color.Green;
                    şart4 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label1.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label1.BackColor = Color.Transparent;

            }
            if (pictureBox7.Bounds.IntersectsWith(label4.Bounds))
            {


                if (pictureBox7.Name == label4.Name)
                {
                    label4.BackColor = Color.Green;
                    şart4 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label4.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label4.BackColor = Color.Transparent;

            }
            if (pictureBox7.Bounds.IntersectsWith(label3.Bounds))
            {

                if (pictureBox7.Name == label3.Name)
                {
                    label3.BackColor = Color.Green;
                    şart4 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label3.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label3.BackColor = Color.Transparent;

            }
            if (pictureBox7.Bounds.IntersectsWith(label5.Bounds))
            {

                if (pictureBox7.Name == label5.Name)
                {
                    label5.BackColor = Color.Green;
                    şart4 = true; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\doğru.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    label5.BackColor = Color.Red; SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlış.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }

            }
            else
            {

                label5.BackColor = Color.Transparent;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            switch (label5.Name)
            {
                case "0":
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\inek.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    break;

                case "1":
                    SoundPlayer ses1 = new SoundPlayer();
                    string dizin1 = Application.StartupPath + "\\at.wav";
                    ses1.SoundLocation = dizin1;
                    ses1.Play();
                    break;
                case "2":

                    SoundPlayer ses2 = new SoundPlayer();
                    string dizin2 = Application.StartupPath + "\\kuzu.wav";
                    ses2.SoundLocation = dizin2;
                    ses2.Play();
                    break;
                case "3":
                    SoundPlayer ses3 = new SoundPlayer();
                    string dizin3 = Application.StartupPath + "\\fil.wav";
                    ses3.SoundLocation = dizin3;
                    ses3.Play();

                    break;
                case "4":
                    SoundPlayer ses4 = new SoundPlayer();
                    string dizin4 = Application.StartupPath + "\\aslan.wav";
                    ses4.SoundLocation = dizin4;
                    ses4.Play();

                    break;
                case "5":
                    SoundPlayer ses5 = new SoundPlayer();
                    string dizin5 = Application.StartupPath + "\\kaplan.wav";
                    ses5.SoundLocation = dizin5;
                    ses5.Play();

                    break;
                case "6":
                    SoundPlayer ses6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\köpek.wav";
                    ses6.SoundLocation = dizin6;
                    ses6.Play();

                    break;
                case "7":
                    SoundPlayer ses7 = new SoundPlayer();
                    string dizin7 = Application.StartupPath + "\\ördek.wav";
                    ses7.SoundLocation = dizin7;
                    ses7.Play();

                    break;
                case "8":
                    SoundPlayer ses8 = new SoundPlayer();
                    string dizin8 = Application.StartupPath + "\\1.wav";
                    ses8.SoundLocation = dizin8;
                    ses8.Play();

                    break;
                case "9":
                    SoundPlayer ses9 = new SoundPlayer();
                    string dizin9 = Application.StartupPath + "\\2.wav";
                    ses9.SoundLocation = dizin9;
                    ses9.Play();

                    break;
                case "10":
                    SoundPlayer ses10 = new SoundPlayer();
                    string dizin10 = Application.StartupPath + "\\3.wav";
                    ses10.SoundLocation = dizin10;
                    ses10.Play();

                    break;
                case "11":
                    SoundPlayer ses11 = new SoundPlayer();
                    string dizin11 = Application.StartupPath + "\\4.wav";
                    ses11.SoundLocation = dizin11;
                    ses11.Play();

                    break;
                case "12":
                    SoundPlayer ses12 = new SoundPlayer();
                    string dizin12 = Application.StartupPath + "\\5.wav";
                    ses12.SoundLocation = dizin12;
                    ses12.Play();

                    break;
                case "13":
                    SoundPlayer ses13 = new SoundPlayer();
                    string dizin13 = Application.StartupPath + "\\6.wav";
                    ses13.SoundLocation = dizin13;
                    ses13.Play();

                    break;
                case "14":
                    SoundPlayer ses14 = new SoundPlayer();
                    string dizin14 = Application.StartupPath + "\\7.wav";
                    ses14.SoundLocation = dizin14;
                    ses14.Play();

                    break;
                case "15":
                    SoundPlayer ses15 = new SoundPlayer();
                    string dizin15 = Application.StartupPath + "\\8.wav";
                    ses15.SoundLocation = dizin15;
                    ses15.Play();

                    break;
                case "16":
                    SoundPlayer ses16 = new SoundPlayer();
                    string dizin16 = Application.StartupPath + "\\9.wav";
                    ses16.SoundLocation = dizin16;
                    ses16.Play();

                    break;
                case "17":
                    SoundPlayer ses17 = new SoundPlayer();
                    string dizin17 = Application.StartupPath + "\\10.wav";
                    ses17.SoundLocation = dizin17;
                    ses17.Play();

                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
