namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int hours) && int.TryParse(textBox2.Text, out int minutes) && int.TryParse(textBox3.Text, out int seconds))
            {
                int totalSeconds = hours * 3600 + minutes * 60 + seconds;
                MessageBox.Show($"Секунды с полуночи: {totalSeconds}");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные в поля!");
            }
        }
    }
}