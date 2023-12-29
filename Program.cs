﻿Console.WriteLine("Please insert Array Lenght: ");
int l= Convert.ToInt32(Console.ReadLine());

string[] array1= new string[l];
void InitialArray(string[] array1)
{
  for (int i = 0; i < array1.Length; i++)
  {
     Console.WriteLine($"Please insert Array element number {i+1}: ");
     array1[i] = Console.ReadLine();
  }
}
void PrintInitialArray(string[] array)
{
    Console.WriteLine ();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{  
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}   
void PrintNewArray(string[] array)
{
    Console.WriteLine ();
    Console.Write ($"-> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

InitialArray(array1);
PrintInitialArray(array1);
NewArray(array1, array2);
PrintNewArray(array2);