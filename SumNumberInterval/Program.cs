/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
void SumNaturNumber(int k, int l, int sum) //функция подсчета суммы 
{
    if (k == l)
        Console.WriteLine($"Сумма равна {sum+k}");
    else
        sum += k;
        SumNaturNumber(k+1, l, sum);
}
int o = GetNumber("Введите 1-е натуральное число :");
int n = GetNumber("Введите 2-е натуральное число :");
int summ = 0;
    if (o > n)
    {
        SumNaturNumber(n, o, summ);
    }
    else
    {
        SumNaturNumber(o, n, summ);
    }
