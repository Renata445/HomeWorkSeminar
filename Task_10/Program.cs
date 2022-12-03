Console.Clear();

Console.WriteLine("Введите 3-ех значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = (n % 100)/10;
Console.WriteLine($"Второе число = {n2}");
