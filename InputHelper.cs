public static class InputHelper
{
    public static int ReadInt(string prompt, bool allowNegative = true)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                if (!allowNegative && result < 0)
                {
                    Console.WriteLine("Ошибка: число не может быть отрицательным. Попробуйте снова.");
                    continue;
                }
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное число. Попробуйте снова.");
            }
        }
    }

    public static double ReadDouble(string prompt, bool allowNegative = true)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double result))
            {
                if (!allowNegative && result < 0)
                {
                    Console.WriteLine("Ошибка: число не может быть отрицательным. Попробуйте снова.");
                    continue;
                }
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное число. Попробуйте снова.");
            }
        }
    }
    public static string ReadString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Ошибка: строка не может быть пустой. Попробуйте снова.");
            }
        }
    }
    public static int[] ReadGrades(string studentName)
    {
        Console.WriteLine($"\nВвод оценок для студента {studentName}:");
        int count = ReadInt("Введите количество оценок: ", false);

        if (count == 0)
        {
            Console.WriteLine("Предупреждение: количество оценок равно 0.");
            return new int[0];
        }

        int[] grades = new int[count];
        for (int i = 0; i < count; i++)
        {
            grades[i] = ReadInt($"Введите оценку #{i + 1} (от 2 до 5): ", false);

            // Дополнительная проверка диапазона оценок
            while (grades[i] < 2 || grades[i] > 5)
            {
                Console.WriteLine("Ошибка: оценка должна быть от 2 до 5. Попробуйте снова.");
                grades[i] = ReadInt($"Введите оценку #{i + 1} (от 2 до 5): ", false);
            }
        }

        return grades;
    }
}