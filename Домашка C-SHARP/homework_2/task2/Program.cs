
/* Console.WriteLine("Введите любое число");
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
 } */

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК


// для себя решение оставил ,а так я сократил несколько строк кода не нужных ))

/* Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int numberA = number;

if (number < 99)
    {
        Console.Write($" В числе {number} третьей цифры нет");
		  Console.WriteLine("Введите любое число: ");
		  number = int.Parse(Console.ReadLine());
    }
    else
    {
         if (number >= 100 && number <= 999)
			{
		  	Console.WriteLine($"Третья цифра в числе {number} , будет {number % 10}");
			}
			else
			{
				while (number > 999)
					number = number / 10;
					Console.WriteLine($"Третья цифра в числе {numberA} , будет {number % 10}");
			}
    }
 */
 
// Вводим число больше 999 , то с помощью цикла делим на 10 до тех пор , 
// пока не будет число меньше 999, а после выводим остаток с помощью оператора %

Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int numberA = number;

while (number < 99)
    {
        Console.WriteLine($"В числе {number} третьей цифры нет");
		  Console.WriteLine("Введите любое число: ");
		  number = int.Parse(Console.ReadLine());
    }
    {
         if (number >= 100 && number <= 999)
			{
		  	Console.WriteLine($"Третья цифра в числе {number} , будет {number % 10}");
			}
			else
			{
				while (number > 999)
					number = number / 10;
					Console.WriteLine($"Третья цифра в числе {numberA} , будет {number % 10}");
			}
    }
