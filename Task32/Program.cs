int[] CreatArrayRandomint( int size, int max, int min)
 {int [] array = new int [size];
 var rnd = new Random ();
 for (int i = 0; i < size; i++)
    {
    array [i] = rnd.Next(min, max +1);  
    }
    return array;
 }
void Printarray(int[] array)
{
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
      
    }
    Console.WriteLine("]");
}






void InversArrayElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = -array [i];
    }
}


int [] arr = CreatArrayRandomint(5, -9, 9);
InversArrayElements(arr);
Printarray(arr);
Printarray(arr);
// Console.WriteLine($"{InversArrayElements}");