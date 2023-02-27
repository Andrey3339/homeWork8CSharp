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

 void SortRowMatrix(int[,] matrix)
{
  int temp = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
      for (int x = 1; x < matrix.GetLength(1); x++)
      {
        if(matrix[i, x] > matrix[i, x - 1])
        {
            temp = matrix[i, x - 1];
            matrix[i, x - 1] = matrix[i, x];       
            matrix[i, x] = temp;

        }
      }
    }
  }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
SortRowMatrix(matrix);
Console.WriteLine("Отсортированный массив: ");
PrintMatrix(matrix);


