void FillArray(int[] collection) // collection - это название аргумента, оно может быть любым.
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}
void PrintArray(int[] col) // col - это название аргумента, оно может быть любым.
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);




// VOID метод - это фукнция которая ничего не возвращает и поэтому
// нам не надо использовать в коде слово return.