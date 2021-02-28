using System;
using System.Collections.Generic;
using System.Text;

namespace AbrstractFactoryDesignPattern
{
    public class NoteBooks : IAbstractNoteBooks
    {
        public string GreenNoteBook {
            get =>"Green NoteBook";
            
            set => GreenNoteBook = value;
        }

        public string GreenTextBook {
            get => "Green Text Book";
            set => GreenTextBook = value; 
        }
        public string PrintBooks() =>  GreenNoteBook;


        public string PrintBook() => GreenTextBook;
    }
}
