// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк матриц: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матриц: ");
int nUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент матрицы: ");
int minUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент матрицы: ");
int maxUser = Int32.Parse(Console.ReadLine());

Console.Clear();
int[,] matrixResult = GetMatrix(mUser, nUser, minUser, maxUser);
PrintMatrix(matrixResult);
Console.WriteLine();
RangeMatrix(matrixResult);
PrintMatrix(matrixResult);
Console.WriteLine();



int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j == 0) Console.Write("|");
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}|");
        }
        Console.WriteLine();
    }
}


void RangeMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int m = i; m < matr.GetLength(0); m++)
            {
                for (int n = 0; n < matr.GetLength(1) - 1; n++)
                {
                    if (matr[m, n] < matr[m, n + 1])
                    {
                        int temp = matr[m, n];
                        matr[m, n] = matr[m, n + 1];
                        matr[m, n + 1] = temp;
                    }
                }

            }

        }

    }
}





