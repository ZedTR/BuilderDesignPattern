using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public abstract  class AssemblyLine
    {
        public abstract ICar FactoryMethod();

        public string Assemble() => FactoryMethod() + "Factory Called";
    }
}
