Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;
if (result==0)
{
Console.WriteLine($"число {num1} кратно числу {num2}");
}
else
Console.WriteLine($"число {num1} не кратно числу {num2}, остаток от деления {result}");


