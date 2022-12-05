Console.WriteLine("Введите день недели, что бы определить Рабочий это день или Выхондой");
int dayWeek = int.Parse(Console.ReadLine());
	
if (dayWeek > 0 && dayWeek < 8)
    {
        if (dayWeek == 7 || dayWeek == 6)
        {
            Console.Write($"Под цифрой {dayWeek} - Выходной");
        }
        else
        {
            Console.Write($"Под цифрой {dayWeek} - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }	

		// int dayWeek;
		// string result;

		// Console.WriteLine("Введите день недели, что бы определить Рабочий это день или Выхондой");
		// dayWeek = int.Parse(Console.ReadLine());

      //       switch (dayWeek)
      //       {
      //           case 1:
      //               result = "Понедельник";
      //               Console.WriteLine($"{result} это рабочий день недели");
      //               break;
      //           case 2:
      //               result = "Вторник";
      //               Console.WriteLine($"{result} это рабочий день недели");
      //               break;
      //           case 3:
      //               result = "Среда";
      //               Console.WriteLine($"{result} это рабочий день недели");
      //               break;
      //           case 4:
      //               result = "Четверг";
      //               Console.WriteLine($"{result} это рабочий день недели");
      //               break;
      //           case 5:
      //               result = "Пятница";
      //               Console.WriteLine($"{result} это рабочий день недели");
      //               break;
      //           case 6:
      //               result = "Суббота";
      //               Console.WriteLine($"{result} это выходной день недели");
      //               break;
      //           case 7:
      //               result = "Воскресенье";
      //               Console.WriteLine($"{result} это выходной день недели");
      //               break;
		// 		}
		

		// Задача 15: Напишите программу, которая принимает на вход цифру, 
		// обозначающую день недели, и проверяет, является ли этот день выходным.