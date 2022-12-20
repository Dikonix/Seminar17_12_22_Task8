Console.Write("Введите число: ");
int n;

try
{
    n = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число");
    return;
}

int current = 1;

while (current <= n)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current);
    }
    current += 1;
}