//итоговая проверочная работа.
Console.Clear();

void TrexZnachnieChisla(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length != 0)
        {
            array2[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);
    Console.WriteLine($"[{String.Join(", ", array2)}]");
}

Console.WriteLine("Введите данные через пробел и нажмите Enter");
string[] arr = Console.ReadLine().Split(' ').ToArray();
string[] arr2 = new string[arr.Length];

TrexZnachnieChisla(arr, arr2);