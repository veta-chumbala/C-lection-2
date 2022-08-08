bool Done = false;
Console.WriteLine("Введите число, которое надо найти:");
        int find = Convert.ToInt32(Console.ReadLine());

void NewArray(int[] RundomArray)
{
    int length = RundomArray.Length;
    int index = 0;
    while (index < length)
    {
        RundomArray[index] = new Random().Next(1, 5);
        index++;
    }
}

void PrintArray(int[] Printed)
{
    int count = Printed.Length;
    int place = 0;
    while (place < count)
    {
        Console.Write($"{Printed[place]} ");
        place++;
    }
}


int IndexOf (int[] RundomArray, int find)
{
    int l = RundomArray.Length;
    int i = 0;
    int position = 0;
    while ( i < l)
    {
        if (RundomArray[i] == find)
        {
            Done = true;
            position = i;
            Console.WriteLine($"Это число является {position + 1} элементом массива");
        }
        i++;
    }
    return position;
}


int[] array = new int[10];
NewArray(array);
PrintArray(array);
Console.WriteLine();

int result = IndexOf(array, find);
Console.WriteLine(Done ? "Больше это число не встречается в массиве" : "Такого числа нет в массиве.");