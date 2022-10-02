// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int n)
{
	int res = num;
	for (int i = 1; i < n; i++)
	{
		res *= num;
	}
	return res;
}
int result = Pow(number1,number2);
Console.WriteLine($"{number1},{number2} => {result}");
