//class Person
//{
//     private string _name;
//     public string Name
//     {
//          get { return _name; }
//          set { _name = value; }
//     }
//     public void Display()
//     {
//          Console.WriteLine(Name);
//     }
//}
//class Employee : Person
//{
//
//}
//
//public class Shape
//{
//
//}
//
//public class Circle : Shape
//{
//     public void Draw()
//     {
//          Console.WriteLine("Aylana chizildi");
//     }
//}
//
//public class Triangle : Shape
//{
//     public void Draw()
//     {
//          Console.WriteLine("Uchburchak chizildi");
//     }
//}
//
//public class Rectangle : Shape
//{
//     public void Draw()
//     {
//          Console.WriteLine("To'rtburchak chizildi");
//     }
//}
class Person
{
     public string Name { get; set; }

     public Person(string name)
     {
          Name = name;
     }
     public void Display()
     {
          Console.WriteLine(Name);
     }
}
class Employee : Person
{
     public string Company { get; set; }
     public Employee(string name, string company)
          : base(name)
     {
          Company = company;
     }
}