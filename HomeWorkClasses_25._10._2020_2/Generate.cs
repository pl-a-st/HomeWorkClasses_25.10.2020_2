using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class Generate
    {
        List<Table> RowTables;
        public void CreateRowTables()
        {
            if (RowTables == null)
            {
                List<Table> rowTables = new List<Table>();
                RowTables = rowTables;
            }
        }
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


    }
}
