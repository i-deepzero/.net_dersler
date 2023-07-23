using System;
using System.Net.Http.Headers;

class Ders_12{
    public static void Main(string[] args)
    {
        yazdır yazı = new yazdır();


        int x= 23;
        int y =37;
        int toplam = Re(x,y);
        Console.WriteLine(toplam);
        yazı.yazılı(Convert.ToString(toplam));
        int toplam2 = yazı.artırTopla(ref x,ref y);
        yazı.yazılı(Convert.ToString(toplam2));
        yazı.yazılı(Convert.ToString(x+y));
    }


    static public int Re(int a,int b){
        return a+b; 
    }
    
}


class yazdır{
    public void yazılı (string veri){

        Console.WriteLine(veri);

    }
    public int artırTopla (ref int deger1,ref int deger2){
        deger1+=1;
        deger2+=1;

        return deger1 + deger2;

    }
}