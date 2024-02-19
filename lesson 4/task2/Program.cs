//Создать двумерный массив, состоящий из целых чисел. Вывестина экран "интереснеы" элементы массива
int[,] CreateMatrix(int rowCount, int colomsCount)
{
    int[,] matrix = new int[rowCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        System.Console.WriteLine($"{e} ");
    }
}

bool IsInteresting(int value)
{
    int sumofDigits = GetSumofDigits(value);
    if (sumofDigits % 2 == 0)
    {
        return true;
    }
    else

    {
        return false;
    }

}

int GetSumofDigits (int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /=10;
    }
    return sum;
}
