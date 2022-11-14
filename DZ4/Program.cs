/*Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
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


int[,] AddMatrix()
{
    int size = Prompt("Введите размер квадратной матрицы => ");
    int[,] matrix = new int[size, size];
    return matrix;
}

int[,] FillmMatrix(int[,] matrix)
{
    int num = 1;
    int i = 0;
    int j = 0;
    int size = matrix.GetLength(0);
    int max = matrix.GetLength(0) * matrix.GetLength(1);
    while (num <= max)
    {
        while (size > j && num <= max)//4
        {
            matrix[i, j] = num;//0 3 4
            j++;
            num++;
        }
        j = j - 1;
        i = i + 1;
        size = size - 1;

        while (size > i-1 && num <= max)//3
        {
            matrix[i, j] = num; //3 3 7
            i++; //4 3 7
            num++;// 4 3 8
        }
        j = j - 1; // 4 2 8
        i = i - 1; // 3 2 8

        while (0 <= j && num <= max)//3
        {
            matrix[i, j] = num; //3 0 10
            j = j - 1; // 3 -1 10
            num++; // 3 -1 11

        }
        j = j + 1; // 3 0 11
        i = i - 1; // 2 0 11
        size = size - 1;

        while (0 <= i - 1 && num <= max)//2
        {
            matrix[i, j] = num;//1 0 12
            i = i - 1;// 0 0 12
            num++;// 0 0 13

        }
        j = j + 1; // 0 1 13
        i = i + 1; // 1 1 13
        size = size - 1;
    }


    return matrix;

}


int[,] matrix = AddMatrix();
int[,] fillMatrix = FillmMatrix(matrix);
PrintMatrix(fillMatrix);