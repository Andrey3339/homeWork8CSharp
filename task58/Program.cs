void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

int[,] MatrixProd(int[,] matrix1, int[,] matrix2)
{
  int mres = matrix1.GetLength(0);
  int mres2 = matrix1.GetLength(1);
  int[,] result = new int[mres, mres];
  int temp = 0;
  for (int i = 0; i < mres; i++)
  {
    for (int j = 0; j < mres; j++)
    {	
      for (int x = 0; x < mres2; x++)
      {
            temp = temp + matrix1[i, x] * matrix2[x, j];       
      }
      result[i, j] = temp;
      temp = 0;
    }
  }
  return result;
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] m1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[m1[0], m1[1]];
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine($"Размер второй матрицы будет равен: {m1[1]} на {m1[0]}");
int[,] matrix2 = new int[m1[1], m1[0]];
InputMatrix(matrix2);
PrintMatrix(matrix2);
int[,] martixResult = new int[m1[0], m1[0]];
martixResult =  MatrixProd(matrix1, matrix2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(martixResult);


