using System;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Ders_10
{
    public static void Main(string[] args)
    {
        
        //tanımlama şekilleri

            string[] renkler = new string[5];

            string[] hayvanlar={"köpek","kuş","maymun"};

            int[] sayılar;
            sayılar =new int[4];
            renkler[0]="red";
            sayılar[2]=23;

            Console.WriteLine(hayvanlar[2]);
            
            Console.WriteLine(sayılar[2]);

            Console.WriteLine(renkler[0]);

            //döngülerle dizi kullanımı



            Console.Write("lütfen bir sayı girinz: ");
            int duzun =int.Parse(Console.ReadLine());
            int[] dizi=new int[duzun];

            for (int i = 0; i < duzun; i++)
            {
                Console.Write("Lütfen {0},indexi girin: "+i+1);

                dizi[i]=int.Parse(Console.ReadLine());


            }
            int toplam =0;
            foreach (var item in dizi)
            {
                toplam += item;
            }
            Console.WriteLine("ortalamsı: "+toplam/duzun);
             



    }
}






