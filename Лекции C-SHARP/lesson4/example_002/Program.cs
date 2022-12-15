double Factorial(int n) // поставили double  потому что в int , после 17! идет уже минусовые числа так как не 		вмещают в себя так много чисел!
{

	// 1! = 1
	// 0! = 1
	if (n == 1)
		return 1;
	else  
		return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
	Console.WriteLine($"{i}! = { Factorial(i)}");
}

