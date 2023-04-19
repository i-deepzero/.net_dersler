using System; 

namespace Program
{
    class ders_2
    {
        public static void Main(string[] args)
        {
            //Değişkenler

            int isi = 20;//<=nul gelemez
            String isim = null;
            /*
            *değişkenlere isim verirken boşluk kullanmıyoruz,sitem isimleri kullanmıyoruz,harklı veri tiplerindeki 
            değişkenlerde aynı isimleri kullanmıyoruz,değişkene  isim verirken isimin başıansayı konulmaz,
            ismler küçük ve büyük harf duyarlıdır
            */
            //---------------------
            //tam sayıları tutan değişkenler
            byte b1  =255;      //1 byt ram de yer kaplar
            sbyte b2 =-128;     //1 byt ram de yer kaplar 
            
            short s1  = 9577;   //2 byt ram de yer kaplar
            ushort s2 = 954;    //2 byt ram de yer kaplar

            Int16 i1 =  12;     //2 byt ram de yer kaplar
            int   i2 =  12;     //4 byt ram de yer kaplar
            Int32 i3 =  12;     //4 byt ram de yer kaplar
            Int64 i4 =  12;     //8 byt ram de yer kaplar
            uint  i5 =  12;     //4 byt ram de yer kaplar ancak negatif değeer alamaz    
            long  i6 =  12;     //8 byt ram de yer kaplar
            ulong i7 =  12;     //8 byt ram de yer kaplar ancak negatif değeer alamaz
            //real sayılar
            float  f1 =12.2f;   //4 byt ram de yer kaplar              
            double d1 =12.2;    //8 byt ram de yer kaplar
            decimal d2 =12;     //8 byt ram de yer kaplar      
            //harfli ifadeler
            
            string ss1 ="my";   //sınırsı ramde yer kaplar 
            char c1 = 'd' ;     //2 byt ram de yer kaplar


            //doğru yanlış işlemleri
            bool bo1=true;
            bool bo2=false;
            //tarih ve zaman tutmak için
            DateTime dt = DateTime.Now;
            
            Console.WriteLine(dt);
            
            
            //herşeyi tuta bile değerler

            object ob1 =23;
            object ob2 ="helloworld";
            

            //Stringler 

            string ad,soyad,tamism;
            ad="volter";
            soyad ="white";
            tamism ="volter"+" "+" white";
            
            //integer lar
            int in1 =12;
            int in2 =24;
            int in3 = in1*in2;
            Console.WriteLine(in3+tamism);
            

            //boolian

            bool bool1=true;
            bool bool2=12<2;//bu geriye true döndürü
            bool bool3=12<23;//bu ise geriye false dödürür


            //tip dönüşümleri 
            
            string td1 ="23";
            int td2=12;

            string td3 = td1 + td2.ToString();//int string'e çeviri
            Console.WriteLine(td3);
            

            int td4 = td2 + Convert.ToInt32(td1);//string'ten int'e 
            Console.WriteLine(td4);

            int td5 = td2 + int.Parse(td1);//budah başka biyöntemi
            Console.WriteLine(td5);
           

            //zamanlarıda stringe çevirebiliriz

            string zm1=DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(zm1);

            string zm2=DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(zm2);


            
            
            Console.ReadKey();

        }
    }
}
