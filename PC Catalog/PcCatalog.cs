namespace PC_Catalog
{
    using System;
    using Classes;
    using Classes.Components;


    class PcCatalog
    {
        static void Main(string[] args)
        {
            Component ram8 = new DynamicMemory("RAM 8 GB", "DDR3 1600 Mhz", 85);
            Component ram4 = new DynamicMemory("RAM 4 GB", "DDR3 1066 Mhz", 35);
            Component simpleRam = new DynamicMemory("Simple RAM 2GB", 10);

            Component gpuGeForce = new GraphicCard("GeForce GPU", "2Gb DDR5", 100);
            Component gpuAti = new GraphicCard("Ati Radeon GPU", "1Gb DDR5", 70);
            Component simpleGpu = new GraphicCard("Simple GPU", 15);

            Component boardGood = new Motherboard("Intel Desktop Board DH55TC", "Intel H55 Express Chipset", 75);
            Component simpleBoard = new Motherboard("Simple motherboard", 25);

            Component intelI7 = new Processor("Intel i3 Processor", "3.4 Ghz Cache: 12Mb", 300);
            Component intelCeleron = new Processor("Intel Celeron", "2.66 Ghz Cache: 1Mb", 89);
            Component simpleCpu = new Processor("Simple CPU", 49);

            Component bigScreen = new Screen("HP Z-24", "24 in FULL HD display", 300);
            Component simpleScreen = new Screen("Simple Screen - 17 in", 80);

            Component ssd1Tb = new StorageDrive("Crucial M550", "1TB SSD", 400);
            Component hdd1Tb = new StorageDrive("HDD", "1TB", 150);
            Component simpleHdd = new StorageDrive("Simple HDD", "320 Gb", 50);

            Computer goodComp = new Computer("Zverska-Machine", new Component[] { intelI7, ram8, gpuGeForce, ssd1Tb, bigScreen, boardGood });
            Computer workComp = new Computer("Work-Horse", new Component[] { intelCeleron, ram4, gpuAti, hdd1Tb, simpleScreen, boardGood });
            Computer averageComp = new Computer("FacebookAndYoutubeAreGreat", new Component[] { simpleCpu, simpleRam, simpleGpu, simpleHdd, simpleScreen, simpleBoard });
            Computer simplComputer = new Computer("Email-Opener", new Component[] { simpleCpu, simpleRam, simpleHdd, simpleBoard });

            Computer[] computers = new Computer[] { goodComp, workComp, averageComp, simplComputer };

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
