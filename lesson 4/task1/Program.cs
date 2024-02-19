int[,] matrix = new int[3, 5];


Random rdn = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rdn.Next(1, 11);
    }

}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine($"{matrix[i, j]} ");
    }
}


    int [,] Creatematrix (int rowCount, int columnsCount)
    {
        int[,] matrix = new int[3, 5];

Random rdn = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rdn.Next(1, 11);
    }

    }
        
    