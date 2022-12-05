
Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
while (number < 99 || number > 1000)
 {
	Console.WriteLine("Данное число неявляется трёхзначным! Загадайте другое.");
	Console.WriteLine("Введите любое число: ");
	number = int.Parse(Console.ReadLine());
 }
 if (number >= 100 && number <= 999)
 {
		Console.WriteLine(number % 10);
 }

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК