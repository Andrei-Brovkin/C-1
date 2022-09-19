int  Fmetod(int number)
{
    int first_number = (number / 100) *10;
    int secondnumber = number %10;
    int result = first_number +secondnumber;
    return result;
}


int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенирированое число {num}");
int bigresult = Fmetod(num);
Console.WriteLine($"число после работы метода {bigresult}");
 


