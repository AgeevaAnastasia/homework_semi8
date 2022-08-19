// Заполните спирально массив 4 на 4.


Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите число, с которого начнётся спиральное заполнение матрицы: ");
int numUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите шаг заполнения матрицы: ");
int stepUser = Int32.Parse(Console.ReadLine());

Console.Clear();
int[,] matrix = SpiralMatrix(mUser, nUser, numUser, stepUser);
PrintMatrix(matrix);

int[,] SpiralMatrix(int row, int col, int num, int step)
{
    int[,] matrixSpiral = new int[row, col];
    while (row > 0 || col > 0)
    {
        for (int j = matrixSpiral.GetLength(1) - col; j < col; j++)
        {
            if (matrixSpiral[matrixSpiral.GetLength(0) - row, j] == 0)
                matrixSpiral[matrixSpiral.GetLength(0) - row, j] = num;
            num = num + step;
        }
        for (int i = matrixSpiral.GetLength(0) - row + 1; i < row; i++)
        {
            if (matrixSpiral[i, col - 1] == 0)
                matrixSpiral[i, col - 1] = num;
            num = num + step;
        }
        for (int j = col - 2; j >= matrixSpiral.GetLength(1) - col; j--)
        {
            if (matrixSpiral[row - 1, j] == 0) matrixSpiral[row - 1, j] = num;
            num = num + step;
        }
        for (int i = row - 2; i >= matrixSpiral.GetLength(0) - row + 1; i--)
        {
            if (matrixSpiral[i, matrixSpiral.GetLength(1) - col] == 0)
                matrixSpiral[i, matrixSpiral.GetLength(1) - col] = num;
            num = num + step;
        }

        row--;
        col--;
    }

    return matrixSpiral;
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
