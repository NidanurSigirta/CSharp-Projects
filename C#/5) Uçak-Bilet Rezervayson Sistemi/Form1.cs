using System.Windows.Forms;

namespace Uçak_Bilet_Rezervayson_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + " , " + "Tarih: " + dateTimePicker1.Text + " , " + "Saat: " + maskedTextBox1.Text + " , " + "Yolcu Ad-Soyad: " + textBox1.Text + " , " + "TC.: " + maskedTextBox2.Text + " , " + "Telefon: " + maskedTextBox3.Text);

            MessageBox.Show("Yolcu Kaydı Başarıyla Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }
    }
}