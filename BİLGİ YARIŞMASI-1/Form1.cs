using System;
using System.Drawing;
using System.Windows.Forms;

namespace BİLGİ_YARIŞMASI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renk()
        {
            int r, g, b;
            Random rgb = new Random();

            r = rgb.Next(256);
            g = rgb.Next(256);
            b = rgb.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
        }
        private void temizle()
        {
            richTextBox1.Visible = false;

            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;

            button5.Visible = false;
            button1.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;


            lblsayac.Visible = false;
            lblDogru.Visible = false;
            lblYanlis.Visible = false;
            lblSoru.Visible = false;


            dogrutahmin.Visible = false;
            yanlistahmin.Visible = false;

            dogrutik.Visible = false;
            yanlistik.Visible = false;

            pictureBox1.Visible = false;

            btnCikolata.Visible = true;
            btnSakiz.Visible = true;
            btnCips.Visible = true;
            btnCoco.Visible = true;
            btnYogurt.Visible = true;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label13.Visible = true;

            lblCikoX.Visible = true;
            lblCocoX.Visible = true;
            lblCipsX.Visible = true;
            lblSakizX.Visible = true;
            lblYgrtX.Visible = true;

            lblCikolata.Visible = true;
            lblCocopops.Visible = true;
            lblCips.Visible = true;
            lblSakiz.Visible = true;
            lblYogurt.Visible = true;

            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;

        }

        void odulmekanizma()
        {
            int toplamodul = Convert.ToInt32(lblOdul.Text);
            MessageBox.Show("ÇİKOLATA = 30" + "\n" + "SAKIZ = 5" + "\n" + "CİPS = 1000" + "\n" + "YOĞURT = 500" + "\n" + "COCOPOPS = 700");
        }

        void aktif()
        {

        }


        int soruno = 0, dogru = 0, yanlis = 0, odul = 0, sayac = 30, xciko = 0, xsakiz = 0, xyogurt = 0, xcoco = 0, xcips = 0, sayac2 = 0;

        //label4 = cevap, label5 = tahminim, button5 = başla(sonraki), xciko , xyogurt, xsakiz, xcoco, xcips = ödül sepetine ürün ekleme.

        private void btnB_Click(object sender, EventArgs e)
        {
            label5.Text = btnB.Text;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;

            timer1.Stop();


            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();

                odul += 100;
                lblOdul.Text = odul.ToString();

                dogrutik.Visible = true;
                dogrutahmin.Visible = true;
                this.BackColor = Color.Green;
            }

            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();

                yanlistik.Visible = true;
                yanlistahmin.Visible = true;
                this.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblsayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();

                this.BackColor = Color.Red;
                MessageBox.Show("SÜRENİZ DOLMUŞTUR");

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                button5.Enabled = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            temizle();
            odulmekanizma();
        }

        private void btnCikolata_Click(object sender, EventArgs e)
        {
            if (odul >= 30)
            {
                odul -= 30;
                lblOdul.Text = odul.ToString();


                xciko++;
                lblCikoX.Text = xciko.ToString();
            }

            else
            {
                MessageBox.Show("BU ÖDÜLÜ ALMAK İÇİN PUANIN YETERSİZ!");
            }
        }

        private void btnYogurt_Click(object sender, EventArgs e)
        {
            if (odul >= 500)
            {
                odul -= 500;
                lblOdul.Text = odul.ToString();

                xyogurt++;
                lblYgrtX.Text = xyogurt.ToString();

            }

            else
            {
                MessageBox.Show("BU ÖDÜLÜ ALMAK İÇİN PUANIN YETERSİZ!");
            }
        }

        private void btnCoco_Click(object sender, EventArgs e)
        {
            if (odul >= 700)
            {
                odul -= 700;
                lblOdul.Text = odul.ToString();

                xcoco++;
                lblCocoX.Text = xcoco.ToString();
            }

            else
            {
                MessageBox.Show("BU ÖDÜLÜ ALMAK İÇİN PUANIN YETERSİZ!");
            }

        }

        private void btnCips_Click(object sender, EventArgs e)
        {
            if (odul >= 1000)
            {
                odul -= 1000;
                lblOdul.Text = odul.ToString();

                xcips++;
                lblCipsX.Text = xcips.ToString();
            }

            else
            {
                MessageBox.Show("BU ÖDÜLÜ ALMAK İÇİN PUANIN YETERSİZ!");
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            lblsayac2.Text = sayac2.ToString();
            if (sayac % 1 == 0)
            {
                renk();
            }
        }

        private void btnSakiz_Click(object sender, EventArgs e)
        {
            if (odul >= 5)
            {
                odul -= 5;
                lblOdul.Text = odul.ToString();

                xsakiz++;
                lblSakizX.Text = xsakiz.ToString();
            }

            else
            {
                MessageBox.Show("BU ÖDÜLÜ ALMAK İÇİN PUANIN YETERSİZ!");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;

            timer1.Stop();

            label5.Text = btnC.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();

                odul += 100;
                lblOdul.Text = odul.ToString();

                dogrutik.Visible = true;
                dogrutahmin.Visible = true;
                this.BackColor = Color.Green;
            }

            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();

                yanlistik.Visible = true;
                yanlistahmin.Visible = true;
                this.BackColor = Color.Red;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;

            timer1.Stop();

            label5.Text = btnD.Text;

            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();

                odul += 100;
                lblOdul.Text = odul.ToString();

                dogrutik.Visible = true;
                dogrutahmin.Visible = true;
                this.BackColor = Color.Green;
            }

            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();

                yanlistik.Visible = true;
                yanlistahmin.Visible = true;
                this.BackColor = Color.Red;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;

            timer1.Stop();

            label5.Text = btnA.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();

                odul += 100;
                lblOdul.Text = odul.ToString();

                dogrutik.Visible = true;
                dogrutahmin.Visible = true;
                this.BackColor = Color.Green;
            }

            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();

                yanlistik.Visible = true;
                yanlistahmin.Visible = true;
                this.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "SONRAKİ";

            timer1.Start();

            sayac = 31;

            button5.BackColor = Color.White;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            button5.Enabled = false;

            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;

            dogrutahmin.Visible = false;
            yanlistahmin.Visible = false;

            this.BackColor = Color.White;

            dogrutik.Visible = false;
            yanlistik.Visible = false;

            soruno++;
            lblSoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "JANDARMA ELBİSESİ HANGİ RENKTİR";
                btnA.Text = "LACİVERT";
                btnB.Text = "SİYAH";
                btnC.Text = "KIRMIZI";
                btnD.Text = "MOR";
                label4.Text = "LACİVERT";
            }

            else if (soruno == 2)
            {
                richTextBox1.Text = "BEYZA PRENSES MİDİR";
                btnA.Text = "PRENSESTİR";
                btnB.Text = "DEĞİLDİR";
                btnC.Text = "SAYILIR";
                btnD.Text = "ÇOK GÜZEL PRENSESTİR";
                label4.Text = "ÇOK GÜZEL PRENSESTİR";
            }

            else if (soruno == 3)
            {
                richTextBox1.Text = "TÜRKİYE CUMHURİYETİ KAÇ YILINDA KURULMUŞTUR";
                btnA.Text = "1923";
                btnB.Text = "1922";
                btnC.Text = "1921";
                btnD.Text = "1919";
                label4.Text = "1923";
            }

            else if (soruno == 4)
            {
                richTextBox1.Text = "DOĞUM YILI 2012 OLAN BİRİ KAÇ YAŞINDADIR?";
                btnA.Text = "9";
                btnB.Text = "10";
                btnC.Text = "11";
                btnD.Text = "12";
                label4.Text = "10";
            }

            else if (soruno == 5)
            {
                richTextBox1.Text = "TÜRKİYE CUMHURİYETİNİN AKTİF OLARAK DEVAM EDEN EN ESKİ SPOR KULÜBÜ HANGİSİDİR?";
                btnA.Text = "BEŞİKTAŞ";
                btnB.Text = "BURSA";
                btnC.Text = "FENERBAHÇE";
                btnD.Text = "GALATASARAY";
                label4.Text = "BEŞİKTAŞ";
            }

            else if (soruno == 6)
            {
                richTextBox1.Text = "İSTİKLAL MARŞIMIZI KİM YAZMIŞTIR?";
                btnA.Text = "MEHMET AKİF ERSOY";
                btnB.Text = "MUSTAFA KEMAL ATATÜRK";
                btnC.Text = "SEYİT ONBAŞI";
                btnD.Text = "SAİT FAİK ABASIYANIK";
                label4.Text = "MEHMET AKİF ERSOY";
            }

            else if (soruno == 7)
            {
                richTextBox1.Text = "TÜRKİYEDE EN ÇOK KUPAYA SAHİP OLAN SPOR KULÜBÜ HANGİSİDİR?";
                btnA.Text = "YALOVASPOR";
                btnB.Text = "AKKÖYSPOR";
                btnC.Text = "FENERBAHÇE SK";
                btnD.Text = "BAYBURTSPOR";
                label4.Text = "FENERBAHÇE SK";
            }

            else if (soruno == 8)
            {
                richTextBox1.Text = "10 X 10 KAÇTIR?";
                btnA.Text = "50";
                btnB.Text = "2";
                btnC.Text = "100";
                btnD.Text = "10";
                label4.Text = "100";
            }

            else if (soruno == 9)
            {
                richTextBox1.Text = "TÜRKİYEDE KAÇ TANE DENİZ VARDIR?";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "4";
                label4.Text = "4";
            }

            else if (soruno == 10)
            {
                button5.Text = "BİTİR";
                richTextBox1.Text = "ASKERLER HANGİ RENKTE KAMUFLAJ GİYERLER?";
                btnA.Text = "MOR";
                btnB.Text = "YEŞİL";
                btnC.Text = "SARI";
                btnD.Text = "KIRMIZI";
                label4.Text = "YEŞİL";

                //button5 = sonraki, button1 = ödül butonudur.

            }

            else if (soruno == 11)
            {
                button1.Enabled = true;
                button5.Enabled = false;
                lblSoru.Text = "10";

                richTextBox1.Text = "";
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";
                btnD.Text = "";

                MessageBox.Show("10 SORUDAN;" + "\n" + lblDogru.Text + " DOĞRU" + "\n" + lblYanlis.Text + " YANLIŞ" + "\n" + "KAZANDIĞIN ÖDÜL: " + lblOdul.Text);
            }

        }
    }
}
