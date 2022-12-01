// Усложнил и сделал с циклом.

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
while (n % 2 != 0)
{
	Console.WriteLine($"Число {n} является нечетным!/ Загадайте другое.");
	Console.Write("Введите любое число: ");
	n = int.Parse(Console.ReadLine());
} 
if (n % 2 == 0)
{
	Console.WriteLine($"Это число является четным: {n}");
}


// Простой способ.

/*Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
	Console.WriteLine($"Это число является четным: {n}");
} 
else
{
	Console.WriteLine($"Число {n} является нечетным!/ Загадайте другое.");
}
*/