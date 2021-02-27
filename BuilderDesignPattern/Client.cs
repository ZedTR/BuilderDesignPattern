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

            Console.WriteLine("**************Basic House****************");

            bossMan.Builder = basicContractor;

            bossMan.BuildHouseStageOne();

            bossMan.BuildHouseComplete();

            Console.WriteLine("**************Fancy House***************");

            bossMan.Builder = fancyConstractor;

            bossMan.BuildHouseStageOne();

            bossMan.BuildHouseComplete();

        }
    }
}
