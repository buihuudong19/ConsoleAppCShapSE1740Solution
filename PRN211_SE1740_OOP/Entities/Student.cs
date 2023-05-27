
namespace PRN211_SE1740_OOP.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get;set; }
    public double Mark { get; set; }

    public Student(int id, string name, string address, double mark)
    {
        Id = id;
        Name = name;
        Address = address;
        Mark = mark;
    }

    public override string? ToString() 
        => $"Id: {Id}, Name: {Name}, Address: {Address} and Mark: {Mark}";
    
}
