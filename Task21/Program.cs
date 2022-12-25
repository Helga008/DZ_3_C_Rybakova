// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double GetDistance (int userAX, int userAY, int userAZ, int userBX, int userBY, int userBZ)
{
    double result = Math.Sqrt(Math.Pow ((userAX - userBX),2) + Math.Pow((userAY - userBY),2) + Math.Pow((userAZ - userBZ),2));
    return result;
}

int userAX = getUserValue("Введите координаты X первой точки");
int userAY = getUserValue("Введите координаты Y первой точки");
int userAZ = getUserValue("Введите координаты Z первой точки");
int userBX = getUserValue("Введите координаты X первой точки");
int userBY = getUserValue("Введите координаты Y первой точки");
int userBZ = getUserValue("Введите координаты Z первой точки");

double Distance = GetDistance(userAX, userAY, userAZ, userBX, userBY, userBZ);
Console.WriteLine($"Расстояние между точками равно {Distance}");
