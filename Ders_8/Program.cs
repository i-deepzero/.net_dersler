using System;
using System.Runtime.CompilerServices;

namespace Ders_8{
    class Program{
        public static void Main(String[] args){
           Console.WriteLine("bir sayı girin:");
            int giris =int.Parse(Console.ReadLine());

            for (int i = 1; i < giris; i++)
            {
                if ( i%2 == 1){
                    Console.WriteLine(i);
                }
            }

            int cift = 0;
            int tek = 0;
            for (int say = 0; say <= 1000; say++)
            {
                if(say%2 == 1){
                    tek += say;
                }
                else{
                    cift += say;
                }
                
                    
            }
            Console.WriteLine("tek sayı:" + tek);


            Console.WriteLine("çift sayı:" + cift);
            //break continue

            for (int i = 0; i < 546367; i++)
            {
                if (i == 40){
                    break;

                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 54; i++)
            {
                if (i == 40){
                    continue;

                }
                Console.WriteLine(i);
            }
            /*
            infinity loop

            for (;;)
            {
                
            }

            */

        }
    }
}