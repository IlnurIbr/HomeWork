/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int EnterNumber(string text)
{
    Console.Write(text);
    int m = int.Parse(Console.ReadLine());
    return m;
}

float b1 = EnterNumber("Введите переменную b1: ");
float k1 = EnterNumber("Введите переменную k1: ");
float b2 = EnterNumber("Введите переменную b2: ");
float k2 = EnterNumber("Введите переменную k2: ");

float x = (b2 - b1)/(k1 - k2);
float y = k1 * x + b1;


Console.WriteLine($"({x}; {y})");