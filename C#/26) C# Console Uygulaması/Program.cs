using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__C__Console_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");  // Line "/n" görevi görerek alt satıra yazdırır diğer kodu
            Console.Write("my baby");
            Console.WriteLine(2023);

            string kelime;
            kelime = "12 Aralık 2023";
            Console.WriteLine(kelime);
            Console.ReadKey();  // tuşa basana kadar kapanmıyo
        }
    }
}
