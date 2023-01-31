/* *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

Console.WriteLine("Enter size1 of array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size2 of array: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size3 of array: ");
int size3 = Convert.ToInt32(Console.ReadLine());
int twoDigitNumbers = 89;

if (size1 * size2 * size3 > twoDigitNumbers)
{
 Console.WriteLine("Array is too big.");
 return;
}
int[,,] creat3DArray = Create3DArray(size1, size2, size3, twoDigitNumbers);
PrintArray3D(creat3DArray);


int[,,] Create3DArray(int x, int y, int z, int countNumbers)
{
    int[,,] arr = new int[size1, size2, size3];
    int[] values = new int[countNumbers];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = values[valueIndex++];
            }
        }
    }
    return arr;
}
    
void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

