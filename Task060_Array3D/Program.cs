// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
Console.Write("Введите первый размер трёхмерного масива: ");
int aUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите второй размер трёхмерного масива: ");
int bUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите третий размер трёхмерного масива: ");
int cUser = Int32.Parse(Console.ReadLine());

Console.Clear();
int[,,] array3D = Get3DArray(aUser, bUser, cUser);
PrintArray3D(array3D);





int[,,] Get3DArray(int a, int b, int c)
{
    Random rnd = new Random();
    // int n = rnd.Next(10, 13);
    int n = 10;
    int[,,] array3dnew = new int[a, b, c];
    for (int i = 0; i < array3dnew.GetLength(0); i++)
    {
        for (int j = 0; j < array3dnew.GetLength(1); j++)
        {
            for (int k = 0; k < array3dnew.GetLength(2); k++)
            {
                array3dnew[i, j, k] = n;
                // n = n + rnd.Next(1, 4);
                n++;
                // if (n > 99) n = rnd.Next(13,16);
            }
        }
    }
    return array3dnew;
}

void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (k == arr.GetLength(2) - 1) Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})");
                else Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}), ");
            }
            Console.WriteLine();
        }

    }
}

