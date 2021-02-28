using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public class TextBooks : IAbstractTextBooks
    {
        public string RedNoteBook {
            get => "Red Note Book";
            set => RedNoteBook = value; 
        }

        public string RedTextBook { 
            get => "Red Text Book";
            set => RedTextBook = value;
        }
        public string PrintBook()
        {
            return RedNoteBook;
        }

        public string PrintABook()
        {
            return RedTextBook;
        }

        public string PrintTextBookWithNoteBook(IAbstractNoteBooks abstractNoteBooks)
        {
            return abstractNoteBooks.PrintBooks()  +" "+ RedTextBook;
        }
    }
}
