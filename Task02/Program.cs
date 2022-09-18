Console.Write("введите первое число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number>number1)
{
Console.Write($"{number} больше чем {number1}");
}
else
{
Console.Write($"{number1} больше чем {number}"); 
}

