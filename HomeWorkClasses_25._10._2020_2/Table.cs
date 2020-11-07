using System;
using System.Collections.Generic;
using System.Text;
public struct TableСoordinates
{
    public List<PartsTable> PartsTablesСoordinate;
}
public struct PartsTable
{
    public List<int> StartingLeftLowerCorner;
    public List<int> StartingRightLowerCorner;
    public List<int> StartingRightUpperCorner;
    public List<int> StartingLeftUpperCorner;
}

namespace HomeWorkClasses_25._10._2020_2
{
    class Table
    {
        public int Length;
        public int Width;
        public int Number;
        public TableСoordinates TableСoordinates;
        public Table(int length, int width, int number)
        {
            Length = length;
            Width = width;
            Number = number;
        }
    }
}
