// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

void FillArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len)
    {
        arr[i] = new Random().Next(1,100);
        i++;
    }
}

void PrintArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len)
    {
        Console.WriteLine(arr[i]);
        i++;
    }
}

FillArray(array);
PrintArray(array);