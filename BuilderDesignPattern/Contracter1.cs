using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class Contracter1 : IBuilder
    {
        private readonly House house = new House();
        public void BuildTiles()
        {
            house.AddPart("Tiles");
            Console.WriteLine("Tiles Built");
        }

        public void BuildWalls()
        {
            house.AddPart("Walls");
            Console.WriteLine("Walls Built");
        }

        public void BuildWindows()
        {
            house.AddPart("Windows");
            Console.WriteLine("Windows mounted");
        }

        public void SetElectrics()
        {
            house.AddPart("Electric");
            Console.WriteLine("Electrics Built");
        }

        public void SetInteriors()
        {
            house.AddPart("Interiors");
            Console.WriteLine("Interiors Built");
        }

        public House ShowHouse()
        {
            return house;
        }
    }
}
