namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = result.ToString();
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        private int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibonacciInput.Text);
            int result = Fibonacci(n);
            lblFibonacciResult.Text = $"({n})={result}";
        }

        private int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 0;
            if (n == 2) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBaseInput.Text);
            int n = int.Parse(txtExponentInput.Text);
            int result = RecursivePower(x, n);
            lblPowerResult.Text = $"{x}^{n} = {result}";
        }
        private int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);

        }
    }
}
