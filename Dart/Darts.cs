using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dart
{

    public class Darts
    {
        private Random _random;
        public Darts(Random random)
        {
            _random = random;

        }

        public int Score // 95% chance of hitting
        {
            get;
            set;
        }
        
        public void Throw()
        {
            Score = _random.Next(0, 20);
            // show score
            //show if is double
            //show if is triple
            //show if is inner or outer bullseye
            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) tripleRing = true;
            else if (multiplier > 90 & multiplier <= 95) doubleRing = true;

        }

        public bool doubleRing { get; set; }//5% chance of hitting
        public bool tripleRing { get; set; }//5% chance of hitting
        public bool bullsEye { get; set; }// 5% chance of hitting --plus will be double or triple --number 0

    }
}
