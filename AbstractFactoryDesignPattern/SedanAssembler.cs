using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class SedanAssembler : FactoryMethodProvider
    {

        public override IFactoryMethodHolder FactoryMethodHolder() => new Sedan();
    }
}
