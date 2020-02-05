using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked = false;
        public Random generator = new Random();
        //public Car()
        //{
        //    int deciscion = generator.Next(1, 3);
        //    if (deciscion == 1)
        //    {
                
        //    }
        //}
        public bool Examine()
        {
            alreadyChecked = true;
            return false;
        }
        
    }
}
