//Первый вариант решения этой задачи!

int numberA = new Random().Next (1, 10); 
Console.WriteLine($"Первое число: {numberA}");
int numberB = new Random().Next (1, 10);
Console.WriteLine($"Второе число: {numberB}");
if (numberA > numberB) {
	Console.WriteLine($"Результат: {numberA} больше, чем число {numberB}");
}
else {
	Console.WriteLine($"Результат: {numberB} больше, чем число {numberA}");
}


// Второй вариант решения этой задачи!

/*
Console.Write("Введите любое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе любое число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB) {
	Console.WriteLine($"Результат: {numberA} больше, чем число {numberB}");
}
else {
	Console.WriteLine($"Результат: {numberB} больше, чем число {numberA}");
}
*/
