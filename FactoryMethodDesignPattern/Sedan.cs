using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Engine : ICar
    {
        public void create()
        {
            Console.WriteLine("Engine Created");
        }
    }
}
