﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder {  set => _builder = value; }

        private  House house = new House();

        public void BuildHouse()
        {
            
            _builder.BuildTiles();
            _builder.BuildWalls();
            _builder.BuildWindows();
            _builder.SetElectrics();
            _builder.SetInteriors();
            house = _builder.ShowHouse();
            Console.WriteLine(house.DisplayComponents());
            
        }


    }
}
