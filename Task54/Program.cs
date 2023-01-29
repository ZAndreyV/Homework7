/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] matrix2D = CreatMatrixRndINt(3, 4, 0, 9);
PrintMatrix(matrix2D);
Console.WriteLine("Descending ordered elements of each row:");
SortsElementsOfEachRow(matrix2D);
PrintMatrix(matrix2D);

int[,] CreatMatrixRndINt(int rows, int colomns, int min, int max)
{
    int[,] matr = new int[rows, colomns];
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max +1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 3}");
        }
        Console.WriteLine(string.Empty);
    }
}

void SortsElementsOfEachRow(int[,] matr)
{
    int[,] sortMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int l = 0; l < matr.GetLength(1) - 1; l++)
            {
                if (matr[i, l] < matr[i, l + 1])
                {
                    int temp = matr[i, l];
                    matr[i, l] = matr[i, l + 1];
                    matr[i, l + 1] = temp;
                }
            }
        }  
    }
}

