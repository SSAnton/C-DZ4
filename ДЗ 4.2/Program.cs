// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum (int num) 
{
    int result = 0;

    while (num>0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}

int res = DigitSum(number);
Console.WriteLine(res);