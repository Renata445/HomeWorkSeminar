Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int proiz = 1;
for(int i = 2; i <= n; i++)
{
    proiz *= i;
}
Console.WriteLine(proiz);