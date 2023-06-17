// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message) // функция чтения целого числа
    {
        System.Console.Write(message);
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

int number_N = ReadInt("Введите число: ");

for (int i = 1; i <= number_N; i++) // Цикл возводит в третью степень все числа от 1 до N
    {
    int result = i*i*i;
    Console.WriteLine(result);
    }