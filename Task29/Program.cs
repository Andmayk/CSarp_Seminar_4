// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string message) // запрос целого числа с выводом сообщения
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr, int rangLeft, int rangRight)
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(rangLeft, rangRight);
    }
}
void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}

///===================================

int sizeArray = ReadInt("Введите размер массива: ");
int rangLeft = 1;  // ReadInt("Введите размер массива: ");
int rangRight = 100;  // ReadInt("Введите размер массива: ");

int[] array = new int[sizeArray];

FillArray(array, rangLeft, rangRight);
PrintArray(array);
