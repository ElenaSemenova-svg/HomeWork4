// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void InitArray (int[] array)
{    
    Random rnd = new Random();
    int i = 0;
    int length = array.Length;
    while (i < length)
    {
        array[i] = rnd.Next(0,99);
        i++;
    }
}

void PrintArray(int[] array)//вывод массива
{
    int length=array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int[] array = new int[8];
InitArray(array);
PrintArray(array);

//Console.WriteLine($"[{String.Join("; ", array)}]"); второй вариант вывода массива