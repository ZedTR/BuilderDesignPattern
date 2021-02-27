using System;

namespace AbrstractFactoryDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = new NoteBooksFactory();

            Console.WriteLine("********Note Book Factory*********");
            Console.WriteLine(factory.ProduceAbstractNoteBooks().PrintNoteBooks());
            Console.WriteLine(factory.ProduceAbstractTextBooks().PrintNoteBook());

            IAbstractFactory abstractFactory = new TextBooksFactory();
            IAbstractNoteBooks noteBooks = new NoteBooks();

            Console.WriteLine("********Text Book Factory********");
            Console.WriteLine(abstractFactory.ProduceAbstractNoteBooks().PrintTextBook());
            Console.WriteLine(abstractFactory.ProduceAbstractTextBooks().PrintTextBook());
            Console.WriteLine(abstractFactory.ProduceAbstractTextBooks().PrintTextBookWithNoteBook(noteBooks));
            
        }
    }
}
