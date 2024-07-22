/* Form tasarýmý üzerinde deðiþiklik yapmak için sað tuþ+özellikler ile
 arka plan rengi için backcolor ,
 yazý tipi için font,text ile adýný ve daha birçok þeyi deðiþtirebiliriz */

namespace C__hello_world   //namespace projenin adýný belirtir 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");  // mesajý show(göster) ile yazýyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nidanur";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "Furkiþ";
            label8.Text = "Yorgun";
            label9.Text = "Computer Engineer";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazýlým Mühendisliði";
            // textbox kutusu dýþarýdan scanf gibi yazmayý saðlar ama istersek buradan da yazabiliriz
            label11.Text = textBox1.Text;  // label 11 orada kaybolmadý texbox içine aktarýldý ve yazýlan deðeri aldý
        }
    }
}

// eger ki bir komutun sol tarafýnda mor küp sembolü varsa o komutun sonunda mutlaka parantez açýlýp kapanýr 
// onun bir metod olduðunu bilir 