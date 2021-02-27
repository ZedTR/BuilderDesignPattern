using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public class TextBooksFactory : IAbstractFactory
    {
        public IAbstractNoteBooks ProduceAbstractNoteBooks()
        {
            return new NoteBooks();
        }

        public IAbstractTextBooks ProduceAbstractTextBooks()
        {
            return new TextBooks();
        }
    }
}
