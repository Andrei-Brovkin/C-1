Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки");
int y = Convert.ToInt32(Console.ReadLine());
int quater = Quarter(x, y); 
string result = quater > 0 ? $"Указаны координаты соответствуют четверти -> {quater.ToString()}" : "Введены некотректные координаты";
Console.WriteLine(result);
int Quarter(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}
