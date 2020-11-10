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
        public int Angle
        {
            get; private set;
        }
        public Coordinates TableCoordinates
        {
            get; private set;
        }
        public Table(int length, int width, int number)
        {
            Length = length;
            Width = width;
            Number = number;
        }
        public void AddAngle(int addingAngle)
        {
            Angle += addingAngle;
            while (Angle>360)
            {
                Angle -= 360;
            }
            while(Angle<0)
            {
                Angle += 360;
            }
        }

        public void NewNumber(int newNumber)
        {
            Number = newNumber;
        }
        public void AddTableСoordinates(Coordinates tableСoordinates)
        {
            TableCoordinates = tableСoordinates;
        }
      
        public void AddValueLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.LeftLower.Add(horizontalСoordinate);
            TableCoordinates.LeftLower.Add(verticalCoordinate);
        }
        public void AddValueRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.RightLower.Add(horizontalСoordinate);
            TableCoordinates.RightLower.Add(verticalCoordinate);
        }
        public void AddValueRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.RightUpper.Add(horizontalСoordinate);
            TableCoordinates.RightUpper.Add(verticalCoordinate);
        }
        public void AddValueLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.LeftUpper.Add(horizontalСoordinate);
            TableCoordinates.LeftUpper.Add(verticalCoordinate);
        }
        public void NewValueLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.getLeftLower(horizontalСoordinate, verticalCoordinate);
        }
        public void NewValueRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.getRightLower(horizontalСoordinate, verticalCoordinate);
        }
        public void NewValueRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.getRightUpper(horizontalСoordinate, verticalCoordinate);
        }
        public void NewValueLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.getLeftUpper(horizontalСoordinate, verticalCoordinate);
        }
        public void NewLength(int newLength)
        {
            Length = newLength;
        }
        public void NewWidth(int newWidth)
        {
            Width = newWidth;
        }
        public void TurnTable()
        {
            int newWidth = Length;
            int newLength = Width;
            NewLength(newLength);
            NewWidth(newWidth);
            NewValueRightLower(TableCoordinates.LeftLower[0] + Length-1, 0);
            NewValueRightUpper(TableCoordinates.LeftLower[0] + Length-1, Width-1);
            NewValueLeftUpper(TableCoordinates.LeftLower[0], Width - 1);
        }
    }
}
