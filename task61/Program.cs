
// //Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод 
// в виде равнобедренного треугольника

// void InputMatrix(int[,,] matrix)
// {
//   int num = 10;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int x = 0; x < matrix.GetLength(2); x++)
//         {
//             matrix[i, j, x] = num;
//             num++;
//         }
//     }
//   }
// }

// void PrintMatrix(int[,,] matrix)
// {
//   int count = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {	
//         for (int x = 0; x < matrix.GetLength(2); x++)
//         {
//             Console.Write($"{matrix[i, j, x]} \t");
//             count++;
//             if (count % 10 == 0)
//                 Console.WriteLine();
//         }
//     }
//   }
// }

// void PrintMatrix2(int[,,] matrix)
// {
//   int count = 0;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {	
//         for (int x = 0; x < matrix.GetLength(2); x++)
//         {
//             Console.Write($"{matrix[i, j, x]}({j},{x},{i}) \t");
//             count++;
//             if (count % 5 == 0)
//                 Console.WriteLine();
//         }
//     }
//   }
// }

// Console.Clear();
// Console.WriteLine("Введите размер трехмерного массива, суммарное"); 
// Console.Write("количество элементов которого не больше 90: ");
// int[] m = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,,] matrix = new int[m[0], m[1], m[2]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine("Результат:");
// PrintMatrix2(matrix);


int Fact(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    
    return x;
}

void Pascal(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Fact(i) / (Fact(j) * Fact(i - j)));
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
Pascal(n);
