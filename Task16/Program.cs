void checkNum(int num1, int num2)
{
    if(num1 == num2)
        Console.WriteLine($"да");        
    else if(num1 * num1 == num2)
        Console.WriteLine($"да");        
    else if(num2 * num2 == num1)
        Console.WriteLine($"да");        
else
{
    Console.WriteLine($"нет");
}
}

Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
checkNum (num1,num2);


