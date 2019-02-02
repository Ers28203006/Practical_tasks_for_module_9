using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_on_Module_9
{
    abstract class DataCarrier
    {
        protected string _storadgeDataName;
        protected string _storargeModel;
       
        public DataCarrier(string storadgeDataName, string storargeModel, double amountOfMemory)
        {
            _storadgeDataName = storadgeDataName;
            _storargeModel = storargeModel;
            AmountStoradgeOfMemory = amountOfMemory;
            AmountStoradgeOfFreeMemory = AmountStoradgeOfMemory;
            ScopeOfAllInformation = 578560;
        }
        public double AmountStoradgeOfMemory{ get; set; }
        public double AmountStoradgeOfFreeMemory { get; set; }
        public double ScopeOfAllInformation { get; set;}

        public void DataCopy()
        {
            double weightFile = 780;
            double numberOfMedia=0;
            double numberFilesMedia;
            while (ScopeOfAllInformation >= 0)
            {
                ScopeOfAllInformation -= AmountStoradgeOfFreeMemory;
                ++numberOfMedia;
            }
            numberFilesMedia = AmountStoradgeOfFreeMemory / weightFile;
            Console.WriteLine("Количество файлов на носителе: " + (int)numberFilesMedia);
            Console.WriteLine("Количество носителей для переноса информации: " + numberOfMedia);
        }
        public virtual void TimeToTransfer() { }

        public void StrordgeInformation()
        {
            //перевод объема памяти из мегабайтов в гигабайты 
            AmountStoradgeOfMemory /= 1024;

            Console.WriteLine("Наименование носителя информации: " + _storadgeDataName +
                "\nМодель носителя информации: " + _storargeModel +
                "\nOбъем памяти устройства: " + AmountStoradgeOfMemory);
        }

    }
}
