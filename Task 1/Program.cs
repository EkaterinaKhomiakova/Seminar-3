// Напишите программу, которая на вход принимает координаты точки (x и y) 
// причем x неравно 0 и y неравно 0 и выдает номер четверти плоскости, 
// в которой находится эта точка
Console.WriteLine("Введите число x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y = ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
  Console.WriteLine(1);
else if (x < 0 && y > 0)
  Console.WriteLine(2);
else if (x < 0 && y < 0)
  Console.WriteLine(3);
else
  Console.WriteLine(4);