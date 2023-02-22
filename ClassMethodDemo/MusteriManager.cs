using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi: " + musteri.Id);
            Console.WriteLine("Musteri Adi: " + musteri.Name);
            Console.WriteLine("Musteri Soyadi: " + musteri.surName);
            Console.WriteLine("Musteri Password: " + musteri.Password);
            Console.WriteLine("--------------");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Musteriler Listelendi: " + musteri.Name);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi: " + musteri.Name);
        }

    }
}
