namespace ArrayCalculationApp
{
    public partial class Form1 : Form
    {

        private int[] numbers;
        private int index;

        public Form1()
        {
            InitializeComponent();
            numbers = new int[5]; 
            index = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < numbers.Length)
                {

                    numbers[index++] = int.Parse(txtNumber.Text);
                    lblNumbers.Text += txtNumber.Text + ", ";
                    txtNumber.Clear();
                }
                else
                {
                    MessageBox.Show("All numbers have already been entered.", "Information");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large.", "Error");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;

            // Mostrar el resultado en un cuadro de diálogo
            MessageBox.Show("The average of the numbers entered is: " + average.ToString("F2"), "Result");
        }
    }
 
}
    
