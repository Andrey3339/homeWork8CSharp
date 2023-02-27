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

 void FindMinRowSum(int[,] matrix)
{
  int row = 0;
  int sum = 0;
  int sumrow = 0;
  for (int x = 0; x < matrix.GetLength(1); x++)
  {	
    sum = sum + matrix[0, x];
  }
  //Console.WriteLine("сумма цифр первого ряда равна: " + sum);
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        sumrow = sumrow + matrix[i, j];
    }
  //  Console.WriteLine($"сумма цифр {i} ряда равна: {sumrow}");
    if (sumrow < sum)
    {
        sum = sumrow;
        row = i;    
    }
 }
   Console.WriteLine($"Номер строки {row} с наименьшей суммой {sum} элементов.");
   
  //  for (int y = 0; y < matrix.GetLength(1); y++)
  //   {	
  //       Console.Write($"{matrix[row, y]} \t");
  //   }
    
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
FindMinRowSum(matrix);




