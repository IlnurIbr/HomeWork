﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int A = int.Parse(Console.ReadLine());
if (A%10 == A/10000 || A/1000%10 == A%100/10)
Console.WriteLine($"{A} - является палиндромом");
else
Console.WriteLine($"{A} - не является палиндромом");

//Console.WriteLine($"первая цифра = {A%10}"); 
//Console.WriteLine($"последняя цифра = {A/10000}");
//Console.WriteLine($"вторая цифра = {A/1000%10}"); 
//Console.WriteLine($"предпоследняя цифра = {A%100/10}");