Console.WriteLine("Введите два числа: "); 
int A = int.Parse(Console.ReadLine()); 
int B = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("Возведение в степень = " + Math.Pow((A),B)); 
 
double stepDigit (int first, int second ) 
{ 
    double result = Math.Pow((first),second); 
    return result; 
} 
