using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            FactoryMethodProvider sedanMaker = new SedanAssembler();
            Console.WriteLine(sedanMaker.CreateCar());

            FactoryMethodProvider compactMaker = new CompactAssembler();
            Console.WriteLine(compactMaker.CreateCar());

            
        }
    }
}
