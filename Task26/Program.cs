Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());


int Methodcounter( int num)
{
    
    int i = 0;
    while( num>0)
    {
    num = num / 10;
    i++;
    } 
    return i;
}

Console.Write( Methodcounter (number));