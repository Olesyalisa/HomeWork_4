﻿/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */ 
 
int[] getMassive() 
{ 
    int [] mas = new int[8];  
    Random rnd = new Random(); 
 
    for (int i = 0; i<mas.Length; i++) 
    { 
         mas[i] = rnd.Next(0, 100);   
    } 
    return mas; 
} 
 
int[] array = getMassive(); 
 
for (int i = 0; i<array.Length; i++) 
{ 
    Console.Write(array[i] + " "); 
}