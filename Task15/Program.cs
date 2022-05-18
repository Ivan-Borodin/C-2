Console.WriteLine("Введите цифру от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Введите цифру от 1 до 7: ");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(a == 6 || a == 7 ? "да" : "нет");