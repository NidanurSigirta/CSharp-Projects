using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__C__Console_Void_Metodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();

            
            Console.Write("Adınızı giriniz:");
            string ad= Console.ReadLine();
            
            Console.Write("Soyadınızı giriniz:");
            string soyad=Console.ReadLine();

            Console.Write("Yaşınızı giriniz:");
             int yas=Convert.ToInt16(Console.ReadLine());  

            Console.Write("Mesleğinizi giriniz:");
            string meslek=Console.ReadLine();         
        
            ks.kisilistesi(ad, soyad, yas,meslek);

            Console.Read();
        }
    }
}
