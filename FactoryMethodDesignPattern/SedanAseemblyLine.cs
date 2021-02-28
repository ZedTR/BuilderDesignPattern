using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class SedanAseemblyLine : AssemblyLine
    {
        public override ICar FactoryMethod() => new Doors();
    }
}
