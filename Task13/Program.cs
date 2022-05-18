Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("Третьей цифры нет ");
else if (a > 99 && a < 1000)
{
    int rez = a % 10;
    Console.WriteLine(rez);
}
else if (a > 999 && a < 10000)
{
    int rez = a / 10 % 10;
    Console.WriteLine(rez);
}
else if (a > 9999 && a < 100000)
{
    int rez = a / 100 % 10;
    Console.WriteLine(rez);
}
else if (a > 99999 && a < 1000000)
{
    int rez = a / 1000 % 10;
    Console.WriteLine(rez);
}
else if (a > 999999 && a < 10000000)
{
    int rez = a / 10000 % 10;
    Console.WriteLine(rez);
}
else Console.WriteLine("Слишком большое число");
