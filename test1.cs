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
  int current_index;
  public Person[] People =new Person[50];
  public void AddStudent(Student student){
    People[current_index++]=student; 
  }
  public void AddStaff(Staff staff){
    People[current_index++]= staff;
  }
  public void PrintAll(){
    for (int i = 0; i <= current_index; i++)
    {
      People[i].Print();
    }
  }
}
public class Staff :Person{
  public double Salary;
  public int JoinYear;

  public Staff(double salary , int joinyear,string name,int age):base(name,age){
    Salary=salary;
    JoinYear=joinyear;
  }
  public override void Print(){
    Console.WriteLine($"My name is{Name} , My age is{Age} , and my salary is {Salary}");
  }
}
public class Program
{
  private static void Main()
    {

      var database =new Database();
      while (true)
      {
        Console.WriteLine("1-student \n 2-staff \n 3-print all");
        Console.WriteLine("option :");
        var option =Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
          case 1:
              Console.Write("Name: ");
              var name =Console.ReadLine();
              Console.Write("Age: ");
              var age = convert.ToInt32(Console.ReadLine());
              Console.Write("Salary: ");
              var salary = convert.ToDouble(Console.ReadLine());
              Console.Write("Join year :");
              var joinyear = convert.ToInt32(Console.ReadLine());
              var student = new Student(name,age,salary,joinyear);
              database.AddStudent(student);
              break;


          case 2:
              Console.Write("Name: ");
              var name =Console.ReadLine();
              Console.Write("Age: ");
              var age = convert.ToInt32(Console.ReadLine());
              Console.Write("Year: ");
              var year = convert.ToInt32(Console.ReadLine());
              Console.Write("GPA :");
              var gpa = convert.ToSingle(Console.ReadLine());
              var student = new Student(name,age,year,gpa);
              database.AddStaff(staff);
            break;


          case 3:
          database.PrintAll();
            break;
          
          default:
          return;
        }
      }


    }
}
