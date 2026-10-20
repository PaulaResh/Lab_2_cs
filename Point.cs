using System;

namespace LabWork
{
    public class Point : Shape
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(double x, double y) : base("Точка")
        {
            _x = x;
            _y = y;
        }

        public override string GetInfo()
        {
            return $"{{{X};{Y}}}";
        }
    }
}
