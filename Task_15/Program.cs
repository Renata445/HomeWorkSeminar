Console.Clear();

Console.WriteLine("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");