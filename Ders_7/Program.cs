using System;

namespace Ders_7{
    class Program{
        public static void Main(String[] args){
            int mont =DateTime.Now.Month;
            //Expression
            switch (mont)
            {
                case 1:
                    Console.WriteLine("Ocak ayı şuanda");
                    break;
                
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;

                case 3:
                    Console.WriteLine("Mart ayı şuanda");
                    break;
                
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayı şuanda");
                    break;
                
                case 6:
                    Console.WriteLine("Haziran ayındasınız");
                    break;

                case 7:
                    Console.WriteLine("Temmuz ayı şuanda");
                    break;
                
                case 8:
                    Console.WriteLine("Agustos ayındasınız");
                    break;

                case 9:
                    Console.WriteLine("Eylül ayı şuanda");
                    break;
                
                case 10:
                    Console.WriteLine("Ekim ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayı şuanda");
                    break;
                
                case 12:
                    Console.WriteLine("Aralık ayındasınız");
                    break;

                default:
                   break;
            }
            switch (mont)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;

                
            }
            

        }
    }
}