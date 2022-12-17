//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Console.Clear();
//int count = 0;
//int[] array = new int[10];
//for (int index = 0; index < 10; index++)
//{
//    array[index] = new Random().Next(100, 999);
//    if (array[index]%2 == 0)
//    {
//        count++;
//    }
//}
//Console.Write($"[{string.Join(",",array)}]");
//Console.Write($" --> {count} четных");
Console.Clear();
int[] NewArray(int amount, int a, int b) 
{
int[] array = new int[amount];
for (int index = 0; index < amount; index++)
{
    array[index] = new Random().Next(a, b);
}
return array;
}

int SumNumber(int[] array)
{
    int count = 0;
for (int index = 0; index < array.Length;  index++)
{
    if (array[index]%2 == 0)
    {
        count++;
    }
}
return count;
}

int [] array = NewArray(10, 100, 999);
Console.Write($"[{string.Join(",",array)}]");
int EvenNumbers = SumNumber(array);
Console.Write($" --> {EvenNumbers} четных в массиве");