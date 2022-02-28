{int a, b;
Console.WriteLine("Введите два числа : ");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Минимальное число {0}", a);

}
else
{
    Console.WriteLine("Максимальное число {0}", b);
}
Console.ReadLine();}