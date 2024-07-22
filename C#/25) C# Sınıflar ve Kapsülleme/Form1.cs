namespace _25__C__Sınıflar_ve_Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arabaa car = new Arabaa();
            car.renk = "Mavi";
            car.hiz = 120;
            car.motor = 1245.50;
            car.durum = 'S';
            car.fiyat = 500000;
            car.YIL = -2020;
            car.MARKA = "Golf";
            car.plaka = "06 FB 7295";
            car.muayene = 2018;
            car.sahip = "Nidanur Sıgırta";

            label1.Text = car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.durum.ToString();
            label5.Text = car.fiyat.ToString();
            label6.Text = car.YIL.ToString();
            label7.Text = car.MARKA.ToString();
            label8.Text = car.plaka.ToString();
            label9.Text = car.muayene.ToString();
            label10.Text = car.sahip.ToString();
            pictureBox1.BackColor = Color.CadetBlue;

        }
    }
}