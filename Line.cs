public class Line
{
    // Свойства для начала и конца линии
    public Point Start { get; set; }
    public Point End { get; set; }

    // Для задания 4.2
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    // Для задания 4.2
    public Line(double x1, double y1, double x2, double y2)
    {
        Start = new Point(x1, y1);
        End = new Point(x2, y2);
    }

    /// Метод вычисления длины линии (Задание 5).
    public int GetLength()
    {
        double dx = Start.X - End.X;
        double dy = Start.Y - End.Y;
        double distance = Math.Sqrt(dx * dx + dy * dy);

        return (int)Math.Round(distance);
    }
    public override string ToString()
    {
        return $"Линия от {Start} до {End}";
    }
}