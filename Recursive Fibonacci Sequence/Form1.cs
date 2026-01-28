namespace Recursive_Fibonacci_Sequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int n) && n >= 0)
            {
                int result = Fibonacci(n);
                lblResult.Text = $"Fibonacci({n}) = {result}";
            }
            else
            {
                lblResult.Text = "Please enter a valid non-negative integer.";
            }
        }
    }
}
