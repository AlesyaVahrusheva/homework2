// Принимает 3 числа и выдает наибольшее
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
Console.Write("Наибольшее число: max = ");

if (b > max)
{
  max=b;  
}
if (c > max)
{
   max=c;  
}

Console.Write(max);

