using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_dari_Awal_Banget
{
    public class Processor
    {
        public string merk;
        public string tipe;
        public Processor(string _merk, string _tipe)
        {
            this.merk = _merk;
            this.tipe = _tipe;
        }
    }
    public class Intel : Processor
    {
        public Intel(string _merk, string _tipe) : base(_merk, _tipe)
        {
         
        }
    }
         public class CoreI3 : Intel
        {
            public CoreI3 (string _merk = "Intel", string _tipe = "Core i3") : base(_merk, _tipe)
            {
     
            }
        }
        public class CoreI5 : Intel
        {
            public CoreI5(string _merk = "Intel", string _tipe = "Core i5") : base(_merk, _tipe)
            {

            }
        }
        public class CoreI7 : Intel
        {
            public CoreI7(string _merk = "Intel", string _tipe = "Core i7") : base(_merk, _tipe)
            {

            }
        }
    public class AMD : Processor 
    {
        public AMD(string _tipe, string _merk = "AMD") : base(_merk, _tipe)
        {

        }
    }
        public class Ryzen : AMD
        {
            public Ryzen(string _merk = "AMD", string _tipe = "RAYZEN") : base(_merk, _tipe)
            {

            }
        }
        public class Athlon : AMD
        {
            public Athlon(string _merk = "AMD", string _tipe = "ATHLON") : base(_merk, _tipe)
            {

            }
        }



    public class Vga
    {
        public string merk;
        public Vga(string merk)
        {
            this.merk = merk;
        }
    }
        public class Nvidia : Vga
        {
            public Nvidia(string _merk = "Nvidia") : base(_merk)
            {

            }
        }
        public class amd : Vga
        {
            public amd(string _merk = "AMD") : base(_merk)
            {

            }
        }
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;
        public Laptop(string _merk, string _tipe, Vga _vga, Processor _processor)
        {
            this.merk       = _merk;
            this.tipe       = _tipe;
            this.vga        = _vga;
            this.processor  = _processor;
        }
        public void LaptopDinyalakan()
        {   
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS(string _tipe, Vga _vga, Processor _processor, string _merk = "ASUS") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
        public class ROG : ASUS
        {
            public ROG(Vga _vga, Processor _processor, string _merk = "ASUS", string _tipe = "ROG") : base(_tipe, _vga, _processor, _merk)
            {

            }
        }
        public class Vivobook : ASUS
        {
            public Vivobook(Vga _vga, Processor _processor, string _merk = "ASUS", string _tipe = "Vivobook") : base(_tipe, _vga, _processor, _merk)
            {

            }
            public void Ngoding()
            {
                Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
            }
        }

    public class ACER : Laptop
    {
        public ACER(string _tipe, Vga _vga, Processor _processor, string _merk = "ACER") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
        public class Swift : ACER
        {
            public Swift(Vga _vga, Processor _processor, string _merk = "ACER", string _tipe = "Swift") : base(_tipe, _vga, _processor, _merk)
            {

            }
        }
        public class Predator : ACER
        {
            public Predator(Vga _vga, Processor _processor, string _merk = "ACER", string _tipe = "Predator") : base(_tipe, _vga, _processor, _merk)
            {

            }
            public void BermainGame()
            {
                Console.WriteLine($"Laptop {merk} {tipe} sedang bermain game");
            }
        }
    public class Lenovo : Laptop
    {
        public Lenovo(string _tipe, Vga _vga, Processor _processor, string _merk = "Lenovo") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
        public class IdeaPad : Lenovo
        {
            public IdeaPad(Vga _vga, Processor _processor, string _merk = "Lenovo", string _tipe = "IdeaPad") : base(_tipe, _vga, _processor, _merk)
            {

            }
        }
        public class Legion : Lenovo
        {
            public Legion(Vga _vga, Processor _processor, string _merk = "Lenovo", string _tipe = "Legion") : base(_tipe, _vga, _processor, _merk)
            {

            }
        }

    class program
    {
        static void Main()
        {
            Laptop laptop1      = new Vivobook(new Nvidia(), new CoreI5());
            Laptop laptop2      = new IdeaPad (new amd(), new Ryzen());
            Predator predator   = new Predator(new amd(), new Ryzen());
            ACER acer           = new Predator(new amd(), new Ryzen());

            Console.WriteLine("Nomer 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Console.WriteLine("\nNomer 2");
            laptop1.Ngoding();

            Console.WriteLine("\nNomer 3");
            Console.WriteLine("Spesifikasi Laptop 1:");
            Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
            Console.WriteLine($"Merk Processor: {laptop1.processor.merk}");
            Console.WriteLine($"Tipe Processor: {laptop1.processor.tipe}");

            Console.WriteLine("\nNomer 4");
            predator.BermainGame();

            Console.WriteLine("\nNomer 5");
            acer.BermainGame();
        }
    }
}

