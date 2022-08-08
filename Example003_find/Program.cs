        int[] array = { 29, 402, 64, 74, 25, 78, 25, 402, 84 };
        bool Done = false;
        int n = array.Length;
        Console.WriteLine("Введите число, которое надо найти:");
        int find = Convert.ToInt32(Console.ReadLine());
        int index = 0;


        while (index < n)
        {
            if (array[index] == find)
            {
                Console.WriteLine($"Это число является {index + 1} элементом массива");
                Done = true;
            }
            index += 1;
        }
        Console.WriteLine(Done ? "Больше это число не встречается в массиве" : "Такого числа нет в массиве.");