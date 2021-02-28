using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class CompactAssembler : FactoryMethodProvider
    {
        public override IFactoryMethodHolder FactoryMethodHolder() => new Compact();
    }
}
