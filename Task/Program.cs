Console.Write("Введите количество элементов массива: ");
int index = Convert.ToInt32(Console.ReadLine());



string[] InitArray(int index)
{
    string[] array = new string[index];
    Console.WriteLine("Ввод содержимого массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент номер {i+1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

string[] NewArray(string[] array)
{   
    int n = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            n++;
        }
    }
    string[] newarray = new string[n];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[k] = array[i];
            k++;
        }
    }
    return newarray;
}


string[] array = InitArray(index);
Console.Write("Ваш массив: [");
Print(array);
Console.Write("]");
string[] newarray = NewArray(array);
Console.WriteLine();
Console.Write("Массив с длинной символов <= 3: [");
Print(newarray);
Console.Write("]");

