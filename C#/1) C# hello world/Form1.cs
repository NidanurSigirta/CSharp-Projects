/* Form tasarımı üzerinde değişiklik yapmak için sağ tuş+özellikler ile
 arka plan rengi için backcolor ,
 yazı tipi için font,text ile adını ve daha birçok şeyi değiştirebiliriz */

namespace C__hello_world   //namespace projenin adını belirtir 
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
            MessageBox.Show("Merhaba Dünya");  // mesajı show(göster) ile yazıyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nidanur";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "Furkan";
            label8.Text = "Yorgun";
            label9.Text = "Computer Engineer";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazılım Mühendisliği";
            // textbox kutusu dışarıdan scanf gibi yazmayı sağlar ama istersek buradan da yazabiliriz
            label11.Text = textBox1.Text;  // label 11 orada kaybolmadı texbox içine aktarıldı ve yazılan değeri aldı
        }
    }
}

// eger ki bir komutun sol tarafında mor küp sembolü varsa o komutun sonunda mutlaka parantez açılıp kapanır 
// onun bir metod olduğunu bilir 
