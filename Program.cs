// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите num1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите num2");
int num2 = Convert.ToInt32(Console.ReadLine());
     if(num1==num2)
        {
        Console.WriteLine("Числа равны");
        }
        else if(num1>num2)
        Console.WriteLine(num1);
        else if(num1<num2)
        Console.WriteLine(num2);



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите num1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите num2");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите num3");
int num3 = Convert.ToInt32(Console.ReadLine());

int max;

if(num1>num2)
{
    max=num1;
}
else 
{
    max=num2;
}
if(max<num3)
{
    max=num3;
}
Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2==0)
{
Console.WriteLine("Да");
}
else
{
 Console.WriteLine("Нет");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.Write("Write number 1: ");
//         int n = int.Parse(Console.ReadLine());
//         Console.Write("Write number 2: ");
//         int m = int.Parse(Console.ReadLine());
//         for (int i = n; i <= m; i++)
//         {
//             if (i % 2 == 0) 
//             {
//                 Console.Write(i + " ");
//             }
//         }
//         Console.ReadKey();


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}