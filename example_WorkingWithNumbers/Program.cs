// Округляем числа при делении стандартным методом

int firstNumber = 57;
int secondNumber = 9;
int firstResult, secondResult, thirdResult;
float result;

firstResult = firstNumber / secondNumber; // Делим первое число на второе
secondResult = (firstNumber - secondNumber * firstResult) * 10 / secondNumber; // (17 - 6 * 2) * 10 / 6 = 8
thirdResult = (((firstNumber - secondNumber * firstResult) * 10) - secondResult * secondNumber) * 10 / secondNumber;
if (firstResult >= 5)
{
    if (secondResult < 9)
    {
        secondResult++;
    }
    else
    {
        firstResult++;
        secondResult = 0;
    }
}
result = Convert.ToSingle(firstResult) + Convert.ToSingle(secondResult) / 10;
Console.Write(result);

// Округляем числа при делении встроенной функцией Math.Round

int firstNumber = 77;
int secondNumber = 9;
double result;
result = Math.Round(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber), 3);
Console.Write(result);