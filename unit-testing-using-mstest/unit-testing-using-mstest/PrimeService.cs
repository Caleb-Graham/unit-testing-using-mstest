using System;
using System.Collections.Generic;
using System.Text;

namespace unit_testing_using_mstest
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }


    }
}
