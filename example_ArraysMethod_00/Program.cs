// Заполняем и выводим массив
void FillArray(int[] array)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
    Console.Write($"{String.Join(", ", array)}");
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
        // Console.Write($"{array[i]} ");
    }

    Console.WriteLine($"{String.Join(", ", array)}");
}

Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
FillArray(array);
Console.WriteLine();
BubbleSort(array);

