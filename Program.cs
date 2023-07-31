string[] arrayForTest = new string[] { $"Hello", "2", "world", ":-)" };


void SallestRow(string[] array)
{
    int k = 0;
    for (int i = 0; array.Length > i; i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.WriteLine(array[i] + " ");
        }
        else
        {
            k++;
        }

    }
    if (k== array.Length)
    {
        System.Console.WriteLine("[]");
    }
}

SallestRow(arrayForTest);