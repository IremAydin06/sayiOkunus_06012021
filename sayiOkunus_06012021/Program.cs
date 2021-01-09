using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiOkunus_06012021
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki basamaklı sayıların okunuşu
            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "atmış", "yetmiş", "seksen", "doksan" };

            Console.WriteLine("İki basamakli bir sayi giriniz:");
            int girilenSayi = int.Parse(Console.ReadLine());
            int onlarBasamagindakiDeger = girilenSayi / 10;
            int birlerBasamagindakiDeger = girilenSayi % 10;

            string okunus = onlar[onlarBasamagindakiDeger] + " " + birler[birlerBasamagindakiDeger];
            Console.WriteLine(okunus);

            Console.ReadLine();
        }
    }
}
