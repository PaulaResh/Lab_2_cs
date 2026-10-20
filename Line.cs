using System;

namespace LabWork
{
    public class Line : Shape
    {
        private Point _start;
        private Point _end;

        public Point Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public Point End
        {
            get { return _end; }
            set { _end = value; }
        }

        public Line(Point start, Point end)
            : base("Линия")
        {
            _start = start;
            _end = end;
        }

        public Line(double x1, double y1,
                    double x2, double y2)
            : base("Линия")
        {
            _start = new Point(x1, y1);
            _end = new Point(x2, y2);
        }

        public int GetLength()
        {
            double dx = _start.X - _end.X;
            double dy = _start.Y - _end.Y;
            double dist = Math.Sqrt(
                dx * dx + dy * dy);
            return (int)Math.Round(dist);
        }

        public override string GetInfo()
        {
            return $"от {_start.GetInfo()} " +
                   $"до {_end.GetInfo()}";
        }
    }
}
