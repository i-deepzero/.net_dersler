using System;

namespace Ders_5{
    class Program{
        public static void Main(String[] args){
            
            try{
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayı:"+sayi);
            }
            catch(Exception Ex){

                    Console.WriteLine("hata:"+Ex.Message.ToString());
            }

            finally{
                Console.WriteLine("işelem tamamlandı");

            }



            try{
                
                //int sayi1 = int.Parse(null);
                
                //int sayi2 =int.Parse("team");
                int sayi3 = int.Parse("38948232745878");
            }
            catch(ArgumentNullException Exe){

                    Console.WriteLine("boş değer girdiniz");
            
                    Console.WriteLine(Exe);
                    
            
            }
            catch(FormatException fx){

            Console.WriteLine("format uygun değil");
            Console.WriteLine(fx);
            
            }
            catch(OverflowException vx){

            Console.WriteLine("veri çok büyük");
            Console.WriteLine(vx);
            
            }

            


        }
    }
}