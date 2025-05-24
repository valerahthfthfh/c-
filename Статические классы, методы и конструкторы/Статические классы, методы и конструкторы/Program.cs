using System;

public class Student  
{
    public string name { get; set; }  
    public string lastName { get; set; }
    public int learning { get; set; }  // успеваемость

    
    public Student(string name, string lastName, int learning)
    {
        this.name = name;
        this.lastName = lastName;
        this.learning = learning;
    }
}

public static class StringExtensions
{
    public static void Output(this string input)
    {
        Console.WriteLine(input);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Valera", "Leontev", 63);

        string text = $"Output text - {student.name}, {student.lastName}, {student.learning}";

        text.Output();
    }
}