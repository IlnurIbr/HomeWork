/*Задача 47: Задайте двумерный массив размером mхn заполненный случайными 
вещественными числами*/

void PrintArray(double[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");;
        }
        Console.WriteLine();
    }
    
}

double[,] FillArray(int rows, int columns, double begin, double end)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
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



//Запрос количества строк
int rows = EnterData("Введите количество строк: ");
//Запрос количества столбцов
int columns = EnterData("Введите количество столбцов: ");
//Создаем двумерный массив и заполняем его случайными числами
double[,] matrix = FillArray(rows, columns, 0, 10);
//ВВодим на экран
PrintArray(matrix);