using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class Coordinates
    {
        public List<int> LeftLower
        { get; private set; }
        public List<int> RightLower
        { get; private set; }
        public List<int> RightUpper
        { get; private set; }
        public List<int> LeftUpper
        { get; private set; }
        public List<List<int>> PartsTableCoordinate
        { get; private set; }
        public Coordinates(List<int> coordinateLeftLower, List<int> coordinateRightLower,
                List<int> coordinateRightUpper, List<int> coordinateLeftUpper)
        {
            LeftLower = coordinateLeftLower;
            RightLower = coordinateRightLower;
            RightUpper = coordinateRightUpper;
            LeftUpper = coordinateLeftUpper;
        }
        public void AddTableCoordinates()
        {
            if (PartsTableCoordinate == null)
            {
                List<List<int>> partsTableCoordinate = new List<List<int>>();
                PartsTableCoordinate = partsTableCoordinate;
            }
            PartsTableCoordinate.Add(LeftUpper);
            PartsTableCoordinate.Add(RightUpper);
            PartsTableCoordinate.Add(RightLower);
            PartsTableCoordinate.Add(LeftLower);
        }
        

    }
}

