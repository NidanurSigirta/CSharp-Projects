namespace C__String_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "4 Ekim 2023 Cumartesi";
            label1.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label2.Text = sehir;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas, meslek;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox4.Text;

            listBox1.Items.Add(ad + " " + soyad + " " + yas + " " + meslek);
        }
    }
}