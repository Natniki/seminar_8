
/*
 прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3Задайте
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[]CheckMatrix(int[,]arrey)
{
    int [] arr = new int [arrey.GetLength(0)];
    int size = arrey.GetLength(0);
    for (int i = 0; i < arrey.GetLength(0); i++)
    {int sum = 0;
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            sum += arrey[i,j];
            arr[i] = sum;
        }
    }
//Console.WriteLine(string.Join(", ", arr));
    return arr;
}

void FindMinEl(int[]arrey)
{
    int min= arrey[0];
    int size = arrey.Length;
    int indexMinEl =0;
    for (int i = 1; i < size; i++)
    {
        if(min > arrey[i])
        { min=arrey[i];
        indexMinEl =i;
        }
    } 
Console.WriteLine("Minimalnaia summa elementov v stroke : " + (indexMinEl));
}

int[,]array = CreateArray(3, 4, 0, 99);
PrintArray(array);
Console.WriteLine();
int[]arr = CheckMatrix(array);
Console.WriteLine();

FindMinEl(arr);
Console.WriteLine();
