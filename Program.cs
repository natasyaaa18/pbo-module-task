using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumPBO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new Corei7();

            // Soal 1 Laptop 2 //
            Console.WriteLine("Soal 1 =  ");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("-----------------------------------\n");

            // Soal 2 Laptop 1 //
            Console.WriteLine("Soal 2 =  ");
            Console.WriteLine("-----------------------------------\n");

            // Soal 3 //
            Console.WriteLine("Soal 3 =  ");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);
            Console.WriteLine("-----------------------------------\n");

            // Soal 4 //
            Console.WriteLine("Soal 4 =  ");
            predator.BermainGame();
            Console.WriteLine("-----------------------------------\n");

            // Soal 5 //
            Console.WriteLine("Soal 5 =  ");
            Console.WriteLine("-----------------------------------\n");
        }
    }

}
