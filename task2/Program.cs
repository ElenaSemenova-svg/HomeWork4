// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
         if (int.TryParse(Console.ReadLine(), out result) && result !=0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели ноль или не число");
        }
    }
    return result;
}

int GetSumOfDigit(int number)
{
    int sum = 0;
    while (number !=0)
    {
    sum = sum + number%10;
    number = number/10;
    }
    return sum;
}

int number = GetNumber("Введите число ");
int sum = GetSumOfDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");