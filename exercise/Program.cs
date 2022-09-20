//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями,лучше обойтись исключительно массивами.

List();
string[] array = new string[] {};

string start = ReadInt ("Введите номер массива: ");

switch (start)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{start} - Такой команды нет");
        break;
}

int action = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) action++;
}

string[] secondArray = new string[action];
int index = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[index] = array[i];
        index++;
    }
}

PrintArray(array);
Console.WriteLine();
Console.Write("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
PrintArray(secondArray);


void List()
{
    Console.WriteLine();
    Console.WriteLine("Заданные массивы:");
    Console.WriteLine("1-й массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2-й массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3-й массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}


string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
