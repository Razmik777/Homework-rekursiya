//Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumber(int n)
// {
//     if (n == 1)
//     {
//         System.Console.WriteLine(n);
//     }else
//     {
//         System.Console.Write(n + ", ");
//         ShowNumber(n -1);
//     }
// }
// ShowNumber(5);



// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else
//     {
//         return m + FindSum(m + 1, n);
//     }
// }

// Console.WriteLine("Enter the value of M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the value of N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = FindSum(M, N);
// Console.WriteLine("The sum of natural numbers in the range from " + M + " to " + N + " is: " + sum);



//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return AkkermanFunction(m - 1, 1);
//     }
//     else
//     {
//         return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     }
// }

// Console.WriteLine("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Функция Аккермана равна {AkkermanFunction(m, n)} ");