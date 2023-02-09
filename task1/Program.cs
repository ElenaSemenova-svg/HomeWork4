// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
        }
    }
return result;
}

int GetDegreeOfNumber(int A, int B)
{
    int multi = 1;
    for (int i = 1; i <= B; i++)
        {
            multi = multi * A;
        }    
    return multi;
}

int A = GetNumber("Введите первое число: ");
int B = GetNumber("Введите второе число: ");
int Multi = GetDegreeOfNumber(A,B);
Console.WriteLine($"Число {A} в степени {B} = {Multi}");

