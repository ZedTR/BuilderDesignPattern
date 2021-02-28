using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Sedan : IFactoryMethodHolder
    {
        public string create() => "Sedan";
    }
}
