using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenekmi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            } 
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
                Ekranlabel.Text += "1";
        }

        private void Rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
             Ekranlabel.Text += "2";
        }

        private void Rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "3";
        }

        private void Rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "4";
        }

        private void Rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "5";
        }

        private void Rakam16button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "6";
        }

        private void Rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "7";
        }

        private void Rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "8";
        }

        private void Rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "9";
        }

        private void Rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenekmi)
            {
                Ekranlabel.Text = "";
                _ekrantemizlenekmi = false;
            }
            if (Ekranlabel.Text == "0") Ekranlabel.Text = "";
            Ekranlabel.Text += "0";
        }

        private void Toplamabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenekmi = true;
            _ilksayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void Esıttırbutton_Click(object sender, EventArgs e)
        {
            int  ikinciSayi = Convert.ToInt32(Ekranlabel.Text);
            int sonuc;

            switch (_islem) 
            
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi; 
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
        
            }
            Ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void Cıkarmabutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenekmi = true;
            _ilksayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void Carpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenekmi = true;
            _ilksayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void Bolmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenekmi = true;
            _ilksayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void Sılmebutton_Click(object sender, EventArgs e)
        {
            Ekranlabel.Text = "0";
        }
    }
}
