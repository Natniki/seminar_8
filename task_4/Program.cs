/*
..Сформируйте двумерный массив из неповторяющихся двузначных чисел.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

/*
int [,] CreateArray(int row, int col, int min, int max)  
{
    Random rand = new Random();
    int [,] array = new int [row, col];
    int number = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        array[i, j] = rand.Next(min, max+1);
        number= array[i,j];
        if(i>=1 && i<row)
        {
            while (number==array[i+1, j+1])
            {
                array[i+1, j]=rand.Next(min, max+1);
            }  
        }
    Console.WriteLine(array[i, j]);
        }
    }
    return array;
}
*/
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

int[,] CreatnewArrey(int[,]arrey)
{
    int[,] newArrey = new int [arrey.GetLength(0), arrey.GetLength(1)];
    Random r = new Random();
    for (int i = 0; i <arrey.GetLength(0)-1 ; i++)
    {
        for (int j = 0; j < arrey.GetLength(1)-1; j++)
        {
            int number= arrey[i,j];
            if(arrey[i,j]+1!=number!){
            newArrey[i,j]=arrey[i,j];}
            else{
            newArrey[i,j]=r.Next();}
            number++;; 
        }
           
    }   
    return newArrey;     
}
int[,]array = CreateArray(3, 3, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,]newArray = CreatnewArrey(array);
PrintArray(array);