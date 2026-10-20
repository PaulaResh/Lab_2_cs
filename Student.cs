using System;

namespace LabWork
{
    public class Student : Person
    {
        private int[] _grades;

        public int[] Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(string name, int[] grades)
            : base(name)
        {
            _grades = grades;
        }

        public override string ToString()
        {
            string gradesStr =
                string.Join(", ", _grades);
            return $"{Name}: [{gradesStr}]";
        }
    }
}
