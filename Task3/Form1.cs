namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFibonacciSequence(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return RecursiveFibonacciSequence(n - 1) + RecursiveFibonacciSequence(n - 2);
        }

        private void btnFibonacciResult_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacciInput.Text);
            int result = RecursiveFibonacciSequence(number);
            lblFibonacciResult.Text = $"Fibonacci: {result}";
        }

        public double RecursivePowerComputation(double baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            if (exponent < 0) return 1 / RecursivePowerComputation(baseNum, -exponent);
            return baseNum * RecursivePowerComputation(baseNum, exponent - 1);
        }

        private void btnPowerResult_Click(object sender, EventArgs e)
        {
            try
            {
                double baseVal = double.Parse(txtBaseInput.Text);
                int expVal = int.Parse(txtExponentInput.Text);
                double result = RecursivePowerComputation(baseVal, expVal);
                lblPowerResult.Text = $"Result: {result}";
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid number");
            }
        }
    }
}
