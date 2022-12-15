// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить болоьшими "К"
// а в большие "С" заменить маленькими "с"


string text = "-Я думаю, - сказал князь, улыбаясь, -что,"
					+ "ежели бы вас послали вместо нашего милого";
// string s = "qwerty"
//             0123
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
	string result = String.Empty;

	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if(text[i] == oldValue) 
		result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

// string newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// string newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();