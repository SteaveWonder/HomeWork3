// Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212->нет
// 12821->да
// 23432->да

bool Palindrom(int num)
{
    int tempNum = num;
    int reverseNum = 0;
    while (tempNum > 0)
    {
        int lastNumber = tempNum % 10;
        reverseNum = reverseNum * 10 + lastNumber;
        tempNum = tempNum / 10;
    }
    if (num == reverseNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Palindrom(num) == true)
Console.Write("The number is palindrom!");
else
Console.Write("The number isn't palindrom!");



// // Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A(3(x), 6(y), 8(z)); B(2, 1, -7), -> 15.84
// // A(7, -5, 0); B(1, -1, 9)-> 11.53

// double Length(int x1, int y1, int x2, int y2, int z1, int z2)
// {
//     double segment = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return segment;
// }
// Console.Write("Input X coordinate A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Y coordinate A: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Z coordinate A: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input X coordinate B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Y coordinate B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input Z coordinate B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.Write(Math.Round(Length(x1, y1, x2, y2, z1, z2), 2));




// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125

// void Div(int num)
// {
//     for(int i = 1; i <= num; i++)
//     Console.WriteLine($"{i} - {i * i * i}");
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Div(num);