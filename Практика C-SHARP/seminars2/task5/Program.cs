int number = 161;
Console.WriteLine(number);
if (number % 7 == 0 && number % 23 == 0) {
	Console.WriteLine($"да число {number} является кратным 7 и 23");
}
else {
	Console.WriteLine($"нет {number} неявляется кратным 7 и 23");
}

/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0)
{
    if (n % 23 == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
else
    Console.WriteLine("no");
*/
