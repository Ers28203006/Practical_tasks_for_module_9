using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_on_Module_9
{
    class HDD : DataCarrier
    {
        public HDD(string storadgeDataName, string storargeModel, double amountOfMemory) :
            base(storadgeDataName, storargeModel, amountOfMemory)
        { }
      
        public double SpeedUSB2 { get; set; } = 480;

        public override void TimeToTransfer()
        {
            double timeToTransfer;
            timeToTransfer = ScopeOfAllInformation / SpeedUSB2;
            int s = 0, stemp = 0, m = 0, mtemp = 0, h = 0, htemp = 0;
           
            //перевод секунд в минуты и часы
            while (htemp != 60 && timeToTransfer > 60)
            {
                while (mtemp != 60 && timeToTransfer > 60)
                {
                    while (stemp != 60 && timeToTransfer > 60)
                    {
                        timeToTransfer -= 60;
                        ++stemp;
                    }
                    ++mtemp;
                    s = stemp;
                    stemp = 0;
                }
                ++htemp;
                m = mtemp;
                mtemp = 0;
                h = htemp;
            }

            s += (int)timeToTransfer;
            h += h;
            m += m;
            s += s;

            if (s >= 60)
            {
                ++m;
                s -= 60;
            }

            if (m >= 60)
            {
                ++h;
                m -= 60;
            }

            Console.WriteLine("Время необходимое для копирования, приблизительно: " + h + " : " + m + " : " + s);
        }
    }
}
