public class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public Student(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    //Имя: [оценка1, оценка2,…,оценкаN]
    public override string ToString()
    {
        string gradesStr = string.Join(", ", Grades);
        return $"{Name}: [{gradesStr}]";
    }
}