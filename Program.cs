class Program
{
    static void Main()
    {
        //ЗАДАНИЕ 1
        Console.WriteLine("ЗАДАНИЕ 1. Точка");

        // Создание точек из условия
        Point point1 = new Point(1.5, 2.0);
        Point point2 = new Point(3, 4);
        Point point3 = new Point(-5, 0.5);

        Console.WriteLine("Точки из условия:");
        Console.WriteLine(point1);
        Console.WriteLine(point2);
        Console.WriteLine(point3);

        // Дополнительная точка с вводом с клавиатуры
        Console.WriteLine("\nСоздание точки с вводом координат:");
        double x = InputHelper.ReadDouble("Введите координату X: ");
        double y = InputHelper.ReadDouble("Введите координату Y: ");
        Point pointFromInput = new Point(x, y);
        Console.WriteLine($"Созданная точка: {pointFromInput}");


        //ЗАДАНИЕ 2
        Console.WriteLine("\nЗАДАНИЕ 2. Линия");

        Line line1 = new Line(new Point(1, 3), new Point(23, 8));
        Line line2 = new Line(new Point(5, 10), new Point(25, 10));
        Line line3 = new Line(line1.Start, line2.End);

        Console.WriteLine("Изначальное состояние:");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"2: {line2}");
        Console.WriteLine($"3: {line3}");

        line1.Start.X = 10; line1.Start.Y = 10;
        line2.End.X = 30; line2.End.Y = 15;

        Console.WriteLine("\nПосле изменения координат Линий 1 и 2:");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"2: {line2}");
        Console.WriteLine($"3: {line3}");

        line1.Start = new Point(50, 50);

        Console.WriteLine("\nПосле замены начальной точки Линии 1 (Линия 3 не изменилась):");
        Console.WriteLine($"1: {line1}");
        Console.WriteLine($"3: {line3}");


        //ЗАДАНИЕ 3
        Console.WriteLine("\nЗАДАНИЕ 3. Студент");
        Student vasya = new Student("Вася", new int[] { 3, 4, 5 });
        Student petya = new Student("Петя", vasya.Grades);
        petya.Grades[0] = 5;

        Console.WriteLine("\nРезультат после изменения оценки Пети:");
        Console.WriteLine($"Вася: {vasya}");
        Console.WriteLine($"Петя: {petya}");

        Student andrey = new Student("Андрей", (int[])vasya.Grades.Clone());

        vasya.Grades[1] = 2;

        Console.WriteLine("\nПосле изменения оценки у Васи (Андрей не пострадал):");
        Console.WriteLine($"Вася:   {vasya}");
        Console.WriteLine($"Андрей: {andrey}");

        Console.WriteLine("\nСоздание студента с вводом данных: ");
        string studentName = InputHelper.ReadString("Введите имя студента: ");
        int[] studentGrades = InputHelper.ReadGrades(studentName);
        Student studentFromInput = new Student(studentName, studentGrades);
        Console.WriteLine($"Созданный студент: {studentFromInput}");


        //ЗАДАНИЕ 4
        Console.WriteLine("\nЗАДАНИЕ 4. Модифицированные Точка и Линия");

        // 4.1. Создание точек
        Console.WriteLine("4.1. Создание точек:");
        Point p4_1 = new Point(3, 5);
        Point p4_2 = new Point(25, 6);
        Point p4_3 = new Point(7, 8);
        Console.WriteLine(p4_1);
        Console.WriteLine(p4_2);
        Console.WriteLine(p4_3);

        // 4.2. Создание линий новыми конструкторами
        Console.WriteLine("\n4.2. Создание линий:");
        Line line4_1 = new Line(new Point(1, 3), new Point(23, 8));
        Line line4_2 = new Line(5, 10, 25, 10);
        Line line4_3 = new Line(line4_1.Start, line4_2.End);

        Console.WriteLine($"Линия 1: {line4_1}");
        Console.WriteLine($"Линия 2: {line4_2}");
        Console.WriteLine($"Линия 3: {line4_3}");


        //ЗАДАНИЕ 5
        Console.WriteLine("\nЗАДАНИЕ 5. Длина Линии");

        Console.WriteLine("\nСоздание линии с вводом координат");
        double x1 = InputHelper.ReadDouble("Введите X начала линии: ");
        double y1 = InputHelper.ReadDouble("Введите Y начала линии: ");
        double x2 = InputHelper.ReadDouble("Введите X конца линии: ");
        double y2 = InputHelper.ReadDouble("Введите Y конца линии: ");

        Line lineFromInput = new Line(x1, y1, x2, y2);
        Console.WriteLine($"Созданная линия: {lineFromInput}");
        Console.WriteLine($"Длина линии: {lineFromInput.GetLength()}");


        Console.WriteLine("\n[Нажмите любую клавишу для завершения...]");
        Console.ReadKey();
    }
}