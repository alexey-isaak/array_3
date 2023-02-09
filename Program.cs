int array_length = 100;

int[] array_3 = new int[array_length];
for (int i=0;i<array_length;i++)
{
    Random random = new Random();
    int a = random.Next(100, 999);
    array_3[i] = a;
}

int even_count = 0;
int odd_count = 0;
for (int i=0;i<array_length;i++)
{
    if (array_3[i] % 2 == 0)
    {
        even_count = even_count + 1;
    }
    else
    {
        odd_count = odd_count + 1;
    }
}

Console.WriteLine("Количество четных чисел: " + even_count);
Console.WriteLine("Количество нечетных чисел: " + odd_count);