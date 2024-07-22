namespace C__Alışveriş_İndirim_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap_adet;
            double tutar;

            kitap_adet = Convert.ToInt16(textBox1.Text);
           // kitap_fiyat = 75;
         
            if (kitap_adet >= 0 && kitap_adet <= 20)
            {
                tutar = (kitap_adet * 75) - (kitap_adet * 75 * 0.20);
                label3.Text = tutar.ToString() +" TL";
            }
            if (kitap_adet >= 21 && kitap_adet <= 40)
            {
                tutar = (kitap_adet * 75) - (kitap_adet * 75 * 0.40);
                label3.Text = tutar.ToString() + " TL";
            }
            if (kitap_adet >= 41)
            {
                tutar = (kitap_adet * 75) - (kitap_adet * 75 * 0.50);
                label3.Text = tutar.ToString() + " TL";
            }

        }
    }
}