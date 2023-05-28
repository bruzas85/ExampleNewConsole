// Сортировка вставками
Console.WriteLine("Выводим массив: ");
int[] array = { 5, 10, 3, 16, 1, 32, 9, -4, 7, 45, 12 };
for (int j=0; j<array.Length; j ++)
{
    Console.Write($"{array[j]}, ");
}
Console.WriteLine();
int index; // индекс числа, которое будем менять
int currentNumber; // Текущее число
Console.WriteLine("Выводим currentNumber: ");
for (int i = 0; i < array.Length; i++)
{
    index = i;
    currentNumber = array[i];
    while (index > 0 && currentNumber < array[index - 1]) // идем в обратном порядке и вставляем число на свое место
    {
        Console.Write($"{currentNumber}, ");
        array[index] = array[index - 1];
        index--;
    }
    array[index] = currentNumber;
}
for (int j = 0; j < array.Length; j++)
{
    Console.WriteLine(array[j]);
}