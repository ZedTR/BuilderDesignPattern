using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public interface IBuilder
    {
        void BuildWalls();

        void BuildTiles();

        void BuildWindows();

        void SetElectrics();

        void SetInteriors();

        House ShowHouse();
    }
}
