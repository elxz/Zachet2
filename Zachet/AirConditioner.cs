using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    public class AirConditioner
    {
        private int temperature { get; set; }
        private int speed { get; set; }

        public AirConditioner(int temperature, int speed)
        {
            this.temperature = temperature;
            this.speed = speed;
        }

        public void IncreaseTemp()
        {
            if(temperature < 30)
            {
                temperature = temperature + 1;
            }
        }
        public void DecreaseTemp()
        {
            if(Temperature > 10)
            {
                Temperature = temperature - 1; ;
            }
        }
        public void IncreaseSpeed()
        {
            if(speed < 10)
            {
                speed = speed + 1; ;
            }
            else if(speed == 10)
            {
                speed = 1;
            }
        }
        public void DecreaseSpeed()
        {
            if(speed > 1)
            {
                speed = speed - 1;
            }
            else if(speed == 1)
            {
                speed = 10;
            }
        }

        public int Temperature
        {
            get => temperature;
            set
            {
                if (value < 10) throw new ArgumentException();
                else if (value > 30) throw new ArgumentException();
                else temperature = value;
            }
        }

        public int Speed
        {
            get => speed;
            set
            {
                if (value > 10) throw new ArgumentException();
                else if (value < 1) throw new ArgumentException();
                else speed = value;
            }
        }
    }
}
