using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Doors : ICar
    {
        public void create()
        {
            Console.WriteLine("Compact Created");
        }
    }
}
