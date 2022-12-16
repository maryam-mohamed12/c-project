using System;
namespace OopSection;

public abstract class Person{
  public string Name;
  public int Age;
  public Person(string name;int age){
    Name=name;
    Age=age;
  }
  public abstract void Print();
}
public class Student :Person{
  public int Year;
  public float Gpa;
  public Student(string name,int age, int year, float gpa):base(name,age){
    Year=year;
    Gpa=gpa;
  }
  public override void Print(){
    Console.WriteLine($"My name is{Name} , My age is{Age} , and my GPA is {Gpa}");

  }
}
public class Database{
  int Current_index;
  public Person[] People =new Person[50];
  public void AddStudent(Student student){
    People[Current_index++]=student; 
  }
}
public class Program
{
  private static void Main()
    {

       var database =new Database();
       Console.Write("Name: ");
       var name =Console.ReadLine();
       Console.Write("Age: ");
       var age = convert.ToInt32(Console.ReadLine());
       Console.Write("Year: ");
       var year = convert.ToInt32(Console.ReadLine());
       Console.Write("GPA :");
       var gpa = convert.ToInt32(Console.ReadLine());
       var student = new Student(name,age,year,gpa);
       database.AddStudent(student);



    }
}
