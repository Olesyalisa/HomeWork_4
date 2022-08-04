/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
452 -> 11 
82 -> 10 
9012 -> 12 */ 
 
Console.WriteLine("Введите число: "); 
int number = int.Parse(Console.ReadLine()); 
int res = 0; 
 
Console.WriteLine(sumNumbers(res)); 
int sumNumbers (int sum) 
{ 
    while (number > 0) 
    {  
        res += number % 10; 
        number = number /10; 
    } 
    return res; 
}
