Console.Clear();

string? s = Console.ReadLine(); // знак вопроса ставится ,что бы убрать предупреждение (что мы можем принять null)

Console.WriteLine(Convert.ToInt32(s[0].ToString())); // переводим символ в строку и из строки в число
