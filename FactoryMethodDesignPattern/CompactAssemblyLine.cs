using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class CompactAssemblyLine : AssemblyLine
    {
        public override ICar FactoryMethod() => new Engine();
    }
}
