Console.Clear();

int max1 = 0;
int max2 = 0;
int n = Convert.ToInt32(Console.ReadLine());
while(n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if(n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if(n > max2)
    {
        max2 = n;
    }
}
Console.WriteLine($"Второе максимальное значение = {max2}");