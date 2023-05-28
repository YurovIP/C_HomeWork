//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string GetNaturalsBetweenMN(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + ", " + GetNaturalsBetweenMN(m + 1, n);
}

System.Console.WriteLine("Значение M= ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Значение N= ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Натуральные числа в заданном промежутке (от M до N): " + GetNaturalsBetweenMN(m, n));
