//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int A = EnterData("Введите число");
int n = 10;
int m = 1;
int S = 0;
      while (A/n > 0)
{
    S = S + A%n/m;
    n = n*10;
    m = m*10;
}
    Console.WriteLine(S+A/m);

//Console.WriteLine(A%10);
//Console.WriteLine(A%100/10);