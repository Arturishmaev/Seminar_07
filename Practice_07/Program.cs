// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.m = 2, n = 3.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
        //System.Console.WriteLine();
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] array = new int [3,4];
FillArray(array);
PrintArray(array);




// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void FillAndPrintArrayDouble(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"{stringArray},{columnArray}");
FillAndPrintArrayDouble(stringArray,columnArray);






// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


int[,] FillAndPrintArrayDouble (int m, int n)
{
    int [,] array = new int[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(1,10);
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int [,] ChangeArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr [i,j] = arr[i,j] * arr[i, j];
        }
    }
    return arr;
}
void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}


int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"{stringArray},{columnArray}");
Console.WriteLine();
int [,] firstArray = FillAndPrintArrayDouble(stringArray,columnArray);
Console.WriteLine();
int [,] secondArray = ChangeArray(firstArray);
PrintArray(secondArray);



// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] FillAndPrintArrayDouble (int m, int n)
{
    int [,] array = new int[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(1,10);
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void SumArray (int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           
           if (i == j)
           {    
            
            sum = sum + arr[i,j];
                       
           }
        }
    }
    Console.WriteLine(sum);
}
int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"{stringArray},{columnArray}");
Console.WriteLine();
int [,] array = FillAndPrintArrayDouble (stringArray, columnArray);
SumArray(array);
