// Сортировка вставками

int[] array = { 5, 10, 3, 16, 1, 32, 9, -4, 7, 45, 12 };
int index;
int currentNumber; // Текущее число
for (int i = 0; i < array.Length; i++)
{
    index = i;
    currentNumber = array[i];
    while (index > 0 && currentNumber < array[index - 1])
    {
        array[index] = array[index - 1];
        index--;
    }
    array[index] = currentNumber;
}
for (int j = 0; j < array.Length; j++)
{
    Console.WriteLine(array[j]);
}