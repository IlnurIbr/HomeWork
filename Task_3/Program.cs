﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"число: {a} - четное");
}
else 
{
    Console.WriteLine($"число: {a} - нечетное");
}


