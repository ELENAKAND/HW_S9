/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n.
 m = 2, n = 3->A(m, n) = 29
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
        //функция Аккермана:
int FuncAckermann(int n, int m, int count)
{
    count++;
    Console.WriteLine (count);
    if (m == 0)
    {
        return n++;
    }
    else if (n == 0 && m > 0)
    {
        return FuncAckermann(m--, 1, count);
    }
    else 
    {
    return FuncAckermann(m--, FuncAckermann(m, n--, count), count);
    }
}
int o = GetNumber("Введите 1-е натуральное число :");
int p = GetNumber("Введите 2-е натуральное число :");
Console.WriteLine($"Функция Аккермана = {FuncAckermann(o,p, 0)}");
 