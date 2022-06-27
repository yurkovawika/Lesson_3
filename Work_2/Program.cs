//Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите три координаты числа A --> ");
double Ax = double.Parse(Console.ReadLine());
double Ay = double.Parse(Console.ReadLine());
double Az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите три координаты числа B --> ");
double Bx = double.Parse(Console.ReadLine());
double By = double.Parse(Console.ReadLine());
double Bz = double.Parse(Console.ReadLine());

double ab = (Math.Pow(Bx - Ax,2)) + (Math.Pow(By - Ay,2)) + (Math.Pow(Bz - Az,2));
double AB = Math.Sqrt(ab);
Console.WriteLine(AB);
