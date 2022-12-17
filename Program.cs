// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int CountNumber(int number)
{
    int count = 0;
    for(int i = 0; i < number; i++)
    {
        Console.Write("Input number: ");
        int key = Convert.ToInt32(Console.ReadLine());
        if(key > 0)
        {
            count++;
        }
        else
            count = 0;
    }
    return count;
}
Console.Write("Input count key number: ");
Console.WriteLine($"Input number > 0: user input {CountNumber(Convert.ToInt32(Console.ReadLine()))} positive numbers");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b1 + -b2) / (-k1 + k2);
double y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
bool Intersection(double b1, double k1, double b2, double k2)
{
    if(b1 == b2 && k1 == k2)
    {
        return false;
    }
    else if(b1 == b2)
    {
        return false;
    }
    return true;
}
Console.WriteLine($"Two lines intersect at a point with coordinates: \n\r(X:{x}, Y:{y})\n\rLines intersection: {Intersection(b1, k1, b2, k2)}");
*/