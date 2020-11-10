﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClasses_25._10._2020_2
{
    public class RowTable
    {
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
        public void CalculateRowCoordinateLeftUpperFiveCells(List<Table> rowTables)
        {
            int minDistanceTable = 5;

            rowTables[0].SetCoordinateLeftUpper(0, 0);            
            for (int i=1;i<rowTables.Count;i++)
            {
                rowTables[i].SetCoordinateLeftUpper(rowTables[i - 1].CoordinateLeftUpper.horizonte + rowTables[i].Length - 1 + minDistanceTable + 1, 0);
            }
        }
        public void AddNewTableFiveCells(List<Table> rowTables)
        {
            Table table = GenerateTable(rowTables.Count + 1);
            rowTables.Add(table);
            AddTableCoordinateFiveCells(rowTables);
        }
        public void AddTableCoordinateFiveCells(List<Table> rowTables)
        {
            int minDistanceTable = 5;
            if (rowTables.Count - 1 == 0)
            {
                CalculateRowCoordinateLeftUpperFiveCells(rowTables);
            }
            else
            {
                rowTables[rowTables.Count - 1].SetCoordinateLeftUpper(rowTables[rowTables.Count - 2].CoordinateLeftUpper.horizonte +
                    rowTables[rowTables.Count - 1].Length - 1 + minDistanceTable + 1, 0);
            }
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
        public void TurnTableInList(List<Table>RowTables,int NumberTable,int addingAngle)
        {
            foreach(Table nextTable in RowTables)
            {
                bool noTable=true;
                if (nextTable.Number==NumberTable)
                {
                    nextTable.TurnTable(addingAngle);
                    noTable = false;
                }
                if (noTable)
                {
                    Console.WriteLine("Указанный стол отсутствует в рдяе столов");
                }
            }
        }
        public void TurnAllTableInList(List<Table> RowTables,int addingAngle)
        {
            foreach (Table nextTable in RowTables)
            {
                nextTable.TurnTable(addingAngle);
            }
        }

    }
}
