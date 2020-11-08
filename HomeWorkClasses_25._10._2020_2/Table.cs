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
        public void ChangeValueLeftLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.LeftLower[0] = horizontalСoordinate;
            TableCoordinates.LeftLower[1] = verticalCoordinate;
        }
        public void ChangeValueRightLower(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.RightLower[0] = horizontalСoordinate;
            TableCoordinates.RightLower[1] = verticalCoordinate;
        }
        public void ChangeValueRightUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.RightUpper[0] = horizontalСoordinate;
            TableCoordinates.RightUpper[1] = verticalCoordinate;
        }
        public void ChangeValueLeftUpper(int horizontalСoordinate, int verticalCoordinate)
        {
            TableCoordinates.LeftUpper[0] = horizontalСoordinate;
            TableCoordinates.LeftUpper[1] = verticalCoordinate;
        }
        //public List<Table> GenerateRowTables()
        //{
        //    const int MIN_TABLE_COUNT = 4;
        //    const int MAX_TABLE_COUNT = 10;
        //    const int MIN_TABLE_LENGHT = 2;
        //    const int MAX_TABLE_LENGHT = 6;
        //    const int MIN_TABLE_WIDTH = 2;
        //    const int MAX_TABLE_WIDTH = 6;

        //    List<Table> rowTables = new List<Table>();
        //    Random rnd = new Random();
        //    int tableCount = rnd.Next(MIN_TABLE_COUNT, MAX_TABLE_COUNT);
        //    for (int i = 0; i < tableCount; i++)
        //    {
        //        int lenght = rnd.Next(MIN_TABLE_LENGHT, MAX_TABLE_LENGHT);
        //        int width = rnd.Next(MIN_TABLE_WIDTH, MAX_TABLE_WIDTH);
        //        Table table = new Table(lenght, width, i + 1);
        //        rowTables.Add(table);
        //    }
        //    return rowTables;
        //}
    }
}
