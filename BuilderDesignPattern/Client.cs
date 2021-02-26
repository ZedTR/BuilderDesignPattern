using System;

namespace BuilderDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            var bossMan = new Director();

            var basicContractor = new Contracter1();

            var fancyConstractor = new Contracter2();

            bossMan.Builder = basicContractor;

            bossMan.BuildHouse();

            bossMan.Builder = fancyConstractor;

            bossMan.BuildHouse();

        }
    }
}
