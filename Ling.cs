Using System;
Using System.ling;
Using System.collections.Generic;

public class Ling
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string college { get; set; }
}
class Program
{
    Static void Main(string[] args)
    {
        List<student> lings = new List<student>()
        {
            new student { Id = 1, Name = "John", City = "New York", College = "Harvard" },
            new student { Id = 2, Name = "Jane", City = "Los Angeles", College = "Stanford" },
            new student { Id = 3, Name = "Bob", City = "Chicago", College = "Yale" }
        };
        var Selected students = from s in lings where s.City == "New York" select s;
        foreach (var s in Selected students);
        {
            Console.WriteLine("students namelist:");
            foreach (var s in Selected students){
                console.writeline(s.Name);
                
            }
    }