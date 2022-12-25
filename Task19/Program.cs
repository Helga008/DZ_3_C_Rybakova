// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

void Palindrom(int number)
{
    if (number >= 10000)
    {
        int num1 = number / 10000;
        int num5 = number % 10;
            if (num1 == num5)
            {
                int number_new = number / 10;
                int num2 = (number_new / 100) % 10;
                int num3 = number_new % 10;    
                if (num2 == num3)
                    Console.Write($"Число {number} является палиндромом");
            }        
            else
                Console.WriteLine($"Число {number} не является палиндромом");
    }        
    else
        Console.WriteLine("Число не является пятизначным");
}

Palindrom(number);