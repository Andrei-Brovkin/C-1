Console.WriteLine("Введите номер четверти ");
int quarterNUmb = Convert.ToInt32(Console.ReadLine());
string FindRange(int num)
{
    if( num == 1) return "Диапозон координат находится в пределах от X > 0 и Y > 0";
    if( num == 2) return "Диапозон координат находится в пределах от X < 0 и Y > 0";
    if( num == 3) return "Диапозон координат находится в пределах от X < 0 и Y < 0";
    if( num == 4) return "Диапозон координат находится в пределах от X > 0 и Y < 0";
    return "Введены некорректные значения";
}

string result = FindRange(quarterNUmb);
Console.WriteLine(result);