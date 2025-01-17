﻿
// Перед выполнением кода, очищаем консоль...
Console.Clear();

// Метод для создания строкового массива определенного размера...
string[] GetArray(int size)
{
    Console.Clear();
    string[] newArray = new string[size];
    return newArray;
}

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Введите строковое значение №{i+1}...");
        array[i] = Console.ReadLine()!;
        Console.Clear();
    }
    return array;
}

// Метод для вывода в консоль элементов массива...
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != array.GetLength(0)-1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.Write("]");
}

//Метод проверяет отбирает элементы, в которых кол-во символов меншьше четырёх, и возвращает их количество
int CheckArray(string[] array)
{
    int k = 0;
    foreach (string element in array)
    {
        if (element.Length < 4) k++;
    }
    return k;
}

//Метод заполняет массив modArray элементами из массива  origArray по условию, что длина элемента мееньще 4х символов.
string[] ArrayByCondition (string[] origArray, string[] modArray)
{
    int i = 0;
    foreach (string element in origArray)
    {
        if (element.Length < 4)
        {
            modArray[i] = element;
            i++;
        }
    }
    return modArray;
}

Console.WriteLine("Введите количество строковых элементов...");

int size = int.Parse(Console.ReadLine()!);

string[] originalArray = GetArray(size);

originalArray = FillArray(originalArray);

size = CheckArray(originalArray);

string[] modifiedArray = GetArray(size);

modifiedArray = ArrayByCondition(originalArray, modifiedArray);

PrintArray(originalArray);

Console.Write(" -> ");

PrintArray(modifiedArray);

Console.WriteLine();
