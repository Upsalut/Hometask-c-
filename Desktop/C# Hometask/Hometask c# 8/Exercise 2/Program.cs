// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] MinIndexesArray(int[,] matrix)
{
    int[] indexes = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}
int[,] DeleteRowAndColumn(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (i >= row && j < column)
                newMatrix[i, j] = matrix[i + 1, j];
            else if (j >= column && i < row)
                newMatrix[i, j] = matrix[i, j + 1];
            else if (i >= row && j >= column)
                newMatrix[i, j] = matrix[i + 1, j + 1];
            else
                newMatrix[i, j] = matrix[i, j];
        }
    }
    return newMatrix;
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Полученный массив целых чисел:");
PrintArray(matrix);
Console.WriteLine($"Индексы минимального элемента: строка = {MinIndexesArray(matrix)[0] + 1}, столбец = {MinIndexesArray(matrix)[1] + 1}");
Console.WriteLine("Массив после удаления строки и столбца, на пересечении которых расположен наименьший элемент:");
PrintArray(DeleteRowAndColumn(matrix: matrix, row: MinIndexesArray(matrix)[0], column: MinIndexesArray(matrix)[1]));