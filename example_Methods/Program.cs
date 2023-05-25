Console.Clear();
// Method 1

void author() // Ничего не принимает, ничего не возвращает
{
    Console.WriteLine("I'm author this massege...");
}
author();


// Method 2

void userName(int a, string text) // Принимает, ничего не возвращает
{
    int i = 0;
    while (i < a)
    {
        Console.WriteLine(text);
        i++;
    }
}
userName(text: "Какой-то текст...", a: 5);

// Method 3

int MethodTime() // Ничего не принимает, возвращает.
{
    return DateTime.Now.Year;
}
int year = MethodTime();
Console.WriteLine(year);