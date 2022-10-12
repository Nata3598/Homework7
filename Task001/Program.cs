// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] ArrayCreation(int m, int n)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 18 - 9;
        }
    }

    return array;
}

void WriteArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|");
            
            if (array[i, j] > 0)
            {
                Console.Write(" ");
            }
        
            Console.Write($"{array[i, j]:f1}");
        }
        
        Console.WriteLine("|");
    }
}


Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = ArrayCreation(m, n);
WriteArray(array);