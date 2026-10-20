using System;

namespace LabWork
{
    public abstract class Shape
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected Shape(string name)
        {
            _name = name;
        }

        public abstract string GetInfo();

        public override string ToString()
        {
            return $"[{Name}] {GetInfo()}";
        }
    }
}