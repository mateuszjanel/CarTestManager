using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccelerationService
    {
        //public float ToHundred { get; set; }
        public AccelerationService()
        {

        }
        //public AccelerationService(float toHundred)
        //{
        //    ToHundred = toHundred;
        //}

        public float CalculateAcceleration(float timeToHundred, int velocity = 100)
        {
            return velocity / timeToHundred;
        }
    }
}
