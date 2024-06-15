using System;

class Functions
{
    static void Main()
    {

        Console.WriteLine(Add(5, 7));

        Console.WriteLine(CircleArea(3.5));

        Console.WriteLine(StringLength("Hello"));

        Console.WriteLine(MaxValue(new int[] { 1, 3, 5, 7, 9 }));

        Console.WriteLine(Factorial(5));

        Console.WriteLine(IsPalindrome("racecar"));

        int[] mergedArray = MergeArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
        Console.WriteLine(string.Join(", ", mergedArray));

        Console.WriteLine(IsPrime(11));

        Console.WriteLine(ReverseString("Hello"));

        int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        Console.WriteLine(Sum2DArray(array2D));
    }

    // Функция, которая принимает два целых числа и возвращает их сумму
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Функция, которая принимает радиус окружности и возвращает ее площадь
    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Функция, которая принимает строку и возвращает ее длину
    public static int StringLength(string str)
    {
        return str.Length;
    }

    // Функция, которая принимает массив целых чисел и возвращает наибольшее значение в массиве
    public static int MaxValue(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    // Функция, которая принимает число и возвращает его факториал
    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // Функция, которая принимает строку и проверяет, является ли она палиндромом
    public static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Функция, которая принимает два массива целых чисел и возвращает новый массив, содержащий элементы обоих массивов
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        array1.CopyTo(mergedArray, 0);
        array2.CopyTo(mergedArray, array1.Length);
        return mergedArray;
    }

    // Функция, которая принимает число и возвращает true, если оно простое, и false в противном случае
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Функция, которая принимает строку и возвращает ее в обратном порядке
    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Функция, которая принимает двумерный массив чисел и возвращает сумму всех элементов
    public static int Sum2DArray(int[,] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
