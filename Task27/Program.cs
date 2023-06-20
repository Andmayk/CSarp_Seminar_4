// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int ReadInt(string message) // запрос целого числа с выводом сообщения
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)  
    {
        sum = sum + num % 10;   // складываем остатки деления на 10
        num /= 10;              // делим на 10 
    }
    return sum;
}

///===============================
int number = ReadInt("Введите число");

Console.WriteLine($"Сумма цифр числа {number} ->  {SumDigits(number)}");
