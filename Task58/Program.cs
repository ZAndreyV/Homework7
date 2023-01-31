/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] matrix2D = CreatMatrixRndInt(2, 2, 1, 5);
int[,] matrix2D1 = CreatMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrix2D); 
Console.WriteLine(string.Empty);
PrintMatrix(matrix2D1);
Console.WriteLine(string.Empty);
int[,] matrixProduct = MatrixProduct(matrix2D, matrix2D1);
PrintMatrix(matrixProduct);

int[,] CreatMatrixRndInt(int rows, int colomns, int min, int max)
{
    int[,] matr = new int[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matr[i, j], 4}");
        }
        Console.WriteLine(string.Empty);
    }
        
}

int[,] MatrixProduct(int[,] matr1, int[,] matr2)
{
    int[,] matrProd = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matrProd.GetLength(0); i++)
    {
        for (int j = 0; j < matrProd.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            matrProd[i, j] = sum;
        }
    }
    return matrProd;

}

   


