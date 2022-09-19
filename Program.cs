
string[] StringArrayRead(char ch)
{
    Console.WriteLine($"Введите массив строк, разделяя строки символом \"{ch}\"");
    string result = Console.ReadLine();
    return result.Split(ch);
}

string[] FindElem(string[] arr)
{
    int count = 0;
    foreach (string item in arr)
    {
        if (item.Length < 4) count++;
    }
    if (count == 0) return new string[] {"Нет данных"};

    string[] result = new string[count];

    int resultIndex = 0;
    foreach (string item in arr)
    {
        if (item.Length < 4)
        {
            result[resultIndex] = item;
            resultIndex++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    foreach (string item in arr)
    {
        Console.Write($"{item} ");
    }
}

PrintArray(FindElem(StringArrayRead(';')));