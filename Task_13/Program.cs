// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
void FillArray() {
int[] array = new int[8];
for (int index = 0; index < 8; index++)
{
    array[index] = new Random().Next(0, 100);
}
//for (int index = 0; index < 8; index++)
//{
//Console.Write($"{array[index]}, ");
//}
Console.WriteLine($"[{string.Join(",",array)}]");
}
FillArray();
