
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
    }
}

string[] testArray = FillArray(GetArray(5));
PrintArray(testArray);
