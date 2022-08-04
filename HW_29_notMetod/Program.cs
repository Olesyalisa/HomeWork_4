int [] mas = new int[8]; 
 
for (int i = 0; i<mas.Length; i++) 
{ 
    Random rnd = new Random(); 
    mas[i] = rnd.Next(0, 99); 
    Console.Write(mas[i] + " "); 
}
