// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[] sumRows = RowsSum(matrixResult);
int minNum = FindMin(sumRows);
int[] minIndexes = FindMinIndexes(sumRows, minNum);

Console.WriteLine($"Минимальная сумма элементов найдена в:");
for (int i = 0; i < sumRows.Length; i++)
{
    if (minIndexes[i] != 0) Console.WriteLine($"{minIndexes[i]} строке");
}
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

int[] RowsSum(int[,] matr)
{
    int[] sum = new int[matrixResult.GetLength(0)];
    int k = 0;
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            sum[k] = sum[k] + matr[i, j];
        }
        k++;
    }
    return sum;
}

int FindMin(int[] arr)
{
    int[] array = new int[arr.Length];
    int minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    return minNum;
}

int[] FindMinIndexes(int[] arr, int min)
{
    int k = 0;
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min)
        {
            array[k] = i + 1;
            k++;
        }
    }

    return array;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
