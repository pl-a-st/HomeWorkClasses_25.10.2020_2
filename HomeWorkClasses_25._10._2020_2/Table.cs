using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
   public class Table
    {
        public int Length
        {
            get; private set;
        }
        public int Width
        {
            get; private set;
        }
        public int Number
        {
            get; private set;
        }
        public TableCoordinates TableCoordinates
        {
            get; private set;
        }
        public Table(int length, int width, int number)
        {
            Length = length;
            Width = width;
            Number = number;
        }
        public void AddTableСoordinates(TableCoordinates tableСoordinates)
        {
            TableCoordinates = tableСoordinates;
        }
      
        public void AddValueLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateLeftLower.Add(horizontalСoordinate);
            TableCoordinates.CoordinateLeftLower.Add(verticalCoordinate);
        }
        public void AddValueRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateRightLower.Add(horizontalСoordinate);
            TableCoordinates.CoordinateRightLower.Add(verticalCoordinate);
        }
        public void AddValueRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateRightUpper.Add(horizontalСoordinate);
            TableCoordinates.CoordinateRightUpper.Add(verticalCoordinate);
        }
        public void AddValueLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateLeftUpper.Add(horizontalСoordinate);
            TableCoordinates.CoordinateLeftUpper.Add(verticalCoordinate);
        }
        public void ChangeValueLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateLeftLower[0] = horizontalСoordinate;
            TableCoordinates.CoordinateLeftLower[1] = verticalCoordinate;
        }
        public void ChangeValueRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateRightLower[0] = horizontalСoordinate;
            TableCoordinates.CoordinateRightLower[1] = verticalCoordinate;
        }
        public void ChangeValueRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateRightUpper[0] = horizontalСoordinate;
            TableCoordinates.CoordinateRightUpper[1] = verticalCoordinate;
        }
        public void ChangeValueLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.CoordinateLeftUpper[0] = horizontalСoordinate;
            TableCoordinates.CoordinateLeftUpper[1] = verticalCoordinate;
        }
    }
}
