﻿using System;
using System.Collections.Generic;

namespace HomeWorkClasses_25._10._2020_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 Имеются несколько столов разного размера. Предполагается, что столы стоят на клетках и эти" +
                " клетки можно сосчитать, размеры стола кратны размеру клетки. Например стол 3:2 занимает 3 клетки в длину и " +
                "2 в ширину (всего 6 клеток). Количество столов генерируется. Предполагается, что каждый стол отстоит от " +
                "следующего от на 5 клеток вправо. Необходимо написать методы, которые бы: - выводили координаты угловых клеток " +
                "стола (например 0:0, 0:3, 2:0, 2:3) - поворачивали стол на 90 градусов вправо - поворачивали стол на 90" +
                " градусов влево Должно быть меню: добавить новый стол, убрать стол по индексу, повернуть все столы на 90 " +
                "градусов (в каждую из сторон), повернуть один столов (вводить номер стола) на 90 градусов (в каждую из " +
                "сторон). 2* Всё то же самое, но столы отстоят друг от друга на расстоянии 1 клетки вправо. Оценивать при " +
                "повороте, какие столы будут конфликтовать за расположение, уведомлять об этом и оставлять первый тогда без " +
                "поворота, а если конфликт по-прежнему будет, то не поворачивать и второй.");
            RowTable rowTableService = new RowTable();
            List<Table> rowTables = rowTableService.GenerateRowTables();
            rowTableService.AddRowTablesCoordinateFiveCells(rowTables);
            rowTableService.AddNewTableFiveCells(rowTables);
            rowTableService.DeleteTable(rowTables);
            foreach (Table nextTable in rowTables)
            {
                Console.WriteLine("Стол {0} ЛН:{1},{2} ПН:{3},{4} ПВ:{5},{6} ЛВ:{7},{8} длина:{9} ширина:{10}", nextTable.Number,
                    nextTable.TableCoordinates.LeftLower[0], nextTable.TableCoordinates.LeftLower[1],
                    nextTable.TableCoordinates.RightLower[0], nextTable.TableCoordinates.RightLower[1],
                    nextTable.TableCoordinates.RightUpper[0], nextTable.TableCoordinates.RightUpper[1],
                    nextTable.TableCoordinates.LeftUpper[0], nextTable.TableCoordinates.LeftUpper[1],
                    nextTable.Length, nextTable.Width);
            }
            rowTables[0].TurnTable();
            foreach (Table nextTable in rowTables)
            {
                Console.WriteLine("Стол {0} ЛН:{1},{2} ПН:{3},{4} ПВ:{5},{6} ЛВ:{7},{8} длина:{9} ширина:{10}", nextTable.Number,
                    nextTable.TableCoordinates.LeftLower[0], nextTable.TableCoordinates.LeftLower[1],
                    nextTable.TableCoordinates.RightLower[0], nextTable.TableCoordinates.RightLower[1],
                    nextTable.TableCoordinates.RightUpper[0], nextTable.TableCoordinates.RightUpper[1],
                    nextTable.TableCoordinates.LeftUpper[0], nextTable.TableCoordinates.LeftUpper[1],
                    nextTable.Length, nextTable.Width);
            }

        }
        
    }
}
