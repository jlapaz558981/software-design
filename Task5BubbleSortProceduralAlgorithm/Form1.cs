namespace Task5BubbleSortProceduralAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4, 6 };
            int[] sortedNumbers = BubbleSort(numbers);
            listBox1.DataSource = sortedNumbers;
        }
    }
}
