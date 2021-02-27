using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public interface IAbstractTextBooks
    {
        string PrintTextBook();

        string PrintNoteBook();

        string PrintTextBookWithNoteBook(IAbstractNoteBooks abstractNoteBooks);
    }
}
