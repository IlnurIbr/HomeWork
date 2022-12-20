//Задача: перевернуть 
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

int [] array = NewArray(10, -100, 100);
Console.WriteLine($"[{string.Join(",",array)}]");

void ReverseMyArray(int[] array)
{
    for (int index = 0; index < array.Length/2; index++)
    {
        int vp = array [index];
        array[index] = array[array.Length - 1 - index];
        array[array.Length - 1 - index] = vp;
    }
}
ReverseMyArray(array);
Console.WriteLine($"[{string.Join(",",array)}]");

