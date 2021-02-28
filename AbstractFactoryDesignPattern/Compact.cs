using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class Compact : IFactoryMethodHolder
    {
        public string create() => "Compact";
    }
}
