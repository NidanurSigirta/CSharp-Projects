namespace C__Öğrenci_Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje, ortalama;
            string durum;

            vize = Convert.ToDouble(textBox2.Text);
            final = Convert.ToDouble(textBox1.Text);
            proje = Convert.ToDouble(textBox3.Text);
            ortalama = Convert.ToDouble((vize + final + proje) / 3);



            if (ortalama < 50)
            {
                durum = "Kaldı";
            }
            else
            {
                durum = "Geçti";
            }
            textBox4.Text = ortalama.ToString("0.00") + " / " + durum;
        }
    }
}