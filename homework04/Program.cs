Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= Number)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current);
        current++;
    }
    else
    {
        current++;
    }
}