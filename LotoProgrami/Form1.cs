using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayac=0;
        string mesaj1 = "tebrikler kazandınız";
        string mesaj2 = "maalesef kazanamadınız,şansınızı tekrar deneyiniz";

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                          
            if (sayac <= 30)
            {
                int sayi1 = rnd.Next(1, 50);
                button1.Text = sayi1.ToString();              
            }
             if (sayac <= 40)
            {
                int sayi2 = rnd.Next(1, 50);
                button2.Text = sayi2.ToString();
            }
             if (sayac <= 50)
            {
                int sayi3 = rnd.Next(1, 50);
                button3.Text = sayi3.ToString();
            }
             if (sayac <=60)
            {
                int sayi4 = rnd.Next(1, 50);
                button4.Text = sayi4.ToString();
            }
             if (sayac <= 70)
            {
                int sayi5 = rnd.Next(1, 50);
                button5.Text = sayi5.ToString();
            }
             if (sayac <= 80)
            {
                int sayi6 = rnd.Next(1, 50);
                button6.Text = sayi6.ToString();
            }
            
            else
            {
                timer1.Stop();
            }
            sayac++;            
            
            }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text == textBox1.Text &&
                button2.Text == textBox2.Text &&
                button3.Text == textBox3.Text &&
                button4.Text == textBox4.Text &&
                button5.Text == textBox5.Text &&
                button6.Text == textBox6.Text)
            {
                MessageBox.Show(mesaj1);
            }
            else
            {
                MessageBox.Show(mesaj2);
            }
        }
    }
        
	

	}

        
    

