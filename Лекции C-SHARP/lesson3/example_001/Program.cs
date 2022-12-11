﻿// Вид 1 ничего не принимает, ничего не возвращает.

void Method1()
{
	Console.WriteLine("Автор...");
}
Method1();

// Вид 2 что-то принимают, ничего не возвращают.

void Method2(string msg)
{
	Console.WriteLine(msg);
}
Method2("Текст сообщения");
// Method2(msg:"Текст сообщения") указываешь каждый аргумент отдельно,
// в  разном порядке.

void Method22(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
		Console.WriteLine(msg);
		i++;
	}
}
Method22("Текст", 4);
// Method22(msg: "Текст", count: 4);

// Вид 3 ничего не принимают, что-то возвращают.

int Method3()
{
	return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 что-то принимают, что-то возвращают.

/* string Method4 (int count, string text)
{
	int i = 0;
	string result = String.Empty;

	while (i < count)
		{
		result = result + text;
		i++;
	   }
	return result;
}

string res = Method1(10, "MMS");
Console.WriteLine(res); */

string Method4 (int count, string text)
{
	string result = String.Empty;
	for (int i = 0; i < count; i++)
		{
		result = result + text;
	   }
	return result;
}

string res = Method4(10, "MMS");
Console.WriteLine(res); 