// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

double [,] FillArray(int r, int c)
{
    double[,] array = new double[r, c];

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i, j] = new Random().NextDouble() * 9;
        }
    }

    return array;
}

void PrintArrayTwo(double[,] array)
{
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            Console.Write("|");
            Console.Write($"{array[i, j]:f1}");;
        }
        
        Console.WriteLine("|");
    }
    
    Console.WriteLine();
}

double[] AvgColArray(double [,] array)
{
    double[] result = new double [array.GetLength(1)];
    
    for (int c = 0; c < array.GetLength(1); c++)
    {
        double sum = 0; 
        
        for (int r = 0; r < array.GetLength(0); r++)
        {
            sum += array[r,c];
        }
        
        result[c] = sum/array.GetLength(0);
    }
    
    return result;
}

void PrintArrayOne(double[] result)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        
        Console.Write("|");
        Console.Write($"{result[i]:F1}");
    }

    Console.WriteLine("|");
}

Console.Write("Введите r: ");
int r = int.Parse(Console.ReadLine()!);
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double [,] array = FillArray(r, c);
double[] result = AvgColArray(array);
PrintArrayTwo(array);
PrintArrayOne(result);