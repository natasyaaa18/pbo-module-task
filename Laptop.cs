using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    public class Asus : Laptop 
    {
        public Asus() 
        {
            base.merk = "ASUS";
        }
    }

    public class Acer : Laptop 
    {
        public Acer() 
        {
            base.merk = "ACER";
        }
    }

    public class Lenovo : Laptop 
    {
        public Lenovo() 
        {
            base.merk = "Lenovo";
        }
    }

    public class Rog : Asus 
    {
        public Rog()
        {
            base.tipe = "ROG";
        }
    }

    public class Vivobook : Asus
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class Swift : Acer
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    public class Predator : Acer
    {
        public Predator()
        {
            base.tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");

        }
    }
    
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPd";
        }
    }

    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

