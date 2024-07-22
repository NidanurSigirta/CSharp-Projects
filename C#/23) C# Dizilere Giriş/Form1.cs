namespace C__Dizilere_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kelimeler = { "furkan", "Nida", "Mimoş" };
            label1.Text = kelimeler[0];

            int[] sayilar = { 3, 13, 24, 1, 17 };
            label2.Text = sayilar[4].ToString();

            char[] harfler = {'m','b','f','a','s','n'};
            label3.Text = harfler[5].ToString();
        }
    }
}