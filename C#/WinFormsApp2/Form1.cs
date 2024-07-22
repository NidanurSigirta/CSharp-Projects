namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            string str1 = "Olmak ya da olmamak, iþte bütün mesele bu!";
            MessageBox.Show(str1.LastIndexOf(" ").ToString());
            MessageBox.Show(str1.LastIndexOf("Z").ToString());
            MessageBox.Show(str1.LastIndexOf("a").ToString());
            MessageBox.Show(str1.LastIndexOf("O").ToString());







        }
    }
}