Console.Clear();
int[] ArrayCreatore(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
} 

int[] array = ArrayCreatore(5, 1, 9);
Console.WriteLine (String.Join(", ", array));