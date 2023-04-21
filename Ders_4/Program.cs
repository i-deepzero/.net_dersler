using System;

namespace Ders_4{
    class Program{
        public static void Main(String[] args){
            // implicit Conversion (Bilinçsiz Dönüşüm)

            Console.WriteLine("*****implicit Conversion (Bilinçsiz Dönüşüm)*****");
            byte b1 =20;
            sbyte sb1=30;
            short s1 =10;

            int i1= b1+sb1+s1;
            Console.WriteLine("D:"+i1);

            long l1=i1;
            Console.WriteLine("l:"+l1);

            float f1 = l1;
            Console.WriteLine("f:"+f1);

            string sg1 ="hello world";
            Char ch1 = 'c';
            object ob1= sg1+ch1+s1;//object te hepsi birleşir ve hepsini içine alabilir
            Console.WriteLine("ob1:"+ob1);
            
            Console.WriteLine("*****Explicit Conversioon (Bilinçili Dönüşüm)*****");
            //Explicit Conversioon (Bilinçili Dönüşüm)
            int i2=12;
            byte b2=(byte)i2;//burada aslında bu veri tipi byt olabilir diyoruz
            Console.WriteLine("b2:"+b2);

            float f2=12.3f;
            byte b3 =(byte) f2;//veri kaybı yaşana bilr burda kendine en yakın sayıya yuvarlar
            Console.WriteLine("*****ToString Metodu*****");
            //ToString Metodu
            int i3=12;
            string sg2=i3.ToString();
            Console.WriteLine("sg2:"+sg2);

            string sg3=12.23f.ToString();
            Console.WriteLine("sg3:"+sg3);
            Console.WriteLine("*****System.Convert Sınıfı*****");  
            //System.Convert Sınıfı

            string sg4="12",sg5="30";
            int i4,i5,sonuc;

            i4 = Convert.ToInt32(sg4);
            i5 = Convert.ToInt32(sg5);

            sonuc =i4+i5;
            Console.WriteLine("sonuc:"+sonuc);
            Console.WriteLine("*****Parse Methodu*****");
            //Parese Methodu

            ParseMethod();

 
            Console.ReadKey();
        }
        public static void ParseMethod(){
        String sg6="12.2",sg7="23";
        int rakamlar;
        Double d1;
        rakamlar =Int32.Parse(sg6);
        Console.WriteLine("rakam:"+rakamlar);
        d1=Double.Parse(sg7);
        Console.WriteLine("double:"+d1);



        }
    }
}

