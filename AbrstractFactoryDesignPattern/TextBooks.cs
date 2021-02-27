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
        public string PrintNoteBook()
        {
            return RedNoteBook;
        }

        public string PrintTextBook()
        {
            return RedTextBook;
        }

        public string PrintTextBookWithNoteBook(IAbstractNoteBooks abstractNoteBooks)
        {
            return abstractNoteBooks.PrintNoteBooks()  +" "+ RedTextBook;
        }
    }
}
