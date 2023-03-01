
void InputMatrix(int[,] matrix)
{
  int number = 1;
  int x = 0;
  int y = 0;
  int size = matrix.GetLength(0);
  for (int i = 0; i < size * size; i++)
  {	
    matrix[x, y] = number;
    if(x <= y + 1 && x + y < size - 1)
      y++;
    else if (x < y && x + y >= size -1)
      x++;
    else if (x >= y && x + y > size - 1)
      y--;
    else
      x--;
    number++;
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j].ToString("00")} \t");
    }
    Console.WriteLine();
  }
}
  

Console.Clear();
Console.WriteLine("Полученный массив 4 на 4: "); 
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
