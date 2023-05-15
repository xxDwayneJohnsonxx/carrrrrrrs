using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class CAr
    {
        public CAr(int mpg)
        {
            m_mpg = mpg;
        
        }
        public Boolean left { get; set; }
        public Boolean right { get; set; }
            
        public Boolean brake {get; set; }

        public Boolean gas { get; set; }
        int m_speed;
        double m_pct = 1;
        int m_mpg;
        public int speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                m_pct = 1 - Math.Abs(55 - speed) / 100.0;
                m_speed = value;
            }

        }
        public int mpg
        {
            get {
                return (int)(m_pct * m_mpg);
            }
        
        }
        public void Drive()
        {
            if (gas)
            {
                speed += 5;
                if (speed > 130)
                    speed = 130;
            }
            if (brake)
            { 
                speed -= 8;
                if (speed<0)
                    speed=0;
            
            }
        
        }
    }
}
