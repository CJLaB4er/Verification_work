
// Перед выполнением кода, очищаем консоль...
Console.Clear();

// Метод для создания строкового массива определенного размера...
string[] GetArray(int size)
{
    string[] newArray = new string[size];
    return newArray;
}

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Введите строковое значение...");
        array[i] = Console.ReadLine();
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

Console.WriteLine("Введите количество строковых элементов...");

string[] originalArray = FillArray(GetArray(int.Parse(Console.ReadLine()!)));

string[] modifiedArray = FillArray(GetArray(CheckArray(originalArray)));


PrintArray(originalArray);
Console.WriteLine();
PrintArray(modifiedArray);
