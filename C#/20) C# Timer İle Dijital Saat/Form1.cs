namespace C__Timer_İle_Dijital_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;

                if (dakika == 59)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;

                }
            }
        }
    }
}