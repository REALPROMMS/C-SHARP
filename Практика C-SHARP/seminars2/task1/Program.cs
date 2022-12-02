Console.Clear();

int n = new Random().Next(10, 100); // [begin, end+1] [10, 99]
Console.WriteLine($"Случайное число {n}");
int n1 = n / 10; // кол-во десятков
int n2 = n % 10; // кол-во единиц
if (n1 > n2)
	Console.WriteLine(n1);
else
	Console.WriteLine(n2);