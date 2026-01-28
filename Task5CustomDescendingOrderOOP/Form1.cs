using System.Windows.Forms;

namespace Task5CustomDescendingOrderOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 8, 2, 4, 6, 9 };


            ArraySorter sorter = new ArraySorter();
            int[] sortedNumbers = sorter.SortDescending(numbers);
            listBox1.DataSource = sortedNumbers;
        }

        public class ArraySorter
        {
            public int[] SortDescending(int[] numbers)
            {
                int n = numbers.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    bool swapped = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
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
        }
    }
}
