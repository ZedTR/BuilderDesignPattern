using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public interface IAbstractTextBooks
    {
        string PrintABook();

        string PrintBook();

        string PrintTextBookWithNoteBook(IAbstractNoteBooks abstractNoteBooks);
    }
}
