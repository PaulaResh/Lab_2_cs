class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 1. Точка\n");

        Console.WriteLine("Введите координаты первой точки:");
        double x1 = InputHelper.ReadDouble("X: ");
        double y1 = InputHelper.ReadDouble("Y: ");
        Point point1 = new Point(x1, y1);

        Console.WriteLine("\nВведите координаты второй точки:");
        double x2 = InputHelper.ReadDouble("X: ");
        double y2 = InputHelper.ReadDouble("Y: ");
        Point point2 = new Point(x2, y2);

        Console.WriteLine("\nВведите координаты третьей точки:");
        double x3 = InputHelper.ReadDouble("X: ");
        double y3 = InputHelper.ReadDouble("Y: ");
        Point point3 = new Point(x3, y3);

        Console.WriteLine("\nТекстовое представление точек:");
        Console.WriteLine(point1);
        Console.WriteLine(point2);
        Console.WriteLine(point3);


        //ЗАДАНИЕ 2
        Console.WriteLine("\nЗАДАНИЕ 2. Линия\n");

        Console.WriteLine("Введите координаты начала Линии 1:");
        double l1_start_x = InputHelper.ReadDouble("X: ");
        double l1_start_y = InputHelper.ReadDouble("Y: ");

        Console.WriteLine("Введите координаты конца Линии 1:");
        double l1_end_x = InputHelper.ReadDouble("X: ");
        double l1_end_y = InputHelper.ReadDouble("Y: ");

        Line line1 = new Line(new Point(l1_start_x, l1_start_y), new Point(l1_end_x, l1_end_y));

        Console.WriteLine("\nВведите координаты начала Линии 2 (горизонтальной):");
        double l2_start_x = InputHelper.ReadDouble("X начала: ");
        double l2_y = InputHelper.ReadDouble("Y (высота): ");

        Console.WriteLine("Введите координату X конца Линии 2:");
        double l2_end_x = InputHelper.ReadDouble("X конца: ");

        Line line2 = new Line(new Point(l2_start_x, l2_y), new Point(l2_end_x, l2_y));

        Line line3 = new Line(line1.Start, line2.End);

        Console.WriteLine("\nИзначальное состояние:");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"2: {line2}");
        Console.WriteLine($"3: {line3}");

        Console.WriteLine("\nИзменение координат Линий 1 и 2");

        Console.WriteLine("\nВведите новые координаты начала Линии 1:");
        line1.Start.X = InputHelper.ReadDouble("X: ");
        line1.Start.Y = InputHelper.ReadDouble("Y: ");

        Console.WriteLine("\nВведите новые координаты конца Линии 2:");
        line2.End.X = InputHelper.ReadDouble("X: ");
        line2.End.Y = InputHelper.ReadDouble("Y: ");

        Console.WriteLine("\nПосле изменения координат:");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"2: {line2}");
        Console.WriteLine($"3: {line3}");

        Console.WriteLine("\nЗамена начальной точки Линии 1 (Линия 3 не изменится)");

        Console.WriteLine("\nВведите координаты новой начальной точки Линии 1:");
        double new_start_x = InputHelper.ReadDouble("X: ");
        double new_start_y = InputHelper.ReadDouble("Y: ");

        line1.Start = new Point(new_start_x, new_start_y);

        Console.WriteLine("\nПосле замены начальной точки:");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"3: {line3}");


        //ЗАДАНИЕ 3
        Console.WriteLine("\nЗАДАНИЕ 3. Студент\n");

        Console.WriteLine("Создание студента Вася");
        string vasyaName = "Вася";
        int[] vasyaGrades = InputHelper.ReadGrades(vasyaName);
        Student vasya = new Student(vasyaName, vasyaGrades);

        Console.WriteLine("\nСоздание студента Петя (копирование оценок Васи)");
        Student petya = new Student("Петя", vasya.Grades);

        Console.WriteLine("\nВведите новую первую оценку для Пети:");
        int newGrade = InputHelper.ReadInt("Оценка (от 2 до 5): ", false);
        while (newGrade < 2 || newGrade > 5)
        {
            Console.WriteLine("Ошибка: оценка должна быть от 2 до 5.");
            newGrade = InputHelper.ReadInt("Оценка (от 2 до 5): ", false);
        }

        petya.Grades[0] = newGrade;

        Console.WriteLine("\nРезультат после изменения оценки Пети:");
        Console.WriteLine($"Вася: {vasya}");
        Console.WriteLine($"Петя: {petya}");

        Console.WriteLine("\nСоздание студента Андрей (независимая копия оценок)");
        Student andrey = new Student("Андрей", (int[])vasya.Grades.Clone());

        Console.WriteLine("\nВведите новую вторую оценку для Васи:");
        int vasyaNewGrade = InputHelper.ReadInt("Оценка (от 2 до 5): ", false);
        while (vasyaNewGrade < 2 || vasyaNewGrade > 5)
        {
            Console.WriteLine("Ошибка: оценка должна быть от 2 до 5.");
            vasyaNewGrade = InputHelper.ReadInt("Оценка (от 2 до 5): ", false);
        }

        vasya.Grades[1] = vasyaNewGrade;

        Console.WriteLine("\nПосле изменения оценки у Васи (Андрей не пострадал):");
        Console.WriteLine($"Вася:   {vasya}");
        Console.WriteLine($"Андрей: {andrey}");


        //ЗАДАНИЕ 4
        Console.WriteLine("\nЗАДАНИЕ 4. Модифицированные Точка и Линия\n");

        // 4.1. Создание точек
        Console.WriteLine("4.1. Создание точек");

        Console.WriteLine("\nВведите координаты первой точки (Задание 4.1):");
        double p4_1_x = InputHelper.ReadDouble("X: ");
        double p4_1_y = InputHelper.ReadDouble("Y: ");
        Point p4_point1 = new Point(p4_1_x, p4_1_y);

        Console.WriteLine("\nВведите координаты второй точки (Задание 4.1):");
        double p4_2_x = InputHelper.ReadDouble("X: ");
        double p4_2_y = InputHelper.ReadDouble("Y: ");
        Point p4_point2 = new Point(p4_2_x, p4_2_y);

        Console.WriteLine("\nВведите координаты третьей точки (Задание 4.1):");
        double p4_3_x = InputHelper.ReadDouble("X: ");
        double p4_3_y = InputHelper.ReadDouble("Y: ");
        Point p4_point3 = new Point(p4_3_x, p4_3_y);

        Console.WriteLine("\nСозданные точки:");
        Console.WriteLine(p4_point1);
        Console.WriteLine(p4_point2);
        Console.WriteLine(p4_point3);

        // 4.2. Создание линий
        Console.WriteLine("\n4.2. Создание линий");

        Console.WriteLine("\nВведите координаты начала Линии 1 (Задание 4.2):");
        double l4_1_start_x = InputHelper.ReadDouble("X: ");
        double l4_1_start_y = InputHelper.ReadDouble("Y: ");

        Console.WriteLine("Введите координаты конца Линии 1:");
        double l4_1_end_x = InputHelper.ReadDouble("X: ");
        double l4_1_end_y = InputHelper.ReadDouble("Y: ");

        Line line4_1 = new Line(new Point(l4_1_start_x, l4_1_start_y), new Point(l4_1_end_x, l4_1_end_y));

        Console.WriteLine("\nВведите координаты начала Линии 2 (через 4 числа):");
        double l4_2_x1 = InputHelper.ReadDouble("X1: ");
        double l4_2_y1 = InputHelper.ReadDouble("Y1: ");
        double l4_2_x2 = InputHelper.ReadDouble("X2: ");
        double l4_2_y2 = InputHelper.ReadDouble("Y2: ");

        Line line4_2 = new Line(l4_2_x1, l4_2_y1, l4_2_x2, l4_2_y2);

        Line line4_3 = new Line(line4_1.Start, line4_2.End);

        Console.WriteLine("\nСозданные линии:");
        Console.WriteLine($"Линия 1: {line4_1}");
        Console.WriteLine($"Линия 2: {line4_2}");
        Console.WriteLine($"Линия 3: {line4_3}");


        //ЗАДАНИЕ 5
        Console.WriteLine("\nЗАДАНИЕ 5. Длина Линии\n");

        Console.WriteLine("Введите координаты начала линии:");
        double l5_start_x = InputHelper.ReadDouble("X: ");
        double l5_start_y = InputHelper.ReadDouble("Y: ");

        Console.WriteLine("\nВведите координаты конца линии:");
        double l5_end_x = InputHelper.ReadDouble("X: ");
        double l5_end_y = InputHelper.ReadDouble("Y: ");

        Line line5 = new Line(l5_start_x, l5_start_y, l5_end_x, l5_end_y);

        Console.WriteLine($"\nСозданная линия: {line5}");
        Console.WriteLine($"Длина линии: {line5.GetLength()}");


        Console.WriteLine("\n[Нажмите любую клавишу для завершения...]");
        Console.ReadKey();
    }
}
