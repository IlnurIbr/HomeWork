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
    int sum = 0;
for (int index = 0; index < array.Length;  index++)
{
    if (array[index]%2 != 0)
    {
        sum = sum + array[index];
    }
}
return sum;
}

int [] array = NewArray(10, -100, 100);
Console.Write($"[{string.Join(",",array)}]");
int EvenNumbers = SumNumber(array);
Console.Write($" --> {EvenNumbers} сумма нечетных в массиве");