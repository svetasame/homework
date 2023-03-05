static int Prompt (string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int [,] GenerateTwoArray (int rows, int columns)
{
int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
    System.Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        matrix [i, j] = new Random().Next(-10,11);
    System.Console.Write(matrix [i, j] + " ");
    }
}
return matrix;
}

void CheckNumberinArray(int number, int[,] array)
{
  int count = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == number)
      {
        System.Console.WriteLine
        ($"{number} находится на позиции [{i},{j}]");
        count++;
      }
    }
  }
  if (count == 0)
  {
    System.Console.WriteLine
    (number + " такого числа в массиве нет");
  }
}

//задача 47 
//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// int m = Prompt ("Введите количество строк");
// int n = Prompt ("Введите количество столбцов");
// int [,] array = GenerateTwoArray (m, n);

// задача 50 
//Напишите программу, которая на вход принимает 
//значение в двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
//элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int m = Prompt ("Введите количество строк");
int n = Prompt ("Введите количество столбцов");
int [,] array = GenerateTwoArray (m, n);
System.Console.WriteLine();
System.Console.WriteLine();
int num = Prompt ("Введите число для проверки");
CheckNumberinArray (num, array);