// Сформировать трехмерный массив с не повторяющимися двузначными числами,показать его построчно на экран выводя индексы соответствующего элемента.
void Fill3DArray(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
}
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"Элемент[{i},{j},{k}] = {matrix[i, j, k]} ");
            Console.WriteLine();
        }
}
Console.Write("Введите 1-е измерение массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е измерение массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3-е измерение массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = new int[n, m, k];
if (n * m * k + 9 > 99)
{
    Console.WriteLine($"Невозможно заполнить 3-х мерную матрицу с измерениями {n}, {m}, {k} не повторяющимися двухзначными числами!");
}
Fill3DArray(matrix);
Print3DArray(matrix);