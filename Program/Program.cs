string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer scince" };
// string[] array = { "Russia", "Denmark", "Kazan" };


void PrintArray(string[] array)
{
	if (array.Length == 0) Console.Write("[]");
	for (int i = 0; i < array.Length; i++)
	{
		if (i == 0) Console.Write("[");
		Console.Write($"\"{array[i]}\"");
		if (i < array.Length - 1) Console.Write(", ");
		else Console.Write("]");
	}
}


string[] NewArray(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
			count++;
	}
	string[] newArray = new string[count];
	int j = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			newArray[j] = array[i];
			j++;
		}
	}
	return newArray;
}

string[] newArray = NewArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);