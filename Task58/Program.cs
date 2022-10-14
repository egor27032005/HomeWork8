int[,] CreateMatrix1 (int row, int col, int min, int max) 
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max) 
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix2;
} 
 
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
int[,] CreateMatrix3 (int row, int col,int [,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i==0 & j==0)
            matrix3[i,j] =matrix1[i,j]*matrix2[i,j]+matrix1[i,j+1]*matrix2[i+1,j];
            else if (i==0 & j==1)
            matrix3[i,j] =matrix1[i,j-1]*matrix2[i,j]+matrix1[i,j]*matrix2[i+1,j];
            else if (i==1 & j==0)
            matrix3[i,j] =matrix1[i,j]*matrix2[i-1,j]+matrix1[i,j+1]*matrix2[i,j];
            else if (i==1 & j==1)
            matrix3[i,j] =matrix1[i,j-1]*matrix2[i-1,j]+matrix1[i,j]*matrix2[i,j];
        }
    }
    return matrix3;
    
}
void PrintMatrix3(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
int[,] matrix1 = CreateMatrix1(2, 2, 0, 9);
int[,] matrix2 = CreateMatrix2(2, 2, 0, 9);
int[,] matrix3 = CreateMatrix3(2,2,matrix1,matrix2);
PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);
Console.WriteLine();
PrintMatrix3(matrix3);
