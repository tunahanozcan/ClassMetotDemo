using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> ogrenci = new MyDictionary.MyDictionary<int, string>();
            ogrenci.Add(17, "Tunahan");
            ogrenci.Add(34, "İlyas");
            ogrenci.Add(78, "Özcan");


            Console.WriteLine($" Öğrencinin Numarası: {ogrenci.No[0]} \n Öğrencinin İsmi: {ogrenci.Isım[0]} \n ******************************** ");
            Console.WriteLine($" Öğrencinin Numarası: {ogrenci.No[1]} \n Öğrencinin İsmi: {ogrenci.Isım[1]} \n ********************************");
            Console.WriteLine($" Öğrencinin Numarası: {ogrenci.No[2]} \n Öğrencinin İsmi: {ogrenci.Isım[2]} \n ******************************** ");

            Console.ReadLine();
        }
    }
}
