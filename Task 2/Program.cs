// Напишите программу, которая по заданному номеру
// четверти показывавает диапозон возможных координат
// точек в этой четверти(x и y)
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.Write(" № = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N == 1)
  Console.WriteLine("x > 0 , y > 0");
else if (N == 2)
  Console.WriteLine("x < 0 , y > 0");
else if (N == 3)
  Console.WriteLine("x < 0 , y < 0");
else
  Console.WriteLine("x > 0 , y < 0");
