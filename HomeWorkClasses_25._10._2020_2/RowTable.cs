using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class RowTable
    {
        public Coordinates CreateTableCoordinate()
        {
            List<int> coordinateLeftLower = new List<int>();
            List<int> coordinateRightLower = new List<int>();
            List<int> coordinateRightUpper = new List<int>();
            List<int> coordinateLeftUpper = new List<int>();
            Coordinates tableCoordinates = new Coordinates(coordinateLeftLower, coordinateRightLower,
                coordinateRightUpper, coordinateLeftUpper);
            tableCoordinates.AddTableCoordinates();
            return tableCoordinates;
        }
        public Table GenerateTable(int numberTable)
        {
            const int MIN_TABLE_LENGHT = 2;
            const int MAX_TABLE_LENGHT = 6;
            const int MIN_TABLE_WIDTH = 2;
            const int MAX_TABLE_WIDTH = 6;
            Random rnd =new Random();
            int lenght = rnd.Next(MIN_TABLE_LENGHT, MAX_TABLE_LENGHT+1);
            int width = rnd.Next(MIN_TABLE_WIDTH, MAX_TABLE_WIDTH+1);
            Table table = new Table(lenght, width, numberTable);
            return table;
        }
        public List<Table> GenerateRowTables()
        {
            const int MIN_TABLE_COUNT = 3;
            const int MAX_TABLE_COUNT = 5;
            const int MIN_TABLE_LENGHT = 2;
            const int MAX_TABLE_LENGHT = 6;
            const int MIN_TABLE_WIDTH = 2;
            const int MAX_TABLE_WIDTH = 6;

            List<Table> rowTables = new List<Table>();
            Random rnd =new Random();
            int tableCount = rnd.Next(MIN_TABLE_COUNT, MAX_TABLE_COUNT+1);
            for (int i=0;i<tableCount;i++)
            {
                int lenght = rnd.Next(MIN_TABLE_LENGHT, MAX_TABLE_LENGHT+1);
                int width = rnd.Next(MIN_TABLE_WIDTH, MAX_TABLE_WIDTH+1);
                Table table = new Table(lenght, width, i + 1);
                rowTables.Add(table);
            }
            return rowTables;
        }
        public void AddRowTablesCoordinateFiveCells(List<Table> rowTables)
        {
            int minDistanceTable = 5;
            foreach (Table nextTables in rowTables)
            {
                Coordinates tableCoordinates = CreateTableCoordinate();
                nextTables.AddTableСoordinates(tableCoordinates);
            }
            rowTables[0].AddValueLeftUpper(0, 0);
            int horCoordinate = rowTables[0].TableCoordinates.LeftUpper[0];
            int vertCoordinate = rowTables[0].TableCoordinates.LeftUpper[1];
            int sinAngle = Convert.ToInt32(Math.Sin(rowTables[0].Angle));
            int cosAngle = Convert.ToInt32(Math.Cos(rowTables[0].Angle));
            rowTables[0].AddValueLeftLower(horCoordinate + (rowTables[0].Width - 1) * sinAngle, vertCoordinate + (rowTables[0].Width - 1) * cosAngle);
            rowTables[0].AddValueRightUpper(horCoordinate + (rowTables[0].Length - 1) * cosAngle, vertCoordinate + (rowTables[0].Length - 1) * sinAngle);
            rowTables[0].AddValueRightLower(rowTables[0].TableCoordinates.RightUpper[0],rowTables[0].TableCoordinates.LeftLower[1]);
            
            for (int i=1;i<rowTables.Count;i++)
            {
                rowTables[i].AddValueLeftUpper(rowTables[i-1].TableCoordinates.RightUpper[0]+minDistanceTable+1, 0);
                horCoordinate = rowTables[i].TableCoordinates.LeftUpper[0];
                vertCoordinate = rowTables[i].TableCoordinates.LeftUpper[1];
                rowTables[i].AddValueLeftLower(horCoordinate + (rowTables[i].Width - 1) * sinAngle, vertCoordinate + (rowTables[i].Width - 1) * cosAngle);
                rowTables[i].AddValueRightUpper(horCoordinate + (rowTables[i].Length - 1) * cosAngle, vertCoordinate + (rowTables[i].Length - 1) * sinAngle);
                rowTables[i].AddValueRightLower(rowTables[i].TableCoordinates.RightUpper[0], rowTables[i].TableCoordinates.LeftLower[1]);
            }
        }
        public void AddTableCoordinateFiveCells(List<Table> rowTables)
        {
            int minDistanceTable = 5;
            Coordinates tableCoordinates = CreateTableCoordinate();
            rowTables[rowTables.Count - 1].AddTableСoordinates(tableCoordinates);
            if (rowTables.Count - 1 == 0)
            {
                rowTables[0].AddValueLeftUpper(0, 0);
                int horCoordinate = rowTables[0].TableCoordinates.LeftUpper[0];
                int vertCoordinate = rowTables[0].TableCoordinates.LeftUpper[1];
                int sinAngle = Convert.ToInt32(Math.Sin(rowTables[0].Angle));
                int cosAngle = Convert.ToInt32(Math.Cos(rowTables[0].Angle));
                rowTables[0].AddValueLeftLower(horCoordinate + (rowTables[0].Width - 1) * sinAngle, vertCoordinate + (rowTables[0].Width - 1) * cosAngle);
                rowTables[0].AddValueRightUpper(horCoordinate + (rowTables[0].Length - 1) * cosAngle, vertCoordinate + (rowTables[0].Length - 1) * sinAngle);
                rowTables[0].AddValueRightLower(rowTables[0].TableCoordinates.RightUpper[0], rowTables[0].TableCoordinates.LeftLower[1]);
            }
            else
            {
                rowTables[rowTables.Count - 1].AddValueLeftUpper(rowTables[rowTables.Count - 2].TableCoordinates.RightUpper[0] + minDistanceTable + 1, 0);
                int horCoordinate = rowTables[rowTables.Count - 1].TableCoordinates.LeftUpper[0];
                int vertCoordinate = rowTables[rowTables.Count - 1].TableCoordinates.LeftUpper[1];
                int sinAngle = Convert.ToInt32(Math.Sin(rowTables[rowTables.Count - 1].Angle));
                int cosAngle = Convert.ToInt32(Math.Cos(rowTables[rowTables.Count - 1].Angle));
                rowTables[rowTables.Count - 1].AddValueLeftLower(horCoordinate + (rowTables[rowTables.Count - 1].Width - 1) * sinAngle, vertCoordinate + (rowTables[rowTables.Count - 1].Width - 1) * cosAngle);
                rowTables[rowTables.Count - 1].AddValueRightUpper(horCoordinate + (rowTables[rowTables.Count - 1].Length - 1) * cosAngle, vertCoordinate + (rowTables[rowTables.Count - 1].Length - 1) * sinAngle);
                rowTables[rowTables.Count - 1].AddValueRightLower(rowTables[rowTables.Count - 1].TableCoordinates.RightUpper[0], rowTables[rowTables.Count - 1].TableCoordinates.LeftLower[1]);
            }
        }
        public void AddNewTableFiveCells(List<Table> rowTables)
        {
            Table table = GenerateTable(rowTables.Count + 1);
            rowTables.Add(table);
            AddTableCoordinateFiveCells(rowTables);
        }
        public void DeleteTable(List<Table> rowTables)
        {
            Console.Write("Укажите номер стола который необходимо удалить: ");
            try
            {
                int numberTable = Convert.ToInt32(Console.ReadLine());
                rowTables.RemoveAt(numberTable - 1);
                foreach(Table nextTable in rowTables)
                {
                    nextTable.NewNumber(rowTables.IndexOf(nextTable)+1);
                }
            }
            catch
            {
                Console.WriteLine("Указан неверный номер.");
                DeleteTable(rowTables);
            }
        }
        public void TurnTableInList(List<Table>RowTables,int NumberTable)
        {
            foreach(Table nextTable in RowTables)
            {
                bool noTable=true;
                if (nextTable.Number==NumberTable)
                {
                    nextTable.TurnTable();
                    noTable = false;
                }
                if (noTable)
                {
                    Console.WriteLine("Указанный стол отсутствует в рдяе столов");
                }
            }
        }
        public void TurnAllTableInList(List<Table> RowTables)
        {
            foreach (Table nextTable in RowTables)
            {
                nextTable.TurnTable();
            }
        }

    }
}
