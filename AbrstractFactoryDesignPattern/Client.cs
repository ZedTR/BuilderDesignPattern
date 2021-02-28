using System;

namespace AbrstractFactoryDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = new NoteBooksFactory();

            Console.WriteLine("********Note Book Factory*********");
            Console.WriteLine(factory.ProduceAbstractNoteBooks().PrintBooks());
            Console.WriteLine(factory.ProduceAbstractTextBooks().PrintBook());

            IAbstractFactory abstractFactory = new TextBooksFactory();
            IAbstractNoteBooks noteBooks = new NoteBooks();

            Console.WriteLine("********Text Book Factory********");
            Console.WriteLine(abstractFactory.ProduceAbstractNoteBooks().PrintBook());
            Console.WriteLine(abstractFactory.ProduceAbstractTextBooks().PrintABook());
            Console.WriteLine(abstractFactory.ProduceAbstractTextBooks().PrintTextBookWithNoteBook(noteBooks));
            
        }
    }
}
