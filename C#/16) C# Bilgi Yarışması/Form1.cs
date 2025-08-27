namespace C__Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru_no = 0, doğru = 0, yanlış = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            label9.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soru_no++;
            label4.Text = soru_no.ToString();




            if (soru_no == 1)
            {
                richTextBox1.Text = "Hasbihal, ne demektir?";
                button1.Text = "Gürültü";
                button2.Text = "Geçmiş";
                button3.Text = "Sohbet";
                button4.Text = "Özlem";
                label8.Text = "Sohbet";
                button5.Text = "Sıradaki";
            }


            if (soru_no == 2)
            {
                richTextBox1.Text = ""Azı dişi" hangisinin eş anlamlısıdır?";
                button1.Text = "Öğütücü diş";
                button2.Text = "Sindirici diş";
                button3.Text = "Koparıcı diş";
                button4.Text = "Kesici diş";
                label8.Text = "Öğütücü diş";
            }


            if (soru_no == 3)
            {
                richTextBox1.Text = ""Mavi, lacivert, mor ve bu renklerin tonları" hangisinin sözlük tanımıdır?";
                button1.Text = "Sıcak renkler";
                button2.Text = " Ilık renkler";
                button3.Text = "Serin renkler";
                button4.Text = "Soğuk renkler";
                label8.Text = "Soğuk renkler";
            }


            if (soru_no == 4)
            {
                richTextBox1.Text = "Türkiye'nin nüfusu en az olan bölgesi hangisidir?";
                button1.Text = "Karadeniz Bölgesi";
                button2.Text = " Ege Bölgesi";
                button3.Text = "Doğu Anadolu Bölgesi";
                button4.Text = "Güneydoğu Anadolu Bölgesi";
                label8.Text = "Doğu Anadolu Bölgesi";
            }


            if (soru_no == 5)
            {
                richTextBox1.Text = "Mars atmosferinde en fazla bulunan gaz hangisidir?";
                button1.Text = " Hidrojen";
                button2.Text = "Azot";
                button3.Text = "Karbondioksit";
                button4.Text = "Oksijen";
                label8.Text = "Azot";
                button5.Text = "Sonuçlar";
            }
            if (soru_no == 6)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                if (doğru < yanlış)
                {
                    label10.Text = "Kaybettiniz!";
                }
                else
                {
                    label10.Text = "Tebrikler, Kazandınız!";
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button1.Text;
            if (label8.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                label9.Text = label8.Text;
                label9.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button2.Text;
            if (label8.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                label9.Text = label8.Text;
                label9.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button3.Text;
            if (label8.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                label9.Text = label8.Text;
                label9.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button4.Text;
            if (label8.Text == label7.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                label9.Text = label8.Text;
                label9.Visible = true;
            }
        }
    }
}
