// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Привет, дружище!");
Console.WriteLine("Сколько элементов проверим?");
int n = Convert.ToInt32(Console.ReadLine());//длина массива

string[] arrayValues = new string[n];
Console.WriteLine("Вводи элементы через Enter ");
for (int i = 0; i < n; i++)
{
    string m = Console.ReadLine()!;
    arrayValues[i] = m;
}

string[] array3Symbol = new string[n];
int length = 3;
int k = 0;
for (int i = 0; i < n; i++)
{
    if (arrayValues[i].Length <= length)
    {
        array3Symbol[k] = arrayValues[i]; k++;
    }
}

Console.WriteLine("_________________");
Console.WriteLine("Начальный ряд данных:");
PrintArray(arrayValues);
Console.WriteLine("Итоговый ряд данных:");
PrintArray(array3Symbol);
Console.WriteLine("Счастливо! Кушай имбирь, - не болей короновирусом ;)");

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("_________________");
}