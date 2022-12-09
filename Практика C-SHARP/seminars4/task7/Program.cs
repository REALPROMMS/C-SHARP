 // task 27

Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= n; i++)
	sum = sum * i;
Console.WriteLine(sum);
