namespace C__Double_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 64;
            s2 = 70;
            s3 = 69;
            ort = (s1 + s2 + s3) / 3;

            label1.Text = ort.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = sayi.ToString();  // textbox a girdiğimiz double sayıyı nokta ile yazarsak
                                            // noktayı yok sayıp bir bütün olarak yazar o yüzden virgül ile yazmalıyız
        }
    }
}