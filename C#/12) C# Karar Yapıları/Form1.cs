namespace C__Karar_Yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "nida")
            {
                label1.Text = "doğru";
            }
            else
            {
                label1.Text = "yanlış";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);
            if (sayi == 5)
            {
                label2.Text = "doğru";
            }
            else
            {
                label2.Text = "yanlış";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox5.Text);
            if (sayi % 2 == 0)
            {
                label5.Text = "çift";
            }
            else
            {
                label5.Text = "tek";
            }
        }
    }
}