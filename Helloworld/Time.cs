using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Time : ITime
    {
        public Time() { }

        private DateTime time()
        {
            return DateTime.Now;
        }

        DateTime ITime.time()
        {
            throw new NotImplementedException();
        }
    }
}
