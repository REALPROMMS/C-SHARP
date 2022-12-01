void FillArray(int[] collection) 
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}
void PrintArray(int[] col) 
{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int IndexOf(int[] collection, int find)
{
	int count = collection.Length;
	int index = 0;
	int position = 0; // (-1) ставим , что если такого элемента не будет он покажет -1
	
	while (index < count)
	{
		if(collection[index] == find)
		{
			position = index;
			break; // прерывание команды, что бы нашло 1ю (4ку) в массиве и показала его индекс ,а не последнюю.
		}
		index++;
	}
	return position;
}

int[] array = new int[10];

FillArray(array);
// array[4] = 4; принудительно меняем эти индексы в массиве на 4.
// array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // Если будем искать элемент которого нет (255),
                             // то он выдаст все равно идекс 0, поэтому нужно поменять в position на -1
Console.WriteLine(pos);


