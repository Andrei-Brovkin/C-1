

int[] array = new int[8];

var r = new Random();

for (int i = 0; i <=array.Length; i++)
    array[i] = r.Next(0,7);


Console.Write($"{array[array.Length]}]");