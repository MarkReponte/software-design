namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            int[] data = { 3, 1, 5, 2, 8, 4, 6, 7, 10, 9 };

            int[] sorted = (int[])data.Clone();
            BubbleSort(sorted);

            listBoxResults.Items.Add("Sorted: " + string.Join(", ", sorted));
        }

        private static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
