namespace C__Foreach_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0;
            int[] sayilar = { 8, 25, 61, 42, 80, 17, 24, 36, 73, 100 };
            foreach (int i in sayilar)
            {
                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam = toplam + i;
                    label3.Text = listBox1.Items.Count.ToString(); // count ile içerdeki elemmanları saydık
                }
            }
            label4.Text = toplam.ToString();
        }
    }
}