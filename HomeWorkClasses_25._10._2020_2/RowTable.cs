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
            const int MAX_TABLE_COUNT = 10;
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
            rowTables[0].AddValueLeftLower(0, 0);
            rowTables[0].AddValueRightLower(rowTables[0].Length-1, 0);
            rowTables[0].AddValueRightUpper(rowTables[0].Length-1, rowTables[0].Width-1);
            rowTables[0].AddValueLeftUpper(0, rowTables[0].Width-1);
            for (int i=1;i<rowTables.Count;i++)
            {
                rowTables[i].AddValueLeftLower(rowTables[i-1].TableCoordinates.RightLower[0]+minDistanceTable+1, 0);
                rowTables[i].AddValueRightLower(rowTables[i].TableCoordinates.LeftLower[0] + rowTables[i].Length-1, 0);
                rowTables[i].AddValueRightUpper(rowTables[i].TableCoordinates.RightLower[0], rowTables[i].Width-1);
                rowTables[i].AddValueLeftUpper(rowTables[i].TableCoordinates.LeftLower[0], rowTables[i].Width-1);
            }
        }
        public void AddTableCoordinateFiveCells(List<Table> rowTables)
        {
            int minDistanceTable = 5;
            Coordinates tableCoordinates = CreateTableCoordinate();
            rowTables[rowTables.Count - 1].AddTableСoordinates(tableCoordinates);
            if (rowTables.Count - 1 == 0)
            {
                rowTables[0].AddValueLeftLower(0, 0);
                rowTables[0].AddValueRightLower(rowTables[0].Length-1, 0);
                rowTables[0].AddValueRightUpper(rowTables[0].Length-1, rowTables[0].Width-1);
                rowTables[0].AddValueLeftUpper(0, rowTables[0].Width-1);
            }
            else
            {
                rowTables[rowTables.Count - 1].AddValueLeftLower(rowTables[rowTables.Count - 2].TableCoordinates.RightLower[0] + minDistanceTable + 1, 0);
                rowTables[rowTables.Count - 1].AddValueRightLower(rowTables[rowTables.Count - 1].TableCoordinates.LeftLower[0] + rowTables[rowTables.Count - 1].Length-1, 0);
                rowTables[rowTables.Count - 1].AddValueRightUpper(rowTables[rowTables.Count - 1].TableCoordinates.RightLower[0], rowTables[rowTables.Count - 1].Width-1);
                rowTables[rowTables.Count - 1].AddValueLeftUpper(rowTables[rowTables.Count - 1].TableCoordinates.LeftLower[0], rowTables[rowTables.Count - 1].Width-1);
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


    }
}
