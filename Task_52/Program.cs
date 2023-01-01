/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

void ArMean(int[,] arr)
{
    
        for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sum = sum + arr[i,j];
        }
        Console.Write($"{Math.Round(sum/arr.GetLength(1),1)} ");
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] NewArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
             array[i,j] = new Random().Next(begin, end);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//*Вводим количество строк и столбцоы массива
int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
//Выводим массив
int[,] matrix = NewArray(rows, columns, 0, 10);
PrintArray(matrix);
//Выводим среднее каждого столбца
Console.WriteLine();
ArMean(matrix);