Console.Write("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int Max = a;

if(b>a)
{
Max = b;  //Console.Write($"{number} больше чем {number1}");
}
if(c>Max)
{
Max = c;
}
Console.Write($" наибольшее число из трех введеных {Max}");




// else
// {
// Console.Write($"{number1} больше чем {number}"); 
// }