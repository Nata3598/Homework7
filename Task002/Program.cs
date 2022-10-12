// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет


int [,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|");
            Console.Write(array[i, j]);
        }

        Console.WriteLine("|");
    }
  
    Console.WriteLine();
}

// Проверка по позиции элемента

void CheckArray(int row, int column, int [,] array)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) 
    {
        Console.WriteLine(array[row, column]);
    }
    else 
    {
        Console.WriteLine($"[{row + 1}; {column + 1}] -> такого числа в массиве нет");
    }
}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите позицию элемента в строке: ");
int row = int.Parse(Console.ReadLine()!)-1;
Console.Write("Введите позицию элемента в столбце: ");
int column = int.Parse(Console.ReadLine()!)-1;
int[,] array = FillArray(m, n);

PrintArray(array);
CheckArray(row, column, array);


/*Проверка по индексу:

void CheckArray(int row, int column, int [,] array)
{
    
    if (row < array.GetLength(0) && column < array.GetLength(1)) 
    {
        Console.WriteLine(array[row, column]);
    }
    else 
    {
        Console.WriteLine($"[{row}; {column}] -> такого числа в массиве нет");
    }
}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = FillArray(m, n);

PrintArray(array);
CheckArray(row, column, array);*/
