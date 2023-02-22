using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 137;
            musteri1.Name = "Kemal";
            musteri1.surName = "Bolat";
            musteri1.Password = 6780;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2479;
            musteri2.Name = "Lale";
            musteri2.surName = "Gürbüz";
            musteri2.Password = 3487;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Id: " + musteri.Id);
                Console.WriteLine("Musteri Adi: " + musteri.Name);
                Console.WriteLine("Musteri Soyadı: " + musteri.surName);
                Console.WriteLine("Musteri Sifresi: " + musteri.Password);

                Console.WriteLine("--------------");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Metot Seklinde Yapımı");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            Console.WriteLine("----------------");

            Console.WriteLine("List Metodu");
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            Console.WriteLine("----------------");

            Console.WriteLine("Delete Metodu");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);

            Console.ReadLine();
        }
    }
}
