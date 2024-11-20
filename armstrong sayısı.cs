using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());

       
        int basamakSayisi = sayi.ToString().Length;

        int toplam = 0;
        int orijinalSayi = sayi;

        
        while (sayi > 0)
        {
            int basamak = sayi % 10; //
            toplam += (int)Math.Pow(basamak, basamakSayisi); 
            sayi /= 10;
        }

       
        if (toplam == orijinalSayi)
        {
            Console.WriteLine("{orijinalSayi} bir Armstrong sayısıdır.");
        }
        else
        {
            Console.WriteLine("{orijinalSayi} bir Armstrong sayısı değildir.");
        }
    }
}

