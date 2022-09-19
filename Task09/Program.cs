// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// вывести результат
// 78 -> 8
// 12-> 2
// 85 -> 8




// int number = new Random().Next(10,100);
// // Console.WriteLine($"случайное число из отрезка 10-99 => {number}");
// // int firstDigit = number / 10;
// // int SecondDigit = number % 10;

// // if (firstDigit==SecondDigit) System.Console.WriteLine("цифры ровны");
// // if(firstDigit>SecondDigit) Console.WriteLine($" наибольшая цифра {number}=> {firstDigit}");
// // else  Console.WriteLine ($" наибольшая цифра {number}=> {SecondDigit}");


// // int maxDigit =0;
// // if (firstDigit>SecondDigit) maxDigit= firstDigit;
// // else maxDigit = SecondDigit;

// // int max = firstDigit> SecondDigit ? firstDigit : SecondDigit;


// int MaxDigit(int num) 
// {
//     int firstDigit = num / 10;
//     int SecondDigit = num % 10;

//     // if(firstDigit>SecondDigit)  return firstDigit;
//     // return SecondDigit; 
//     if(IsEqualDigits(firstDigit==SecondDigit)) return -1;   
//     return firstDigit> SecondDigit ? firstDigit : SecondDigit;
// }

// bool IsEqualDigits(int num1, int num2)
// {
// return num1 == num2;
// }


// int maxDigit = MaxDigit(number);
// int result = maxDigit != -1 ? maxDigit.ToString(): "значения одинаковые";
// Console.WriteLine ($" наибольшая цифра {number}=> {result}");




int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if(IsEqualDigits(firstDigit, secondDigit)) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Cлучайное число из отрезка 10 - 99 => {number}");

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString(): "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
