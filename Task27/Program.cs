Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int Numbersum (int num)
{
    int num1 = num % 10;
    int num2 = num /10 % 10;
    int num3 = num/100 % 10;
    int num4 = num/1000;

    int sum = num1+num2+num3+num4;
    return sum;
} 
int result = Numbersum(number);

Console.WriteLine($"Сумма числа {number} => {result}");
