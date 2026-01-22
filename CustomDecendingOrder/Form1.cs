namespace CustomDecendingOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 28, 41, 44, 52, 82 };
            listBox.DataSource = numbers;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void beforeSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
