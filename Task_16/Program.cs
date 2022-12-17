Console.Clear();
double[] NewArray(int amount, int a, int b) 
{
double[] array = new double[amount];
for (int index = 0; index < amount; index++)
{
    array[index] = new Random().Next(a, b);
}
return array;
}

double Max(double[] array)
{
   double max = array[0];
   for (int index = 1; index < array.Length;  index++)
{
    if (array[index] > max)
    {
        max = array[index];
    }
}
return max;
}

double Min(double[] array)
{
    double min = array[0];
for (int index = 0; index < array.Length;  index++)
{
    if (array[index] < min)
    {
        min = array[index];
    }
}
return min;
}

double [] array = NewArray(10, -10, 10);
Console.Write($"[{string.Join(",",array)}]");
double DiffMaxMin = Max(array) - Min(array);
Console.Write($" --> {DiffMaxMin} разница между максимальным и минимальным элементом");
