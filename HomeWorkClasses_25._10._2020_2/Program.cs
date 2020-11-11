using System;
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
            rowTableService.SetRowLeftUpperFiveCells(rowTables);
            Menu(rowTables);
        }
        static void Menu(List<Table> rowTables)
        {
            RowTable rowTableService = new RowTable();
            Console.WriteLine("");
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Вывести координаты ряда столов.");
            Console.WriteLine("2. Повернуть стол на 90 градусов вправо.");
            Console.WriteLine("3. Повернуть стол на 90 градусов влево.");
            Console.WriteLine("4. Повернуть все столы на 90 градусов вправо.");
            Console.WriteLine("5. Повернуть все столы на 90 градусов влево.");
            Console.WriteLine("6. Добавить новый стол.");
            Console.WriteLine("7. Удалить стол.");
            Console.WriteLine("8. Выход");
            Console.Write("Введите номер пунта меню:");
            string menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                rowTableService.PrintRowTable(rowTables);
                Menu(rowTables);
            }
            if (menuItem=="2")
            {
                rowTableService.TurnTableInList(rowTables,-90);
                Menu(rowTables);
            }
            if (menuItem == "3")
            {
                rowTableService.TurnTableInList(rowTables, 90);
                Menu(rowTables);
            }
            if (menuItem == "4")
            {
                rowTableService.TurnAllTableInList(rowTables, -90);
                Menu(rowTables);
            }
            if (menuItem == "5")
            {
                rowTableService.TurnAllTableInList(rowTables, 90);
                Menu(rowTables);
            }
            if (menuItem == "6")
            {
                rowTableService.AddNewTableFiveCells(rowTables);
                Menu(rowTables);
            }
            if (menuItem == "7")
            {
                rowTableService.DeleteTable(rowTables);
                Menu(rowTables);
            }
            if (menuItem == "8")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Вы ввели значение не из меню.");
            Menu(rowTables);
        }
        
    }
}
