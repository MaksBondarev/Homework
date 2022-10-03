# Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число: " );
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: " );
int B = Convert.ToInt32(Console.ReadLine());

int Max = A;

if (A > B) Max = A;
if (A < B) Max = B;

Console.Write("Это число больше: ");
Console.WriteLine(Max);



# Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Clear();

Console.Write("Введите первое число: " );
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: " );
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: " );
int С = Convert.ToInt32(Console.ReadLine());

int Max = A;

if (A > B) Max = A;
if (A < B) Max = B;
if (B < С) Max = С;

Console.Write("Это число больше: ");
Console.WriteLine(Max);



# Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Clear();

Console.Write("Введите число: " );
int A = Convert.ToInt32(Console.ReadLine());

if(A % 2 == 0)
{
Console.Write("Число является четным: " );
Console.WriteLine(A);
}
else
{
Console.Write("Число не является четным: " );
Console.WriteLine(A);
}



# Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();

Console.Write("Введите число: " );
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;

Console.Write("Четные числа: ");

while (B <= A)
{
if(B % 2 == 0)
Console.Write(B + " ");
B++;
}


