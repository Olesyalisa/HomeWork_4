/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
3, 5 -> 243 (3⁵) 
2, 4 -> 16 */ 
 
Console.WriteLine("Введите два числа: "); 
int A = int.Parse(Console.ReadLine()); 
int B = int.Parse(Console.ReadLine()); 
  
Console.WriteLine("Возведение в степень = " + stepDigit(A, B)); 
 
int stepDigit(int first, int second) 
{ 
    int res = 1; 
    for (int i = 1; i<=second; i++) 
    { 
        res *= first;  
    } 
    return res; 
}