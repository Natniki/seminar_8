/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int [,] CreateArray(int row, int col, int min, int max)  
{
    Random rand = new Random();
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        array[i, j] = rand.Next(min, max+1);    
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        Console.Write($"{array[i,j]}\t");
        }
    Console.WriteLine();
    }
}

int[,] MultiArrey(int [,]arrey, int [,]arrey2)
{
    int [,] arrey3 = new int [arrey.GetLength(0), arrey.GetLength(1)];
    for (int i = 0; i < arrey.GetLength(0);i ++)
    {
        for (int j = 0; j < arrey2.GetLength(1); j++)
        {
            for (int k = 0; k < arrey2.GetLength(0); k++)
            {
            arrey3[i,j] += arrey [i,k] * arrey2[k,j];
            }
            
        }
        Console.WriteLine();;
    }
    return arrey3;
}

int [,]arrey = CreateArray(2, 2, 0, 9);
PrintArray(arrey);
Console.ReadLine();
int [,]arrey2 = CreateArray(2, 2, 0, 9);
PrintArray(arrey2);
Console.ReadLine();
int [,] arrey3 = MultiArrey(arrey, arrey2);
PrintArray(arrey3);

