// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string message) // функция чтения целого числа
    {
        System.Console.Write(message);
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
bool Validate5sign(int number) // функция на истинность данных
    {
        if (number >= 10000 && number < 100000) // нам нужно  пятизначное число
        {
        return true;
        }
    System.Console.WriteLine("Число не пятизначное!");
    return false;
    }

int num = ReadInt("Введите пятизначное число: "); // запускаем функцию
if(Validate5sign(num))
    {
        int fiveDigit = num % 10; // находим пятую цифру
        int fourDigit = num / 10 % 10; // находим четвертую цифру
        int secondDigit = num / 1000 % 10; // находим вторую цифру
        int firstDigit = num / 10000 % 10; // находим первую цифру

        if (fiveDigit == firstDigit && fourDigit == secondDigit) // проверяем условие, что пятая цифра равна первой, а четвертая - второй
        {
            System.Console.WriteLine($"Число {num} является палиндромом");     
        }
        else
            System.Console.WriteLine($"Число {num} не является палиндромом");
    }    

