using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Asal = new ArrayList();
            ArrayList NoAsal = new ArrayList();
            double toplamAsal = 0;
            double toplamNoAsal = 0;
            double ortAsal;
            double ortNoAsal;
            int kontrol = 0;
            



            for (int i = 0; i < 10; i++)
            {
                Console.Write("Lütfen "+ (i+1)+ ". sayıyı giriniz: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    for (int j = 2; j < num; j++)
                    {
                        if ((num % j == 0))
                        {
                            kontrol++;
                        }
                    }
                    if (num==0 || num==1)
                    {
                        NoAsal.Add(num);    
                    }
                    else
                    {
                        if (kontrol != 0)
                    {
                        NoAsal.Add(num);
                    }
                    else
                    {
                        Asal.Add(num);
                    }
                    }
                   
                    
                }
                else
                {
                    
                    Console.WriteLine("Lüften pozitif sayı giriniz.");
                }

            }

            Asal.Sort();
            NoAsal.Sort();
            Asal.Reverse();
            NoAsal.Reverse();
            Console.WriteLine("**********Asal sayılar**********");
            foreach (var item1 in Asal)
            {

                Console.WriteLine(item1);
                toplamAsal += Convert.ToInt32(item1);



            }
            ortAsal = toplamAsal / Asal.Count;
            Console.WriteLine("Dizi elemanlarının toplamı: " + toplamAsal + "\n" + "Dizi elemanlarının ortalaması: " + ortAsal);
            Console.WriteLine("**********Asal Olmayan sayılar**********");
            foreach (var item2 in NoAsal)
            {

                Console.WriteLine(item2);
                toplamNoAsal += Convert.ToInt32(item2);


            }
            ortNoAsal = toplamNoAsal / NoAsal.Count;
            Console.WriteLine("Dizi elemanlarının toplamı: " + toplamNoAsal + "\n" + "Dizi elemanlarının ortalaması: " + ortNoAsal);

            Console.ReadLine();


        }
    }
}
