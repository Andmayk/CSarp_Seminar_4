// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message) // запрос целого числа с выводом сообщения
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int Abs(int number) //реализуем модуль числа
{
    if (number < 0) number *= -1;
    return number;
}

double Pow(int numA, int numB) // возведение в степень, double изпользуем для отрицательной степени
{
    double result = 1;

    if (numB == 0 && numA ==0) result = result / numA; // чтобы не получилось, что 0 в степени 0 равно 1   создадинм ошибку 

    for (int i = 0; i <= Abs(numB); i++) // умножаем numA  в цикле numB-раз
    {
        result *= numA;
    }

    if (numB < 0) // считаем отрицательную степень
    {
        result = 1 / result;
    }

    return result;
}

// =========================================

int numberA = ReadInt("Введите число А");
int numberB = ReadInt("Введите число B");

double result = Pow(numberA, numberB);

System.Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
