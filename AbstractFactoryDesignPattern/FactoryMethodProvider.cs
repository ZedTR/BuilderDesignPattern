using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public abstract class FactoryMethodProvider
    {
        public abstract IFactoryMethodHolder FactoryMethodHolder();

        public string CreateCar() => FactoryMethodHolder().create() + " Car Created";
    }
}
