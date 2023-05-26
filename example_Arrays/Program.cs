
// Находим сумму элементов массива
// int[] arr = { 6, 4, 3, 9, 12, 2, 8 };
// int i = 0;
// int sumNumbers = 0;
// while (i < arr.Length)
// {
//     sumNumbers += arr[i];
//     i++;
// }
// Console.Write($"Сумма элементов массива равна: {sumNumbers}");

// Попарная сумма элементов массива

int[] number = { 56, 45, 22, 64, 33, 54, 80, 34 };
int countPairs = number.Length / 2;
int writeNumbers = 0;
for (int j = 0; j < countPairs; j++)
{
    writeNumbers = number[j * 2] + number[j * 2 + 1];
    Console.WriteLine(writeNumbers);
}
