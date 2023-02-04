// Показать двумерный массив размером m×n заполненный вещественными числами

void FillMas (double[,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(100)/10.0); 
        }
    }
}

void PrintMas(double [,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

    
Console.Write("Введите количество строк массива: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
double [,] array = new double[m, n];

FillMas(array);
PrintMas(array);
