// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMas (int[,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintMas(int [,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void ReplaceEvenValues(int [,]array)
{
    {for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
           array[i,j] = array[i,j]*array[i,j];
        }
    }
}
}


    
Console.Write("Введите количество строк массива: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int[m, n];
FillMas(array);
PrintMas(array);
Console.WriteLine();
ReplaceEvenValues(array);
PrintMas(array);