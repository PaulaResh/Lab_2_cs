using System;

namespace LabWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Console.WriteLine("Задание 1. Точка");
            Point point1 = new Point(
                InputHelper.ReadDouble("X 1-й точки: "),
                InputHelper.ReadDouble("Y 1-й точки: "));
            Point point2 = new Point(
                InputHelper.ReadDouble("X 2-й точки: "),
                InputHelper.ReadDouble("Y 2-й точки: "));
            Point point3 = new Point(
                InputHelper.ReadDouble("X 3-й точки: "),
                InputHelper.ReadDouble("Y 3-й точки: "));

            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(point3);


            Console.WriteLine("\nЗадание 2. Линия");
            Line line1 = new Line(
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 1. X начала: "),
                    InputHelper.ReadDouble(
                        "Линия 1. Y начала: ")),
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 1. X конца: "),
                    InputHelper.ReadDouble(
                        "Линия 1. Y конца: ")));

            double l2Y = InputHelper.ReadDouble(
                "Линия 2. Высота (Y): ");
            Line line2 = new Line(
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 2. X начала: "),
                    l2Y),
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 2. X конца: "),
                    l2Y));

            Line line3 = new Line(
                line1.Start, line2.End);

            Console.WriteLine("Изначально:");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);

            Console.WriteLine(
                "\nИзменение линий 1 и 2:");
            line1.Start.X = InputHelper.ReadDouble(
                "Новый X начала линии 1: ");
            line1.Start.Y = InputHelper.ReadDouble(
                "Новый Y начала линии 1: ");
            line2.End.X = InputHelper.ReadDouble(
                "Новый X конца линии 2: ");
            line2.End.Y = InputHelper.ReadDouble(
                "Новый Y конца линии 2: ");

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);

            Console.WriteLine(
                "\nЗамена начала линии 1 " +
                "(линия 3 не изменится):");
            line1.Start = new Point(
                InputHelper.ReadDouble(
                    "Новый X начала линии 1: "),
                InputHelper.ReadDouble(
                    "Новый Y начала линии 1: "));

            Console.WriteLine(line1);
            Console.WriteLine(line3);


            Console.WriteLine(
                "\nЗадание 3. Студент");
            string vasyaName =
                InputHelper.ReadString(
                    "Имя первого студента: ");
            Student vasya = new Student(
                vasyaName,
                InputHelper.ReadGrades(vasyaName));

            Student petya = new Student(
                "Петя", vasya.Grades);
            int newGrade = InputHelper.ReadInt(
                "Новая первая оценка Пети (2-5): ",
                false);
            while (newGrade < 2 || newGrade > 5)
            {
                Console.WriteLine(
                    "Ошибка: оценка " +
                    "должна быть от 2 до 5.");
                newGrade = InputHelper.ReadInt(
                    "Новая первая оценка (2-5): ",
                    false);
            }
            petya.Grades[0] = newGrade;

            Console.WriteLine(
                "После изменения оценки Пети:");
            Console.WriteLine(vasya);
            Console.WriteLine(petya);
            Console.WriteLine(
                "Оба изменились, т.к. массив — " +
                "ссылочный тип.");

            Student andrey = new Student(
                "Андрей",
                (int[])vasya.Grades.Clone());
            int vasyaGrade = InputHelper.ReadInt(
                "Новая вторая оценка Васи (2-5): ",
                false);
            while (vasyaGrade < 2
                   || vasyaGrade > 5)
            {
                Console.WriteLine(
                    "Ошибка: оценка " +
                    "должна быть от 2 до 5.");
                vasyaGrade = InputHelper.ReadInt(
                    "Новая вторая оценка (2-5): ",
                    false);
            }
            vasya.Grades[1] = vasyaGrade;

            Console.WriteLine(
                "После изменения оценки Васи:");
            Console.WriteLine(vasya);
            Console.WriteLine(andrey);


            Console.WriteLine(
                "\nЗадание 4. " +
                "Модифицированные Точка и Линия");
            Point p4_1 = new Point(
                InputHelper.ReadDouble(
                    "Точка 4.1 #1 X: "),
                InputHelper.ReadDouble(
                    "Точка 4.1 #1 Y: "));
            Point p4_2 = new Point(
                InputHelper.ReadDouble(
                    "Точка 4.1 #2 X: "),
                InputHelper.ReadDouble(
                    "Точка 4.1 #2 Y: "));
            Point p4_3 = new Point(
                InputHelper.ReadDouble(
                    "Точка 4.1 #3 X: "),
                InputHelper.ReadDouble(
                    "Точка 4.1 #3 Y: "));

            Console.WriteLine(p4_1);
            Console.WriteLine(p4_2);
            Console.WriteLine(p4_3);

            Line line4_1 = new Line(
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 4.2 #1 X начала: "),
                    InputHelper.ReadDouble(
                        "Линия 4.2 #1 Y начала: ")),
                new Point(
                    InputHelper.ReadDouble(
                        "Линия 4.2 #1 X конца: "),
                    InputHelper.ReadDouble(
                        "Линия 4.2 #1 Y конца: ")));

            Line line4_2 = new Line(
                InputHelper.ReadDouble(
                    "Линия 4.2 #2 X1: "),
                InputHelper.ReadDouble(
                    "Линия 4.2 #2 Y1: "),
                InputHelper.ReadDouble(
                    "Линия 4.2 #2 X2: "),
                InputHelper.ReadDouble(
                    "Линия 4.2 #2 Y2: "));

            Line line4_3 = new Line(
                line4_1.Start, line4_2.End);

            Console.WriteLine(line4_1);
            Console.WriteLine(line4_2);
            Console.WriteLine(line4_3);


            Console.WriteLine(
                "\nЗадание 5. Длина линии");
            Line line5 = new Line(
                InputHelper.ReadDouble("X начала: "),
                InputHelper.ReadDouble("Y начала: "),
                InputHelper.ReadDouble("X конца: "),
                InputHelper.ReadDouble("Y конца: "));

            Console.WriteLine(line5);
            Console.WriteLine(
                $"Длина: {line5.GetLength()}");


            Console.WriteLine(
                "\nДемонстрация наследования:");
            Shape[] shapes = new Shape[]
            { point1, line1, p4_2, line4_1 };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(
                    $"{shape.GetType().Name}: " +
                    $"{shape}");
            }

            Console.WriteLine(
                "\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
