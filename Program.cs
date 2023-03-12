// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
// else  if(num1 < num2)
// Console.WriteLine($"Первое число {num1} меньше второго числа {num2}"); 
// else 
// Console.WriteLine($"Первое число {num1} равно второму числу {num2}"); 



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (max < num2)
//     max = num2;
// if (max < num3)
//     max = num3;
// Console.WriteLine($"Максимум равен {max}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 %2 !=0)
//     Console.WriteLine($"Не делится остатка");
// else
//     Console.WriteLine($"Делится без остатка и равно {num1/2}");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 %2 ==0)
//     Console.WriteLine($"Четное");
// else
//     Console.WriteLine($"Нечетное");

// for (int i=2;i<=num1;i=i+2)
//     Console.Write($"{i} ");


// Задача 7 HARD по желанию - идет за 2 необязательных 
// Напишите программу, которая принимает на вход целое число
//  любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Рандомное число ");
int num1 = new Random().Next(1, 100);
Console.WriteLine($"{num1}");
int count = (int)Math.Log10(num1) + 1;
Console.WriteLine($"Разрядность числа {count}");

int number = 10;
int s = count - 2;
int res = number;

if (s == 0)
    res = 1;
else for (int i = 1; i < s; i++)
        res = res * number;
// Console.WriteLine($"10 в степени count-2 {res}");

    num1 = num1 / res % 10;

if (count > 0)
Console.WriteLine($"Вторая цифра слева рандомного числа {num1}");
// if (count = 1)
// Console.WriteLine($"Второй цифры слева рандомного числа нет");



