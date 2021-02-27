using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public interface IAbstractFactory
    {
        IAbstractNoteBooks ProduceAbstractNoteBooks();

        IAbstractTextBooks ProduceAbstractTextBooks();
    }
}
