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

// Method 4

string Method(int count, string text)
{
    int i = 0;
    string result = String.Empty; // Способ указать пустую строку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    
    return result;
}
string res = Method(text: "На его месте должен был быть я! ", count: 5);
Console.WriteLine(res);
