int[, ,] CreateMatrix (int row, int col, int depth, int min, int max) 
{
    int[, ,] matrix = new int[row, col,depth];
    Random rnd = new Random();
    int n=10;   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[i,j,l] = n+ rnd.Next(min, max +1);
            n=n+7;
        }
        }
    }
    return matrix;
} 
 
void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
           for (int l = 0; l < matrix.GetLength(1); l++)
        {
             if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j, l], 1}({i},{j},{l})");
            else Console.Write($"{matrix[i, j, l], 1}({i},{j},{l})");
        }
        }
        Console.WriteLine(" ");        
    }        
}
 
int[, ,] matrix = CreateMatrix(2, 2, 2, 0, 6);
PrintMatrix(matrix);
 

        