//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (без использования Math.Pow).
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int A = EnterData("Введите число: ");
int B = EnterData("Введите в какую степень надо возвести: ");

int n = 0;
int S = 1;
while (n < B)
{
S = A * S;
n++;
}
Console.WriteLine($"{A}^{B} = {S}");
