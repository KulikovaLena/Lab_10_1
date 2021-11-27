using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite zeloe znachenie degrees ");
            int degrees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite zeloe znachenie minutes ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite zeloe znachenie seconds ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Corner corner = new Corner(degrees, minutes, seconds) ;
            corner.ZnachenieGrad();
            corner.ToRad();
            Console.ReadKey();
        }
    }


    class Corner
    {
        int degrees;
        public int Degrees
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    degrees = value;
                }
                else
                {
                    Console.WriteLine("nevernii diapazon dly degrees");
                }
            }
            get
            {
                return degrees;
            }
        }

        int minutes;
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("nevernii diapazon dly minutes");
                }
            }
            get
            {
                return minutes;
            }
        }

        int seconds;
        public int Seconds
        {
            set
            {
                if (value >= 0 && value<60)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("nevernii diapazon dly grad seconds");
                }
            }
            get
            {
                return seconds;
            }
        }
        public Corner(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void ZnachenieGrad()
        {
            Console.WriteLine("{0} grad {1} min {2} sec", degrees, minutes, seconds);
        }
        public void ToRad()
        {
            double degrees10 = degrees + (minutes / 60) + (seconds / 3600);
            Console.WriteLine("{0:0.000} rad", degrees10 * Math.PI/180);
        }
    }
}
