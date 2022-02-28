{int a, b, c;
Console.WriteLine("Введите три числа : ");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;

if (c > max) max = c;
{
    Console.WriteLine("Максимальное число {0}", max);
}

Console.ReadLine();}