using System;

namespace For_Loop_Break_Continue
{
    class Program
    {
        static  void Main(string[] args)
        {
           // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
           Console.WriteLine("Bir Sayı Giriniz:");
           int sayac=int.Parse(Console.ReadLine());
           for (int i = 0; i <= sayac; i++)
           {
               if(i%2==1)
               {
                   Console.WriteLine(i);
               }
           }
           Console.WriteLine("************");
           // 1 il 1000 arasındaki tek ve çift sayıların toplamını hesaplayalım bunu konsola yazalım.
           int tektoplam=0;
           int cifttoplam=0;
            for (int i = 1; i <= 100; i++)
            {
                if(i%2==1)
                {
                    //tektoplam=i+tektoplam;
                    tektoplam +=i;
                }
                else
                {
                    //cifttoplam = i + cifttoplam
                    cifttoplam += i;
                }
            }
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Cifttoplam:" + cifttoplam);

            //break,continue
            //break:bir döngü içerisinde cas'e bağlı olarak looptan çıkmak istiyorsanız yani döngüyü sonlandırmak istiyorsanız break ifadesi kullanır.
            //continue:Bir şarta bağlı olarak mevcut döngünün o bloğunu atlamak istiyorsak mesela 10 kere dönecek 1 şartta çalışmasını istemiyoruz kod bloğunun sadece o bloğu atlayarak bir sonraki bloğa geçmesini sağlıyoruz.
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
             for (int i = 1; i < 10; i++)
            {
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        
    }
}
