int[] CreatArrayRandomint( int size, int min, int max)
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


int [] arr = CreatArrayRandomint(999, 100, 999);

int SumEvenNumber(int[] array)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 ==0) result++;
    }
    return result;
}

int ResultMethod = SumEvenNumber(arr);
Printarray(arr);
 Console.WriteLine($"  в массиве колчество четных чисел => {ResultMethod}");


