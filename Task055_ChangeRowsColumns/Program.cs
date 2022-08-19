// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());

int[,] matrixResult = GetMatrix(mUser, nUser);
PrintMatrix(matrixResult);
Console.WriteLine();
if (mUser != nUser) Console.WriteLine("Заменить строки столбцами невозможно, количество элементов в строках и столбцах не равно");
else
{
    ChangeRowColumn(matrixResult);
    PrintMatrix(matrixResult);
    Console.WriteLine();
}

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

void ChangeRowColumn(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix1.GetLength(1); j++)
        {
            int temp = matrix1[i, j];
            matrix1[i, j] = matrix1[j, i];
            matrix1[j, i] = temp;
        }
    }
}
