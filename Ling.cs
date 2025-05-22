using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string College { get; set; }
}

class Ling
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "John", City = "New York", College = "Harvard" },
            new Student { Id = 2, Name = "Jane", City = "Los Angeles", College = "Stanford" },
            new Student { Id = 3, Name = "Bob", City = "Chicago", College = "Yale" }
        };
        
        var selectedStudents = from s in students 
                              where s.City == "New York" 
                              select s;
        
        Console.WriteLine("Students name list:");
        foreach (var s in selectedStudents)
        {
            Console.WriteLine($"Id={s.Id}, Name={s.Name}");
        }
    }
}