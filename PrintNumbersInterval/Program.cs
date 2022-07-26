/*
Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = ("Вы ввели не число. Введите корректное число.");
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}
                //функция вывода натуральных чисел:
void NaturNumber(int k, int l)
{
    if (k > l)
    {
        while(l <= k)
        {
            Console.Write($"{l}, ");
            l++;
        }
    }
    else if (k < l)
    {
        while (k <= l)
        {
            Console.Write($"{k}, ");
            k++;
        }
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}
int o = GetNumber("Введите 1-е натуральное число :");
int n = GetNumber("Введите 2-е натуральное число :");
NaturNumber(n, o);
Console.WriteLine();
 