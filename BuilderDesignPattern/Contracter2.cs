using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class Contracter2 : IBuilder
    {
        private readonly House house = new House();
        public void BuildTiles()
        {
            house.AddPart("Prestine Tiles");
            Console.WriteLine("Perstine Tiles Built");
        }

        public void BuildWalls()
        {
            house.AddPart("Perstine Wall");
            Console.WriteLine("Perstine Walls Built");
        }

        public void BuildWindows()
        {
            house.AddPart("Perstine Window");
            Console.WriteLine("Perstine Windows Built");
        }

        public void SetElectrics()
        {
            house.AddPart("Perstine Electric");
            Console.WriteLine("Perstine Electric Built");
        }

        public void SetInteriors()
        {
            house.AddPart("Perstine Inetrior");
            Console.WriteLine("Perstine Interiors Built");
        }

        public House ShowHouse()
        {
            return house;
        }
    }
}
