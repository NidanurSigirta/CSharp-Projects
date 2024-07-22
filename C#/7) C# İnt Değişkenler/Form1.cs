namespace C__İnt_Değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 24;
            label1.Text = sayi.ToString(); //sayi int olduğu için ToSring metodu ile string ifaedeye çevirip yazdırıyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;
            label2.Text = toplam.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int alan, cevre, kisa_kenar, uzun_kenar;
            kisa_kenar = 10;
            uzun_kenar = 20;
            alan = kisa_kenar * uzun_kenar;
            cevre = 2 * (uzun_kenar + kisa_kenar);

            label3.Text = "Alan: " + alan + " Çevre: " + cevre;  // başta string kullanımı yaptığımız için int kısımları
                                                                 // ToString metodu ile stringe çevirmeye gerek kalmadı

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, proje, ortalama;
            sinav1 = 98;
            sinav2 = 85;
            proje = 100;
            ortalama = (sinav1 + sinav2 + proje) / 3;
            label4.Text = "Ortalama: " + ortalama;
        }
    }
}