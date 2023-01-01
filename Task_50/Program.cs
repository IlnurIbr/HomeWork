/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

void SearchPosition(int[,] New, int x, int y)
{
    if (x > New.GetLength(0) && y > New.GetLength(1))
            {
                 Console.WriteLine($"позиция[{x},{y}] такого числа нет");
            }

        for (int i = 0; i < New.GetLength(0); i++)
        {
            for (int j = 0; j < New.GetLength(1); j++)
            {
            if (x-1 == i && y-1 == j)
            {                         
                Console.WriteLine($"Это число: {New[i,j]}");
            }
            }
        }
    }

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
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



//Заправшиваем количество столбцов и строк
int rows = EnterData("Введите количество строк масива: ");
int columns = EnterData("Введите количество столбцов масива: ");
//Задаем двумерный массив из случайных чисел mxn
int[,] matrix = NewArray(rows, columns, 0, 10);
//Выводим массив на экран
PrintArray(matrix);
//Запрашиваем позицию
int x = EnterData("Введите позицию строки: ");
int y = EnterData("Введите позицию столбца: ");
//Проверяем на наличие в массиве
SearchPosition(matrix, x, y);
