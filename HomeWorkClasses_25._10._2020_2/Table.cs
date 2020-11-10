using System;
using System.Collections.Generic;
using System.Text;
public struct Coordinate
{
    public int horizonte;
    public int vertical;
}
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
        public Coordinate CoordinateLeftUpper
        {
            get; private set;
        }
        public Coordinate CoordinateLeftLower
        {
            get; private set;
        }
        public Coordinate CoordinateRightUpper
        {
            get; private set;
        }
        public Coordinate CoordinateRightLower
        {
            get; private set;
        }
        public Table(int length, int width, int number)
        {
            Length = length;
            Width = width;
            Number = number;
        }
        public void SetCoordinateLeftUpper(int horizonte, int vertical)
        {
            Coordinate coordinateLeftUpper = new Coordinate();
            coordinateLeftUpper.horizonte = horizonte;
            coordinateLeftUpper.vertical = vertical;
            CoordinateLeftUpper = coordinateLeftUpper;
            CalculateAllCoordinate();
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
        public void NewLength(int newLength)
        {
            Length = newLength;
        }
        public void NewWidth(int newWidth)
        {
            Width = newWidth;
        }
        public void TurnTable(int addingAngle)
        {
            AddAngle(addingAngle);
            CalculateAllCoordinate();
        }
        public void CalculateAllCoordinate()
        {
            Coordinate leftLower = new Coordinate();
            Coordinate rightUpper = new Coordinate();
            Coordinate rightLower = new Coordinate();
            leftLower.horizonte = CoordinateLeftUpper.horizonte + (Length-1) * Convert.ToInt32(Math.Sin(Angle)) + (Width - 1) * Convert.ToInt32(Math.Cos(Angle));
            leftLower.vertical = CoordinateLeftUpper.vertical + (Width - 1) * Convert.ToInt32(Math.Cos(Angle)) + (Length - 1) * Convert.ToInt32(Math.Sin(Angle));
            CoordinateLeftLower = leftLower;
            rightUpper.horizonte =CoordinateLeftUpper.horizonte + (Length - 1) * Convert.ToInt32(Math.Cos(Angle)) + (Width - 1) * Convert.ToInt32(Math.Sin(Angle));
            rightUpper.vertical = CoordinateLeftUpper.vertical + (Width - 1) * Convert.ToInt32(Math.Sin(Angle)) + (Length - 1) * Convert.ToInt32(Math.Cos(Angle));
            CoordinateRightUpper = rightUpper;
            rightLower.horizonte = rightUpper.horizonte* Convert.ToInt32(Math.Sin(Angle))+leftLower.horizonte* Convert.ToInt32(Math.Cos(Angle));
            rightLower.vertical= rightUpper.vertical* Convert.ToInt32(Math.Sin(Angle))+leftLower.vertical* Convert.ToInt32(Math.Cos(Angle));
            CoordinateRightLower = rightUpper;     
        }
    }
}
