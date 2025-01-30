using System.Text;

namespace StringMathDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;

            Console.WriteLine(zaman);

            string formatliZaman = zaman.ToString("dd/MMM/yyyy HH:mm");

            Console.WriteLine(formatliZaman);

            string sarki = "Öyle deli gibi bakma ne olur";

            string oylesizSarki = sarki.Substring(5, 23);

            Console.WriteLine(oylesizSarki);

            string yilmaz = sarki.Replace("gibi", "Yılmaz");

            Console.WriteLine(yilmaz);

            string yilmaz2 = sarki.Replace('e', 'a');

            Console.WriteLine(yilmaz2);

            string silme = sarki.Remove(5, 10);

            Console.WriteLine(silme);

            string adSoyad = "  Ahmet Selman Şener ";

            Console.WriteLine(adSoyad);

            adSoyad = adSoyad.Trim();

            Console.WriteLine(adSoyad);

            Console.WriteLine("Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İsim giriniz");
            string isim = Console.ReadLine();

            string ifade = "{0} kişisi {1} tane bira içti";

            // yazılımda sayma sıfırdan başlar
            // elma - armut - karpuz - kiraz - vişne 

            // string format
            Console.WriteLine(ifade, isim, sayi);

            // string interpolation
            Console.WriteLine($"{isim} kişisi {sayi} tane bira içti");

            // string concat
            string sonuc = string.Concat(isim, " kişisi ", sayi, " tane bira içti");

            Console.WriteLine(sonuc);

            Console.WriteLine(sonuc.ToUpper());
            Console.WriteLine(sonuc.ToLower());

            int sayi1 = -150;

            Console.WriteLine(Math.Abs(sayi1));

            decimal sayi2 = 56.43M;
            Console.WriteLine(++sayi2);

            Console.WriteLine(Math.Ceiling(++sayi2));
            Console.WriteLine(Math.Floor(++sayi2));

            Console.WriteLine(Math.Pow(2, 3));
        }
    }
}
