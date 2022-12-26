/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

void NewArray(int m)
{
    int[] array = new int[m];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterNumber($"Введите число номер {i+1}: ");
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Чисел больше 0: {count}");
}

int EnterNumber(string text)
{
    Console.Write(text);
    int m = int.Parse(Console.ReadLine());
    return m;
}



int m = EnterNumber("Введите количество чисел которое надо проверить: ");
NewArray(m);
 