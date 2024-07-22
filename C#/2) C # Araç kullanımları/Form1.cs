namespace C___Araç_kullanımları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox ile toplu seçim öge seçimi yapabiliyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya"); // butona ne kadar basarsan o kadar yazdığın şehiri ekler

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text); // combobox'a öge ekle ama textbox içine girilen metinden
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aşçı");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + " - " + maskedTextBox2.Text + " - " + maskedTextBox3.Text + " - " + maskedTextBox4.Text);
            // maskedTextBox kalıplaşmış kullanımları daha kolay bir şekilde yazmamızı sağlar
            // (telefon numarası,tc,tarih,saat vb. yazmak için belirtilen özel boşluklar)
        }

        // pictureBox istediğimiz bir fotoğrafı eklememizi sağlar (stretchlmage seçerek resmin tamamını bozmadan yerleştirebiliriz)
        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(dateTimePicker1.Text);
            // dateTimePicker istediğimiz zamanı takvimden seçerek gün ay ve yıl şeklinde yazdırır
        }


    }
}