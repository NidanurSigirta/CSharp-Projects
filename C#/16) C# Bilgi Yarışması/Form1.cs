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
                richTextBox1.Text = "Bana ilk çıkma teklifi ettiğin gün nedir <3 <3 ?";
                button1.Text = "1 Aralık";
                button2.Text = "24 Ekim";
                button3.Text = "3 Kasım";
                button4.Text = "14 Aralık";
                label8.Text = "3 Kasım";
                button5.Text = "Sıradaki";
            }


            if (soru_no == 2)
            {
                richTextBox1.Text = "Annemin gençlik soyadı nedir :):) ?";
                button1.Text = "Ergenç";
                button2.Text = "Günsur";
                button3.Text = "Demir";
                button4.Text = "Sıgırta";
                label8.Text = "Ergenç";
            }


            if (soru_no == 3)
            {
                richTextBox1.Text = "Sevgili olduğumuz gün nedir :o :o ?";
                button1.Text = "1 Ocak";
                button2.Text = "12 Şubat";
                button3.Text = "27 Şubat";
                button4.Text = "17 Mart";
                label8.Text = "17 Mart";
            }


            if (soru_no == 4)
            {
                richTextBox1.Text = "Benim en sevdiğim renk ;) ?";
                button1.Text = "Mor";
                button2.Text = "Siyah";
                button3.Text = "Kırmızı";
                button4.Text = "Sarı";
                label8.Text = "Hepsi";
            }


            if (soru_no == 5)
            {
                richTextBox1.Text = "Benimle tanıştığın ilk gün hangi renk şal örtmüştüm ^-^ ?";
                button1.Text = " Lacivert";
                button2.Text = "Kahverengi";
                button3.Text = "Siyah";
                button4.Text = "Pembe";
                label8.Text = "Kahverengi";
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
                    label10.Text = "Sevgilinizi tanımıyorsunuz size yazıklar olsun." + " \n" +
                        " Hemen bir çikolata alarak gönlünü alın!!";
                }
                else
                {
                    label10.Text = "Tebrikler sevgilinizi tanıyorsunuz." + " \n" +
                        "Ama bu ona çikolata almayacağınız anlamına gelmez" + " \n" +
                        "Onu her an mutlu edin :)";
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