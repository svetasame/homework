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

//задача 47 
int m = Prompt ("Введите количество строк");
int n = Prompt ("Введите количество столбцов");
int [,] array = GenerateTwoArray (m, n);