// Заполняем и выводим массив
void FillArray(int[] array)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
    Console.Write($"{String.Join(", ", array)}");
}

int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
FillArray(array);
