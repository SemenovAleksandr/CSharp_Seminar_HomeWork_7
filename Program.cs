//Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
// {
//     int[,] matrix = new int[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(m, n, 0, 10);

// PrintMatrix(resultMatrix);



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i+j;
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(m, n);

// PrintMatrix(resultMatrix);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
// {
//     int[,] matrix = new int[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(m, n, 0 , 10);

// PrintMatrix(resultMatrix);
// Console.WriteLine();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i %2 == 0 && j %2 == 0) resultMatrix[i, j] *= resultMatrix[i, j];
//         Console.Write(resultMatrix[i,j]+ "\t");
//     }
//     Console.WriteLine();
// }



// Задача 51: Найдите сумму элементов главной диагонали. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
// {
//     int[,] matrix = new int[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultMatrix = GetMatrix(m, n, 0 , 10);

// PrintMatrix(resultMatrix);

// int GetSumDiagonal (int [,] matrix)
// {
//     int sum = 0;
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i == j) sum += matrix[i,j];
//         }
//     }
//     return sum;
// } 

// Console.WriteLine($"Сумма элементов главной диагонали равна: {GetSumDiagonal(resultMatrix)}");

// Домашнее задание

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] GetMatrix(int m, int n)
// {
//     double [,] matrix = new double[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble()*10 - new Random().NextDouble()*10, 1);
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] resultMatrix = GetMatrix(m, n);

// PrintMatrix(resultMatrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Задайте кол-во строк массива m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте кол-во столбцов массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] GetMatrix(int m, int n)
// {
//     double [,] matrix = new double[m,n];
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble()*10 - new Random().NextDouble()*10, 1);
//         }
//      }
//     return matrix;
// }

// void PrintMatrix (double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] resultMatrix = GetMatrix(m, n);

// PrintMatrix(resultMatrix);

// Console.Write("Задайте номер строки: ");
// int numRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте номер столбца: ");
// int numColumn = Convert.ToInt32(Console.ReadLine());
// double element = resultMatrix[numRows-1, numColumn-1];

// if (numRows > m | numColumn > n) Console.WriteLine("В массиве отсутствует указанный элемент");
// else Console.WriteLine($"На позиции {numRows},{numColumn} находится элемент со значением: {element}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Задайте кол-во строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте кол-во столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m,n];
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
     }
    return matrix;
}

void PrintMatrix (int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(m, n, 0 , 10);

PrintMatrix(resultMatrix);



double[] GetAvgColumns (int [,] matrix)
{
    int sumColum =0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
   
    double[] avgArray = new double[columns];
   
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sumColum = sumColum + matrix[j, i];
        }
        
        avgArray[i] = Math.Round((double)sumColum/rows,1);
        sumColum=0;
    }
    return avgArray;
} 


double [] avgColumns = GetAvgColumns(resultMatrix);

Console.WriteLine("Среднее арифметическое элементов в столбцах:");

for (int i = 0; i < avgColumns.Length; i++)
        {
            Console.Write(avgColumns[i] + "\t");
        }

