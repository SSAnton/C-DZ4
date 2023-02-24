// Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

int Power (int num, int pow) 
{
    int result = 1;
    for (int i = 0; i<pow; i++) 
    {
        result = result * num;
    }

    return result;
}

int res = Power(number, power);
Console.WriteLine(res);