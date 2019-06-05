using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var localSample = new LocalAngleTest();

            var getList=localSample.CombertHTML();

            foreach(var data in getList)
            {
                Console.WriteLine(data);
            }

        }
    }
}
