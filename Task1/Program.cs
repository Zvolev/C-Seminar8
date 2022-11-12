/*Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/

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

int[,] SwapElementMatrix(int[,] matr)
{
    int typeElement = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        typeElement = matr[0, i];
        matr[0,i] = matr[(matr.GetLength(0)-1),i];
        matr[(matr.GetLength(0)-1),i] = typeElement;
    }



    return matr;
}

int line = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");
int min = Prompt("Укажите диапазон значений матрицы: от >- ");
int max = Prompt("до (включительно) >- ");
int[,] matrix = FillRandomMatrix(line, column, min, max + 1);
PrintMatrix(matrix);
int[,] matr = SwapElementMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);

