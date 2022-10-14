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
void Сalculations(double [,] matrix)
{
    int n =0;
    double [] arr=new double[matrix.GetLength(0)];
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        double sum =0;
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            sum+= matrix[i, j];
        }
        arr[n]=sum;
        n++;
        
    }
    double minn = arr.Min();
    int t=0;
    while(arr[t]!=minn){
        t++;
    }
    Console.WriteLine("наименьшая сумма элементов в строке " + (t+1));
} 
Double[,] array2D=CreateArrayDouble(3, 3, 0, 9);
PrintMatrix(array2D); 
Сalculations(array2D); 