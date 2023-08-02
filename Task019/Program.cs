//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine()!);

// Проверяем, является ли число палиндромом
bool isPalindrome = IsPalindrome(number);

// Выводим результат
if (isPalindrome)
{
    Console.WriteLine("Да, это палиндром");
}
else
{
    Console.WriteLine("Нет, это не палиндром");
}

static bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }

    return originalNumber == reversedNumber;
}
