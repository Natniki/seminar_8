/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] FindRes(int[,]arrey)
{   
    int[,]myArr= new int [arrey.GetLength(0), arrey.GetLength(1)];
    int temp;
    for (int i = 0; i < arrey.GetLength(1); i++)
    {
        for (int j=i+1; j < arrey.GetLength(1)-1; j++)
        {
            for (int k = 0; k < arrey.GetLength(0); k++)
            {
                if(arrey[i,k]>arrey[j,k])
                {
                temp = arrey[i,k];
                arrey[i,k] = arrey[j,k];
                arrey[j,k] = temp;
                }
            }
        }
    }
    return myArr;
}
    

int[,]array = CreateArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
Console .ReadLine();
int[,] myArr=FindRes(array);
PrintArray(array);
Console.WriteLine();

