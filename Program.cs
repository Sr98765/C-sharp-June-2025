using System;

class StudentGrade
{
    public string? studentName;
    public int math;
    public int science;
    public int english;

    public double GetAverage()
    {
        return (math + science + english) / 3.0;
    }

    public bool HasPassed()
    {
        return GetAverage() >= 40;
    }
}

class Program
{
    public static void Main()
    {
        StudentGrade sg = new StudentGrade();
        sg.studentName = "Lina";
        sg.math = 50;
        sg.science = 40;
        sg.english = 30;

        Console.WriteLine($"Average: {sg.GetAverage()}");
        Console.WriteLine($"Passed: {sg.HasPassed()}");
    }
}
