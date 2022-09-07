
Console.WriteLine("Введите значение K1 ");
double K1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1 ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение K2 ");
double K2  = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
double b2  = double.Parse(Console.ReadLine());
double a = (K1- K2);
double b = (b2 -  b1);
double x = (b/a);
double y = K1*x + b1;
Console.WriteLine("("+x+";"+y+")");