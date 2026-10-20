using System;

namespace LabWork
{
    public static class InputHelper
    {
        public static int ReadInt(
            string prompt,
            bool allowNegative = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(
                        input, out int result))
                {
                    if (!allowNegative
                        && result < 0)
                    {
                        Console.WriteLine(
                            "Ошибка: число " +
                            "не может быть " +
                            "отрицательным.");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: введено " +
                        "некорректное число.");
                }
            }
        }

        public static double ReadDouble(
            string prompt,
            bool allowNegative = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(
                        input, out double result))
                {
                    if (!allowNegative
                        && result < 0)
                    {
                        Console.WriteLine(
                            "Ошибка: число " +
                            "не может быть " +
                            "отрицательным.");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: введено " +
                        "некорректное число.");
                }
            }
        }

        public static string ReadString(
            string prompt)
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
                    Console.WriteLine(
                        "Ошибка: строка " +
                        "не может быть пустой.");
                }
            }
        }

        public static int[] ReadGrades(
            string studentName)
        {
            Console.WriteLine(
                $"Ввод оценок для " +
                $"{studentName}:");
            int count = ReadInt(
                "Количество оценок: ", false);

            if (count == 0)
            {
                return new int[0];
            }

            int[] grades = new int[count];
            for (int i = 0; i < count; i++)
            {
                grades[i] = ReadInt(
                    $"Оценка #{i + 1} (2-5): ",
                    false);

                while (grades[i] < 2
                       || grades[i] > 5)
                {
                    Console.WriteLine(
                        "Ошибка: оценка " +
                        "должна быть от 2 до 5.");
                    grades[i] = ReadInt(
                        $"Оценка #{i + 1} (2-5): ",
                        false);
                }
            }

            return grades;
        }
    }
}
