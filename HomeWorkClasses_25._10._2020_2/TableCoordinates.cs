using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class TableCoordinates
    {
        public List<int> CoordinateLeftLower
        { get; private set; }
        public List<int> CoordinateRightLower
        { get; private set; }
        public List<int> CoordinateRightUpper
        { get; private set; }
        public List<int> CoordinateLeftUpper
        { get; private set; }
        public List<List<int>> PartsTableCoordinate
        { get; private set; }
        public TableCoordinates(List<int> coordinateLeftLower, List<int> coordinateRightLower,
                List<int> coordinateRightUpper, List<int> coordinateLeftUpper)
        {
            CoordinateLeftLower = coordinateLeftLower;
            CoordinateRightLower = coordinateRightLower;
            CoordinateRightUpper = coordinateRightUpper;
            CoordinateLeftUpper = coordinateLeftUpper;
        }
        public void AddTableCoordinates()
        {
            if (PartsTableCoordinate == null)
            {
                List<List<int>> partsTableCoordinate = new List<List<int>>();
                PartsTableCoordinate = partsTableCoordinate;
            }
            PartsTableCoordinate.Add(CoordinateLeftUpper);
            PartsTableCoordinate.Add(CoordinateRightUpper);
            PartsTableCoordinate.Add(CoordinateRightLower);
            PartsTableCoordinate.Add(CoordinateLeftLower);
        }
        

    }
}

