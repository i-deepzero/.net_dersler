using System;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Ders_9
{
    public static void Main(string[] args)
    {
        /*
        Console.Write("bir sayı giriniz:");

       int deger = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <=deger){
            toplam +=sayac;
            sayac++;
        }
        Console.WriteLine(toplam/deger);
        */
            char alb= 'a';

            while(alb <= 'z')
            {
                Console.Write(alb+",");
                alb ++;
            }
            Console.WriteLine("**************forech***********");
            string[] list ={"monster","acer","lenovo","hp","dell","msi","asus","toshiba","casper"};


            foreach (var item in list)
            {   Console.WriteLine(item);




                
            }



    }
}