/// у меня эта задача не получилась, и я совсем не понимаю, как это исправить
Console.Clear();
double[,] CreateArrayDouble(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd =new Random();
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
        }
    }

    return matrix;

}

void PrintMatrix(double[,] matrix)
{
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        Console.Write("["); 
        for(int j =0; j<matrix.GetLength(0); j++)
        {
            if( j <matrix.GetLength(1)-1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");    
    }
}
    void BubbleSort( double[,] matrix)
    {
        double tmp;
        int t=0;
    while(t<10)/// операцию провожу 10 раз чтобы точно все встали на свои места
    for (int i = 1; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.Length; j++)
            {
            if (matrix[i,j] > matrix[i-1,j])
                {
                tmp = matrix[i,j];
                matrix[i,j] = matrix[i -1,j];
                matrix[i - 1,  j] = tmp;
                t++;
                }
        }
    }
}
void PrintMatrix1(double[,] matrix)
{
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        Console.Write("["); 
        for(int j =0; j<matrix.GetLength(0); j++)
        {
            if( j <matrix.GetLength(1)-1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");    
    }
}
Double[,] array2D=CreateArrayDouble(5, 5, 1, 9);
PrintMatrix(array2D); 
BubbleSort(array2D);
PrintMatrix1(array2D); 
