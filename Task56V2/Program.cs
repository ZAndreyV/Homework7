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
int res = ArrayMinRowSum(matrix2D);
Console.WriteLine($"Row: {res} ");

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

int ArrayMinRowSum(int[,] arr)
{
    int minSum = 0;
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp += arr[i, j];
        }
        if (minSum > temp || i == 0)
        {
            minSum = temp;
            min = i;
        }
    }
    return min;
}