Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<100 || a >999)
{
    Console.WriteLine("Введите трехзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
int number2 = a/10%10;
Console.WriteLine($"2 цифра = {number2}");
