//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N --> ");
double number = double.Parse(Console.ReadLine());
double count = 1;

while (count <= number)
{
if (number != 0)
{
    Console.Write(Math.Pow(count,3)+" ");
}
    count++;
}