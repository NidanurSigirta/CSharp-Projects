namespace C__İnt_Değişkenler_Klavyeden_Veri_Girişi
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
            sayi = Convert.ToInt16(textBox1.Text);  // textbox1 den gelen string değeri convert ile
                                                    // -+ 32 bin aralığındaki toint16 ya dönüştürdük

            label2.Text = sayi.ToString();  // sayıyı tekrardan yazdırmak için stringe dönüştürdük
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi_küp, sonuc;
            sayi_küp = Convert.ToInt16(textBox2.Text);
            sonuc = sayi_küp * sayi_küp * sayi_küp;
            label4.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, topla, çıkar, çarp, böl;
            sayı1 = Convert.ToInt16(textBox3.Text);
            sayı2 = Convert.ToInt16(textBox4.Text);
            topla = sayı1 + sayı2;
            çıkar = sayı1 - sayı2;
            çarp = sayı1 * sayı2;
            böl = sayı1 / sayı2;

            MessageBox.Show("Toplam: " + topla + "\n" + "Fark: " + çıkar + "\n" + "Çarpım: " + çarp + "\n" + "Bölüm: " + böl + "\n");
        }
    }
}