using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Araba
{
    // Özellikler
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

   
    private int _kapıSayısı;

    public int KapıSayısı
    {
        get { return _kapıSayısı; }
        set
        {
            
            if (value == 2 || value == 4)
            {
                _kapıSayısı = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı sayısı sadece 2 veya 4 olabilir. Kapı sayısı -1 olarak atanıyor.");
                _kapıSayısı = -1;
            }
        }
    }

    // Constructor
    public Araba(string marka, string model, string renk, int kapıSayısı)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayısı = kapıSayısı;  
    }

    
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapıSayısı}");
    }
}