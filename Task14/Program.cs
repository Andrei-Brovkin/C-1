Console.WriteLine("Введите число, кратность котрого нужно проверить ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int resultmethod = checkNumbers(num1, num2, num3);
if(resultmethod == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("нет");
}

int checkNumbers(int chek_arg, int div_arg1, int div_agr2)
{
    int result = 1;
    if (chek_arg % div_arg1 ==0 && chek_arg % div_agr2 == 0) result = 0;
    return result;
}