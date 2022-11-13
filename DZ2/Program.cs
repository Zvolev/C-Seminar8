/* 
Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillRandomMatrix(int line, int column, int argMin, int argMax) // наполняем матрицу случайными значениями по заданным параметрам и выводим на экран
{
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

int SumElementRowMatrix(int[,] matr, int row)
{
    int sumElementRow = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sumElementRow = sumElementRow + matr[row, j];
    }
    return sumElementRow;
}

(int, int) MinSumElementRowMatrix(int[,] matr)
{
    int numRow = 0;
    int minSum = SumElementRowMatrix(matr, 0);
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int sumElementRow = SumElementRowMatrix(matr, i);
        if (minSum > sumElementRow)
        {
            minSum = sumElementRow;
            numRow = i;
        }
    }
    return (minSum, numRow);
}


int line = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");
int min = Prompt("Укажите диапазон значений матрицы: от >- ");
int max = Prompt("до (включительно) >- ");
int[,] matrix = FillRandomMatrix(line, column, min, max + 1);
PrintMatrix(matrix);
(int minSumRow, int numRow) = MinSumElementRowMatrix(matrix);
System.Console.WriteLine($"{numRow+1} cтрока с наименьшей суммой элементов => {minSumRow}");
