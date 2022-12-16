using System;
namespace OopSection;
public abstract class Person{
  public string Name;
  public int Age;

  public Person(string name,int age){
    this.Name=name;
    this.Age=age;
  }
  public abstract void Print();
}
public class Student :Person{
  public int Year;
  public float Gpa;
  public Student(string name,int age, int year, float gpa):base(name,age){
    this.Year=year;
    this.Gpa=gpa;
  }
  public override void Print(){
    Console.WriteLine($"My name is {Name} , My age is s{Age} , and my GPA is {Gpa}");

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
    for (int i = 0; i < current_index; i++)
    {
      People[i].Print();
    }
  }
}
public class Staff :Person{
  public int Salary;
  public int JoinYear;

  public Staff(string name,int age,int salary ,int joinyear):base(name,age){
    this.Salary=salary;
    this.JoinYear=joinyear;

  }
  public override void Print(){
    Console.WriteLine($"My name is {Name} , My age is {Age} , and my salary is {Salary}");
  }

}
public class Program
{
  private static void Main()
    {

      var database =new Database();
      while (true)
      {
        Console.WriteLine("1-staff \n 2-student \n 3-print all");
        Console.WriteLine("option :");
        var option =Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
          case 1:
              Console.Write("Name: ");
              var name =Console.ReadLine();
              Console.Write("Age: ");
              var age = Convert.ToInt32(Console.ReadLine());
              Console.Write("Salary: ");
              var salary = Convert.ToInt32(Console.ReadLine());
              Console.Write("Join year :");
              var joinyear = Convert.ToInt32(Console.ReadLine());
              var staff = new Staff(name,age,salary,joinyear);
              database.AddStaff(staff);
              break;


          case 2:
              Console.Write("Name: ");
              var name2 =Console.ReadLine();
              Console.Write("Age: ");
              var age2 = Convert.ToInt32(Console.ReadLine());
              Console.Write("Year: ");
              var year = Convert.ToInt32(Console.ReadLine());
              Console.Write("GPA :");
              var gpa = Convert.ToSingle(Console.ReadLine());
              var student = new Student(name2,age2,year,gpa);
              database.AddStudent(student);
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
