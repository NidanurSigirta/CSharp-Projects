using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25__C__Sınıflar_ve_Kapsülleme
{
    internal class Arabaa:ArabaDetay  // kalıtım kullanarak yeni değişkene gerek kalmadan
                                      // sınıf üyelerini araba sınıfının değişkeni ile tanımladık
    {

        public string renk;
        public int hiz;
        public double motor;
        public int fiyat;
        public char durum;
        private int yil;
        private string marka;

        // private olanları kapsülleme ile get set fonksiyonlarını çağırarak erişilmesini sağladık
        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }

        }

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
