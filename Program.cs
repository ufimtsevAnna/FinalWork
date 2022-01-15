void FillArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[i] = new Random().Next(1, 11);
        Console.Write($"{matr[i]}");
    }
}
int[] matrix = new int[3];
FillArray(matrix);
