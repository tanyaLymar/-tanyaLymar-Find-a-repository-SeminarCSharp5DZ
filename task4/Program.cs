// В матрице чисел найти сумму элементов главной диагонали

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

    
Console.Write("Введите размерность матрицы: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
int n = m;
int [,] array = new int[m, n];


FillMas(array);
PrintMas(array);
Console.WriteLine();
int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = i;
        sum = sum + array[i,j];
    }

Console.Write($"Сумма значений главной диагонали матрицы равна {sum}.");