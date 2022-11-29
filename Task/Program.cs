string[] GetSplitArray(string array)
{
    string[] massive = array.Split(",");
    return massive;
}

void GetPrint(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string GetThreeElements(string[] massive)
{

    string massive2 = "";
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            massive2+= massive[i] + " ";
        }

    }

    return massive2;
}

Console.Clear();
Console.WriteLine("Введите массив, состоящий из слов или цифр, через запятую: ");
string array = Console.ReadLine();
Console.WriteLine("Массив: ");
string[] massive = GetSplitArray(array);
GetPrint(massive);
Console.WriteLine();
string massive2 = GetThreeElements(massive);
string[] massive3= GetSplitArray(massive2);
Console.WriteLine("Длина меньше или равна трем символам: ");
GetPrint(massive3);
Console.WriteLine();




