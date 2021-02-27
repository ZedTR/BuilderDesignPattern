using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    class NoteBooksFactory : IAbstractFactory
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
