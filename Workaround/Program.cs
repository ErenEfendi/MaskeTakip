using Entities.Concrete;
using Business.Concrete;

using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using Business.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            SelamVer("Erencan");
            SelamVer("Ubeydullah");
            SelamVer("Abdulrezak");

            int sonuc = Topla(22,9);

            string ogrenci1 = "Erencan";
            string ogrenci2 = "Ubeydullah";
            string ogrenci3 = "Abdulrezak";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = ogrenci1;
            ogrenciler[1] = ogrenci2;
            ogrenciler[2] = ogrenci3;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Person person1 = new Person();
            person1.FirstName = "firstname";
            person1.LastName = "lastname";
            person1.DateOfBirthYear = 1234;
            person1.NationalIdentity = 12345678912;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SelamVer(string isim="isimsiz") // default yapmak için 
        {
            Console.WriteLine("Merhaba "+ isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc.ToString());
            return sonuc;
        }

       
    }
}
