/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка. */

int[,] matrix2D = CreatMatrixRndInt(4, 4, 0, 9);
PrintMatrix(matrix2D);
int[] arraySum = SumElementsOfMatrix(matrix2D);
int rowWithTheSmallestSumOfElements = RowWithTheSmallestSumOfElements(arraySum);
Console.WriteLine($"Row: {rowWithTheSmallestSumOfElements} ");


int[,] CreatMatrixRndInt(int rows, int colomns, int min, int max)
{
    int[,] matr = new int[rows,colomns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 2} ");
        }
        Console.WriteLine(string.Empty);
    }
}

int[] SumElementsOfMatrix(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int RowWithTheSmallestSumOfElements(int[] arr)
{

    int index = 0;
    int min = arr[index];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}
