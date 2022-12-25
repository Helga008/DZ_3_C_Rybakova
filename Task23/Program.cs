// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number = getUserValue("Введите число: ");

for (int i = 1; i < number; i++)
{
    Console.Write($"{i * i * i}, ");
}
