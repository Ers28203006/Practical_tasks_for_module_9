using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_on_Module_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string storadgeDataName;
            string storargeModel;
            double amountOfMemory;

            Console.WriteLine("Выберите из списка носители информации с которыми хотели бы по работать: \n" +
                "1. HDD-диск\n" +
                "2. Flash-диск\n" +
                "3. DVD-диск");
            int storadgeType = int.Parse(Console.ReadLine());

            switch (storadgeType)
            {
                case 1:
                    storadgeDataName = "HDD-диск";
                    storargeModel = "Transcent";

                    Console.WriteLine("Имеются два HDD-диска с разными объемами, выберите один из них\n" +
                        "1. HDD-диск на 500 ГБ \n" +
                        "2. HDD-диск на 200 ГБ \n");
                    int selectHDD = int.Parse(Console.ReadLine());

                    if (selectHDD == 1)
                    {
                        amountOfMemory = 512000;
                    }

                    else
                    {
                        amountOfMemory = 204800;
                    }

                    HDD hdd = new HDD(storadgeDataName, storargeModel, amountOfMemory);

                    hdd.StrordgeInformation();
                    Console.WriteLine();

                    hdd.TimeToTransfer();

                    Console.WriteLine();
                    hdd.DataCopy();

                    break;

                case 2:
                    storadgeDataName = "Flash-диск";
                    storargeModel = "Transcent";
                    Console.WriteLine("Введите размер памяти Flash-накопителя в гигабайтах");
                    amountOfMemory=double.Parse(Console.ReadLine());

                    //перевод в мегабайты
                    amountOfMemory *= 1024;

                    Flash flash =  new Flash(storadgeDataName, storargeModel, amountOfMemory);

                    flash.StrordgeInformation();
                    Console.WriteLine();

                    flash.TimeToTransfer();

                    Console.WriteLine();
                    flash.DataCopy();

                    break;

                case 3:
                    storadgeDataName = "DVD-диск";
                    storargeModel = "Transcent";

                    Console.WriteLine("Имеются два типа DVD-диска, выберите один из них\n" +
                        "1. Односторонний \n" +
                        "2. Двухсторонний \n");

                    selectHDD = int.Parse(Console.ReadLine());

                    if (selectHDD == 1)
                    {
                        amountOfMemory = 4812.8;
                    }

                    else
                    {
                        amountOfMemory = 9216;
                    }

                    DVD dvd = new DVD(storadgeDataName, storargeModel, amountOfMemory);

                    dvd.StrordgeInformation();
                    Console.WriteLine();

                    dvd.TimeToTransfer();

                    Console.WriteLine();
                    dvd.DataCopy();

                    break;
            }
            Console.ReadLine();
        }
    }
}
