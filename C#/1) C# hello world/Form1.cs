/* Form tasar�m� �zerinde de�i�iklik yapmak i�in sa� tu�+�zellikler ile
 arka plan rengi i�in backcolor ,
 yaz� tipi i�in font,text ile ad�n� ve daha bir�ok �eyi de�i�tirebiliriz */

namespace C__hello_world   //namespace projenin ad�n� belirtir 
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
            MessageBox.Show("Merhaba D�nya");  // mesaj� show(g�ster) ile yaz�yoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nidanur";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "Furki�";
            label8.Text = "Yorgun";
            label9.Text = "Computer Engineer";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yaz�l�m M�hendisli�i";
            // textbox kutusu d��ar�dan scanf gibi yazmay� sa�lar ama istersek buradan da yazabiliriz
            label11.Text = textBox1.Text;  // label 11 orada kaybolmad� texbox i�ine aktar�ld� ve yaz�lan de�eri ald�
        }
    }
}

// eger ki bir komutun sol taraf�nda mor k�p sembol� varsa o komutun sonunda mutlaka parantez a��l�p kapan�r 
// onun bir metod oldu�unu bilir 