namespace frmMerge
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Date:12/10/2023
        /// Team:Oscar David Ramoz, Emmanuel Cañas Cartagena
        ///Description: Implementation Merge
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        private void MergeSortButton_Click_1(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string[] inputArray = input.Split(',');
            int[] arrayToSort = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out arrayToSort[i]))
                {
                    MessageBox.Show("Por favor, ingrese números separados por comas.");
                    return;
                }
            }

            MergeSort(arrayToSort, 0, arrayToSort.Length - 1);

            // Mostrar el resultado ordenado en el cuadro de texto de salida
            OutputTextBox.Text = string.Join(",", arrayToSort);
        }

        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int i = 0; i < n2; i++)
            {
                rightArray[i] = arr[mid + 1 + i];
            }

            int j = 0, k = 0;
            int m = left;

            while (j < n1 && k < n2)
            {
                if (leftArray[j] <= rightArray[k])
                {
                    arr[m] = leftArray[j];
                    j++;
                }
                else
                {
                    arr[m] = rightArray[k];
                    k++;
                }
                m++;
            }

            while (j < n1)
            {
                arr[m] = leftArray[j];
                j++;
                m++;
            }

            while (k < n2)
            {
                arr[m] = rightArray[k];
                k++;
                m++;
            }
        }


    }
}