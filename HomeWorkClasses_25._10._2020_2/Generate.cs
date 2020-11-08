using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class Generate
    {
        public TableCoordinates CreateTableCoordinate()
        {
            List<int> coordinateLeftLower = new List<int>();
            List<int> coordinateRightLower = new List<int>();
            List<int> coordinateRightUpper = new List<int>();
            List<int> coordinateLeftUpper = new List<int>();
            TableCoordinates tableCoordinates = new TableCoordinates(coordinateLeftLower, coordinateRightLower,
                coordinateRightUpper, coordinateLeftUpper);
            tableCoordinates.AddTableCoordinates();
            return tableCoordinates;
        }
        public List<Table> GenerateRowTables()
        {
            const int MIN_TABLE_COUNT = 4;
            const int MAX_TABLE_COUNT = 10;
            const int MIN_TABLE_LENGHT = 2;
            const int MAX_TABLE_LENGHT = 6;
            const int MIN_TABLE_WIDTH = 2;
            const int MAX_TABLE_WIDTH = 6;

            List<Table> rowTables = new List<Table>();
            Random rnd = new Random();
            int tableCount = rnd.Next(MIN_TABLE_COUNT, MAX_TABLE_COUNT);
            for (int i=0;i<tableCount;i++)
            {
                int lenght = rnd.Next(MIN_TABLE_LENGHT, MAX_TABLE_LENGHT);
                int width = rnd.Next(MIN_TABLE_WIDTH, MAX_TABLE_WIDTH);
                Table table = new Table(lenght, width, i + 1);
                rowTables.Add(table);
            }
            return rowTables;
        }
        public void AddRowTablesCoordinate(List<Table> rowTables)
        {
            int minDistanceTable = 5;
            foreach (Table nextTables in rowTables)
            {
                TableCoordinates tableCoordinates = CreateTableCoordinate();
                nextTables.AddTableСoordinates(tableCoordinates);
            }
            rowTables[0].AddValueLeftLower(0, 0);
            rowTables[0].AddValueRightLower(rowTables[0].Length, 0);
            rowTables[0].AddValueRightUpper(rowTables[0].Length, rowTables[0].Width);
            rowTables[0].AddValueLeftUpper(0, rowTables[0].Width);
            for (int i=1;i<rowTables.Count;i++)
            {
                rowTables[i].AddValueLeftLower(rowTables[i-1].TableCoordinates.CoordinateRightLower[0]+minDistanceTable+1, 0);
                rowTables[i].AddValueRightLower(rowTables[i].TableCoordinates.CoordinateLeftLower[0] + rowTables[i].Length, 0);
                rowTables[i].AddValueRightUpper(rowTables[i].TableCoordinates.CoordinateRightLower[0], rowTables[i].Width);
                rowTables[i].AddValueLeftUpper(rowTables[i].TableCoordinates.CoordinateLeftLower[0], rowTables[i].Width);
            }
        }


    }
}
