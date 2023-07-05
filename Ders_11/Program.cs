using System;
using System.Runtime.CompilerServices;

class Ders_11{
    public static void Main(string[] args)
    {
        //sort
        int[] liste={23,34,23,13,45,859,54};
        Console.WriteLine("*******Sırasız Dizi*****");
        foreach (var item in liste)
            Console.WriteLine(item);

        Console.WriteLine("*******Sıralı Dizi*****");
        Array.Sort(liste);

        foreach (var item in liste)
            Console.WriteLine(item);
        
        Console.WriteLine("*******Array Clear*****");
        Array.Clear(liste,3,2);//belirli index leri sıfırlar
        foreach (var item in liste)
            Console.WriteLine(item);


        Console.WriteLine("*******Array Reverse*****");
        Array.Reverse(liste);

        foreach (var item in liste)
            Console.WriteLine(item);     
            


        Console.WriteLine("*******Array IndexOf*****");
        
        Console.WriteLine(Array.IndexOf(liste,13));
        

        Console.WriteLine("*******Array Resize*****");
        Array.Resize<int>(ref liste,9);
        liste[8] = 32;

        foreach (var item in liste)
            Console.WriteLine(item);

        
    }
}