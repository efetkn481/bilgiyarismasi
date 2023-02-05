using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruSayisi.Text = dogru.ToString();
                PicDogru.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisSayisi.Text = yanlis.ToString();
                PicYanlis.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruSayisi.Text = dogru.ToString();
                PicDogru.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisSayisi.Text = yanlis.ToString();
                PicYanlis.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruSayisi.Text = dogru.ToString();
                PicDogru.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisSayisi.Text = yanlis.ToString();
                PicYanlis.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            label5.Text = BtnA.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                LblDogruSayisi.Text = dogru.ToString();
                PicDogru.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisSayisi.Text = yanlis.ToString();
                PicYanlis.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruNo.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1923";
                BtnB.Text = "1924";
                BtnC.Text = "1925";
                BtnD.Text = "1926";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Ege bölgesinde değildir?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Sivas";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Sivas";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Martin Eden kitabının yazarı kimdir?";
                BtnA.Text = "Edgar Allan Poe";
                BtnB.Text = "Dan Brown";
                BtnC.Text = "Fyodor Dostoyevski";
                BtnD.Text = "Jack London";
                label4.Text = "Jack London";
                BtnSonraki.Text = "Sonuçlar";
            }
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;

            BtnSonraki.Enabled = false;

            PicDogru.Visible = false;
            PicYanlis.Visible = false;
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis, "Sonuçlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
