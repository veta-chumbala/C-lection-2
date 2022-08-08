void NewArray(int[] RundomArray)
{
    int length = RundomArray.Length;
    int index = 0;
    while (index < length)
    {
        RundomArray[index] = new Random().Next(1, 10);
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

int[] array = new int[10];
NewArray(array);
PrintArray(array);