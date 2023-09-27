using System;
using System.Runtime.ConstrainedExecution;

namespace TugasPBO3
{
    class Processor
    {
        public string Merk;
        public string Tipe;
    }

    class Intel : Processor
    {
        public Intel(string Merk)
        {
            this.Merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3() : base("Intel")
        {
            Tipe = "Core i3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5() : base("Intel")
        {
            Tipe = "Core i5";
        }
    }

    class Corei7 : Intel
    {
        public Corei7() : base("Intel")
        {
            Tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD(string Merk)
        {
            this.Merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("AMD")
        {
            Tipe = "RYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon() : base("AMD")
        {
            Tipe = "ATHLON";
        }
    }

    class VGA
    {
        public string Merk;
        public VGA(string Merk)
        {
            this.Merk = Merk;
        }
    }

    class Nvidia : VGA
    {
        public Nvidia() : base("VGA")
        {
            Merk = "Nvidia";
        }
    }

    class Amd : VGA
    {
        public Amd() : base("VGA")
        {
            Merk = "AMD";
        }
    }

    class Laptop
    {
        public string Merk;
        public string Tipe;
        public VGA Vga;
        public Processor Processor;
        public Laptop(string Merk, string Tipe, VGA vga, Processor processor)
        {
            this.Merk = Merk;
            this.Tipe = Tipe;
            this.Vga = vga;
            this.Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " Menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " Mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string Tipe, VGA vga, Processor processor) : base("ASUS",Tipe,vga,processor)
        {
            Merk = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG() : base("ROG", new Nvidia(), new Corei7())


        {
            Tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook() : base("Vivobook", new Nvidia(), new Corei5())

        {
            Tipe = "Vivobook";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak ctak ctak Error lagi!!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string Tipe, VGA vga, Processor processor) : base("ACER", Tipe, vga, processor)
        {
            Merk = "ACER";
        }
    }

    class Swift : ACER
    {
        public Swift() : base("Swift", new Nvidia(), new Corei5())

        {
            Tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator() : base("Predator", new Amd(), new Corei7())

        {
            Tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string Tipe, VGA vga, Processor processor) : base("Lenovo", Tipe, vga, processor)
        {
            Merk = "Lenovo";
        }
    }

    class Ideapad : Lenovo
    {
        public Ideapad() : base("Ideapad", new Amd(), new Corei5())

        {
            Tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion() : base("Legion", new Nvidia(), new Corei7())

        {
            Tipe = "Legion";
        }
    }

    class Program
    {
        public static void Main()
        {
            Laptop laptop1 = new Laptop("ASUS", "Vivobook", new Nvidia(), new Corei5());
            Laptop laptop2 = new Laptop("Lenovo", "IdeaPad", new Amd(), new Ryzen());

            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            laptop1.Ngoding();

            Console.WriteLine("Spesifikasi Laptop 1:");
            Console.WriteLine("Merk VGA: " + laptop1.Vga.Merk);
            Console.WriteLine("Merk Processor: " + laptop1.Processor.Merk);
            Console.WriteLine("Tipe Processor: " + laptop1.Processor.Tipe);

            Predator predator = new Predator();
            predator.BermainGame();

            ACER acer = new Predator();
            acer.BermainGame();

        }
    }

}

