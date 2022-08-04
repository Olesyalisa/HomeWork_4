int[] getMassive(int num) 
{ 
    int [] arr = new int[num];  
    Random rnd = new Random(); 
 
    for (int i = 0; i<arr.Length; i++) 
    { 
         arr[i] = rnd.Next(0, 100);   
    } 
    return arr; 
} 
 
Console.WriteLine("Введите размер массива = ");
int size = int.Parse(Console.ReadLine());

int[] mas = getMassive(size); 
 
for (int i = 0; i<mas.Length; i++) 
{ 
    Console.Write(mas[i] + " "); 
}