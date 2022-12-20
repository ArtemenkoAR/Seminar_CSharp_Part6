// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
int M = int.Parse(Console.ReadLine()!);

int Positive(int N)
{
    int a = 0;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int b = int.Parse(Console.ReadLine()!);
        if (b > 0)
            a++;
    }
    return a;
}

int C = Positive(M);
Console.WriteLine(string.Join("", C));
