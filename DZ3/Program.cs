/*Задача 3: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Две матрицы можно умножить, если число строк второй матрицы равно числу столбцов первой матрицы. 
При умножении матриц получается матрица, число строк которой равно числу строк первой матрицы, 
а число столбцов равно числу столбцов второй матрицы.*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillRandomMatrix() // наполняем матрицу случайными значениями по заданным параметрам и выводим на экран
{
    int line = Prompt("Укажите количество строк матрицы >- ");
    int column = Prompt("Укажите количество столбцов матрицы >- ");
    int argMin = Prompt("Укажите диапазон значений матрицы: от >- ");
    int argMax = Prompt("до (включительно) >- ");
    int[,] matrix = new int[line, column];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(argMin, argMax);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}


///
int[,] MatrixMultiplication(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    if (A.GetLength(1) == B.GetLength(0))
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                for (int k = 0; k < B.GetLength(0); k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Матрицы не согласованы. Операция умножения матриц невыполнима");
        System.Environment.Exit(001);
    }
        
    return C;
}

    int[,] matrix1 = FillRandomMatrix();
    int[,] matrix2 = FillRandomMatrix();
    PrintMatrix(matrix1);
    System.Console.WriteLine("");
    PrintMatrix(matrix2);
    System.Console.WriteLine("");
    int[,] matrixM = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(matrixM);


