
// Находим сумму элементов массива
int[] arr = { 6, 4, 3, 9, 12, 2, 8 };
int i = 0;
int sumNumbers = 0;
while (i < arr.Length)
{
    sumNumbers += arr[i];
    i++;
}
Console.Write($"Сумма элементов массива равна: {sumNumbers}");