﻿
//Находим сумму элементов массива

int[] arr = { 6, 4, 3, 9, 12, 2, 8 };
int i = 0;
int sumNumbers = 0;
while (i < arr.Length)
{
    sumNumbers += arr[i];
    i++;
}
Console.Write($"Сумма элементов массива равна: {sumNumbers}");

//Попарная сумма элементов массива

int[] number = { 56, 45, 22, 64, 33, 54, 80, 34 };
int countPairs = number.Length / 2;
int writeNumbers = 0;
for (int j = 0; j < countPairs; j++)
{
    writeNumbers = number[j * 2] + number[j * 2 + 1];
    Console.WriteLine(writeNumbers);
}

// Сравнение элементов двух массивов

int[] array1 = { 56, 45, 12, 98, 5, 24 };
int[] array2 = { 34, 54, 60, 12, 3, 15 };
for (int j = 0; j < array1.Length; j++)
{
    if (array1[j] > array2[j])
    {
        Console.WriteLine($"число массива array1 больше");
    }
    else
    {
        Console.WriteLine($"число массива array2 больше");
    }

}