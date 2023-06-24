using System;

namespace Ders_6
{
        class Program{
        public static void Main(string[] args){
            
            int time=DateTime.Now.Hour;
            if (time < 8 && time >6){

                    Console.WriteLine("Good Morning!");

            }else if (time >= 9 && time<=22){

                Console.WriteLine("Good Day");

            }else{
                Console.WriteLine("Good Nigh");

            }
            String fc = time >8 ?"good morning":"good night";//burda koşul kontrol ettiriyoz ilki sağlamıyosa ikincisi sağlanmıyosa

            fc = time>= 6 && time <=7 ?"günaydın":time<=18?"iyi akşamlar":"iyigeceler";
             
            Console.WriteLine(fc);
            Console.ReadKey();

            
        }
    }
}
