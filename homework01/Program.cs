Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
if(NumberA>NumberB)
{
    Console.WriteLine("Max= " + NumberA + " Min= " + NumberB);
}
else
{
    Console.WriteLine("Max= " + NumberB + " Min=" + NumberA);
}