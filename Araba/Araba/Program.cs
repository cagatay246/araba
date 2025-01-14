using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        araba1.BilgileriYazdir();

        Araba araba2 = new Araba("BMW", "320i", "Mavi", 3);
        araba2.BilgileriYazdir();

        Araba araba3 = new Araba("Audi", "A4", "Siyah", 2);
        araba3.BilgileriYazdir();
    }
}