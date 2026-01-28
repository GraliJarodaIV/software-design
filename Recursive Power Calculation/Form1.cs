namespace Recursive_Power_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long Power(int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * Power(baseNum, exponent - 1);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(txtBase.Text);
            int exponent = int.Parse(txtExponent.Text);
            long result = Power(baseNum, exponent);
            lblResult.Text = $"Result: {result}";
        }
    }
}
