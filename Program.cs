using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yaş_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Doğum Yılınızı Giriniz");
            Console.ReadLine();
            DateTime dgunu = new  DateTime ();
          DateTime simdi = DateTime.Today;
          int yas =simdi.Year-dgunu.Year;
            if (dgunu > simdi.AddYears(-yas))
                yas--;
            Console.WriteLine(yas);
            Console.ReadLine();

        }
    }
}
