// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько будет чисел?");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] array = new int[m];

Console.WriteLine("Введите числа:");

for (int i = 0; i < m; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) { sum++; }
}

Console.WriteLine();
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Количество положительных чисел = " + sum);
