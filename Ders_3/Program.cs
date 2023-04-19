using System;

namespace Ders_3{
 class Program{
    public static void Main (string[] args){
        //Atma Ve İşlemlemli atama

        int x=3;
        int y=2;

        y = y+12;//atama
        Console.WriteLine(y);
        //işlemli atama
        y += 24;
        Console.WriteLine(y);
        y /= 2;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        Console.WriteLine("-------------------------------------------------------");
        //Mantıksal Operatörler (&&,||,!)

        bool b1 = false;
        bool b2 = true;

        if (b1 && b2)//ve operatörü iki koşulda sağlanmadığı için çalışmaz
            Console.WriteLine("güzel");
            
        if (b1 || b2)//veya operatörü bu ise birinin sağlaması yeterli olduğu için çalışır
            Console.WriteLine("güzel");
        
        if (!b1 && b2)//burda iki tane olay var ! değeri tersine çevirdi ve 've' bloğuda aktif oldu
            Console.WriteLine("güzel");
        //burda python gibi süslü parentez açmadanda if bloğunun içine girile bildiğini gördüm
        Console.WriteLine("-------------------------------------------------------");
        //İlişkisel Operatörler (<,>,<=,>=,!=,==)---

        int io1 = 12;
        int io2 = 13;
        bool sonuc;
        sonuc = io1 < io2;
        Console.WriteLine(sonuc);//true
        sonuc = io1 > io2;
        Console.WriteLine(sonuc);//false
        sonuc = io1 <= io2;
        Console.WriteLine(sonuc);//true
        sonuc = io1 >= io2;
        Console.WriteLine(sonuc);//false
        sonuc = io1 == io2;
        Console.WriteLine(sonuc);//false
        sonuc = io1 != io2;
        Console.WriteLine(sonuc);//true

        Console.WriteLine("-------------------------------------------------------");

        //Aritmaitk Operatörler(-,+,/,*)

        int ao1=30;
        int ao2=30;

        int sonuc1 =ao1+ao2; 
        Console.WriteLine(sonuc1);

        int sonuc2 =ao1-ao2; 
        Console.WriteLine(sonuc2);

        int sonuc3 =ao1*ao2; 
        Console.WriteLine(sonuc3);

        int sonuc4 =ao1/ao2; 
        Console.WriteLine(sonuc4);

        int sonuc5 =ao1++; 
        Console.WriteLine(sonuc5);

        Console.WriteLine("-------------------------------------------------------");
        //mod alma (%)

        int ma1 = 30;
        int ma2 = 40;

        int ma3 = ma1 % ma2;
        Console.WriteLine(ma3);




        Console.ReadKey();

        }
    }
}
