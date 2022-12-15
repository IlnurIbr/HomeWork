//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//:√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2.

Console.Clear();
int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}
//Запросить координаты первой точки
int x1 = EnterData("Введите координату Х точки A: ");
int y1 = EnterData("Введите координату Y точки A: ");
int z1 = EnterData("Введите координату Z точки A: ");
int x2 = EnterData("Введите координату Х точки B: ");
int y2 = EnterData("Введите координату Y точки B: ");
int z2 = EnterData("Введите координату Z точки B: ");
//Запросить координаты второй точки
//Высчитываем расстояния между ними
double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
//Console.WriteLine($"{x1}, {y1}, {z1}");
//Console.WriteLine($"{x2}, {y2}, {z2}");
Console.WriteLine(distance);