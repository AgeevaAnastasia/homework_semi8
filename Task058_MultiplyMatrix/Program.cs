// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк матриц: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матриц: ");
int nUser = Int32.Parse(Console.ReadLine());

Console.Clear();
int[,] matrix1 = GetMatrix(mUser, nUser);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = GetMatrix(mUser, nUser);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrixResult = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(matrixResult);

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

int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matrResult = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matrResult[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
    return matrResult;
}
