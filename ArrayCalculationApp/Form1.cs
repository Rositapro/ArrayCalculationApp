
namespace ArrayCalculationApp
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        private int[,] matrix;
        private int[,,] cube;
        private int index;

        public Form1()
        {
            InitializeComponent();
            numbers = new int[5];
            matrix = new int[3, 3]; // Matriz 3x3
            cube = new int[3, 3, 3]; // Cubo 3x3x3
            index = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tu código actual para agregar números a 'numbers'...

            // Agregar números a 'matrix' y 'cube'
            try
            {
                if (index < numbers.Length)
                {
                    numbers[index++] = int.Parse(txtNumber.Text);
                    lblNumbers.Text += txtNumber.Text + ", ";
                    txtNumber.Clear();

                    // Agregar números a la matriz 3x3
                    // Por simplicidad, supongamos que 'index' se usa para agregar números a cada elemento de la matriz
                    matrix[index / 3, index % 3] = numbers[index - 1];

                    // Agregar números al cubo 3x3x3
                    // De manera similar, supongamos que 'index' se usa para agregar números a cada elemento del cubo
                    cube[index / 9, (index / 3) % 3, index % 3] = numbers[index - 1];
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
            // Tu código actual para calcular el promedio de 'numbers'...

            // Calcular suma de todos los elementos en la matriz 3x3
            int sumMatrix = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumMatrix += matrix[i, j];
                }
            }

            // Calcular suma de todos los elementos en el cubo 3x3x3
            int sumCube = 0;
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        sumCube += cube[i, j, k];
                    }
                }
            }

            // Aquí puedes mostrar las sumas de la matriz y el cubo en un MessageBox o donde prefieras
            MessageBox.Show("Sum of elements in the matrix: " + sumMatrix + "\nSum of elements in the cube: " + sumCube, "Result");

        }
    }
}