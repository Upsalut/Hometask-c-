// Найти произведение двух матриц
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
int[,] MultiMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return matrix3;
}
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int i1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int j1 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix1 = new int[i1, j1];
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int i2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int j2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix2 = new int[i2, j2];
if (i1 != j2) 
Console.WriteLine("Невозможно найти произведение матриц т.к. количество строк первой матрицы не равно количеству столбцов второй!");
else if (j1 != i2) 
Console.WriteLine("Невозможно найти произведение матриц т.к.количество столбцов первой матрицы не равно количеству строк второй!");
else
{
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("Матрица 1:");
    PrintArray(matrix1);
    Console.WriteLine("Матрица 2:");
    PrintArray(matrix2);
    Console.WriteLine("Произведение матриц:");
    PrintArray((MultiMatrixes(matrix1, matrix2)));
}