/* *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Write("Enter size1 of array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter size2 of array: ");
int size2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(string.Empty);

if (size1 != size2)
{
    Console.WriteLine("Index was outside the bounds of the array.");
    return;
}
int[,] sqareMatrix = CreatMatrixRndInt(size1, size2);
PrintMatrix(sqareMatrix);


int[,] CreatMatrixRndInt(int rows, int colomns)
{
    int[,] matr = new int[rows, colomns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matr;
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
