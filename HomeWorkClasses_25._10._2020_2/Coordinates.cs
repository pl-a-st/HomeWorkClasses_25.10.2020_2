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
        public void getLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            LeftLower[0] = horizontalСoordinate;
            LeftLower[1] = verticalCoordinate;
        }
        public void getRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            RightLower[0] = horizontalСoordinate;
            RightLower[1] = verticalCoordinate;
        }
        public void getRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            RightUpper[0] = horizontalСoordinate;
            RightUpper[1] = verticalCoordinate;
        }
        public void getLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            LeftUpper[0] = horizontalСoordinate;
            LeftUpper[1] = verticalCoordinate;
        }
    }
}

