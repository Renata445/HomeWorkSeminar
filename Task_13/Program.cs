Console.Clear();

Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n3 = 0;
if(n > 100)
{
    while(n > 999)
    {
        n = n / 10;
    }
    n3 = n % 10;
    Console.WriteLine(n3);
}

if(n <= 99)
{
    Console.WriteLine("Третьей цифры нет!");
}
