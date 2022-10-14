   Console.Clear();
double[,] CreateArrayDouble()
{
    double[,] matrix = new double[4, 4];
    double n=1;
    double m=12;
    double k=10;
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j =0; j<matrix.GetLength(1); j++)
        {
            if (i==0 || j==3){
                matrix[i, j]=n;
                n++;
            }
            if (i==3){
                matrix[i, j]=k;
                k--;
            }
            if (i==1 && j!=3){
                matrix[i, j]=m;
                m++;
            }
            if (i==2 && j==0)
                matrix[i, j]=11;
            if (i==2 && j==1)
                matrix[i, j]=16;
            if (i==2 && j==2)
                matrix[i, j]=15;
        }
    }

    return matrix;

}

void PrintMatrix(double[,] matrix)
{
    for (int i =0; i<matrix.GetLength(0); i++)
    {
         
        for(int j =0; j<matrix.GetLength(0); j++)
        {
            if(matrix[i, j]<10)
            if( j <matrix.GetLength(1)-1) Console.Write($"0{matrix[i,j]} ");
            else Console.Write($"0{matrix[i, j]}");
            else {
            if( j <matrix.GetLength(1)-1) Console.Write($"{matrix[i,j]} ");
            else Console.Write($"{matrix[i, j]}");
            }
        }
        Console.WriteLine();    
    }
}
Double[,] array2D=CreateArrayDouble();
PrintMatrix(array2D);