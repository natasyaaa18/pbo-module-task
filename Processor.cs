using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Processor
    {
        public string merk;
        public string tipe;
    }

    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }

    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }

    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }

    public class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    public class Ryzen : amd
    {
        public Ryzen() 
        {
            base.tipe = "RAYZEN";
        }
    }

    public class Athlon : amd
    {
        public Athlon() 
        {
            base.tipe = "ATHLON";
        }
    }
