namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] BubbleSort(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++) { 
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 23, 4, 1, 44, 52, 22 };
            beforeSort.DataSource = numbers;
            listBox.DataSource = BubbleSort(numbers);
        }
    }
}
