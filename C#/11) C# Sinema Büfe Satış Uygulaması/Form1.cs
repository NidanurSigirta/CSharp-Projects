namespace C__Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa_tutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {


            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = misir * 30 + su * 5 + cay * 7 + bilet * 55;
            label11.Text = toplam.ToString() + "TL";

            kasa_tutar = kasa_tutar + toplam;
            label13.Text = kasa_tutar.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // hepsini temizledik ve focuc ile imleci tekrardan en başa mısıra odakladık
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}