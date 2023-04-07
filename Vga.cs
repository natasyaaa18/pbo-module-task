using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     
    public class Vga
    {
        public string merk;
    }

    public class Nvidia : Vga
    {
        public Nvidia() 
        {
            base.merk = "Nvidia";
        }
    }

    public class AMD : Vga
    {
        public AMD() 
        {
            base.merk = "AMD";
        }
    }
