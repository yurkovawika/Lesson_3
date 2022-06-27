//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число  > ");
int number = int.Parse(Console.ReadLine());
int num_0  = number / 10000;
int num_1  = (number / 1000) % 10;
int num_3  = (number % 100) /10;
int num_4  = number % 10;

if (num_0 == num_4 & num_1 == num_3)
{
    Console.WriteLine("Число является палиндромом");
}

else
{
    Console.WriteLine("Число не палиндром");
}
