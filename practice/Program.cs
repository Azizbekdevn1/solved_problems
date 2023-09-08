

//namespace Field
//{
//     public class Program
//     {
//          public static void Main(string[] args)
//          {
//               AboutProperty aboutProperty = new AboutProperty();
//               Console.WriteLine(aboutProperty.FirsName);
//
//          }
//     }
//     public class AboutProperty
//     {
//          private string firsname = "Abdullo";
//          public string FirsName
//          {
//               get
//               {
//                    return firsname;
//               }
//               set
//               {
//                    firsname = value;
//               }
//
//          }
//
//     }
//}

//Person p = new Person { Name = "Tom" };
//p.Display();
//p = new Employee { Name = "Sam" };
//p.Display();
//Console.Read();
//using System;
//namespace ConsoleApp1
//{
//     class Program
//     {
//          static void Main(string[] args)
//          {
//               double[] arr = new double[]
//               {
//                2, 3.3, 5, 5, 89.0, 112.2, 98, 77
//               };
//
//               Console.WriteLine(Max(2, 3.3));
//               Console.WriteLine(Max(4.7, 3.3, 48.0));
//               Console.WriteLine(Max(arr));
//          }
//
//          static double Max(double number1, double number2)
//          {
//               return (number1 > number2) ? number1 : number2;
//          }
//
//          static double Max(double number1,
//              double number2, double number3)
//          {
//               if (number1 > number2 && number1 > number3) return number1;
//               else if (number2 > number1 && number2 > number3) return number2;
//               else if (number3 > number2 && number3 > number1) return number3;
//               else return -1;
//          }
//
//          static double Max(double[] arr)
//          {
//               if (arr != null)
//               {
//                    double max = arr[0];
//                    for (int i = 1; i < arr.Length; i++)
//                    {
//                         if (arr[i] > max) max = arr[i];
//                    }
//                    return max;
//               }
//               else return -1;
//          }
//     }
//}



//using System;
//namespace ConsoleApp1
//{
//     public abstract class Shape
//     {
//          public virtual void Draw()
//          {
//               Console.WriteLine("Shakl chizildi");
//          }
//     }
//
//     public class Circle : Shape
//     {
//          private float _radius;
//          public Circle(float radius)
//          {
//               this._radius = radius;
//          }
//          public override void Draw()
//          {
//               Console.WriteLine($"Radiusi {_radius} ga teng bo'lgan aylana chizildi");
//          }
//     }
//
//     public class Triangle : Shape
//     {
//          private float _a;
//          private float _b;
//          private float _c;
//
//          public Triangle(float a, float b, float c)
//          {
//               _a = a;
//               _b = b;
//               _c = c;
//          }
//
//          public override void Draw()
//          {
//               Console.WriteLine($"Tomonlari {_a} {_b} {_c} ga teng bo'lgan" +
//                   $" uchburchak chizildi");
//          }
//     }
//
//     public class Rectangle : Shape
//     {
//          private float _width;
//          private float _height;
//
//          public Rectangle(float width, float height)
//          {
//               _width = width;
//               _height = height;
//          }
//
//          public override void Draw()
//          {
//               Console.WriteLine($"Tomonlari {_width} {_height} ga teng bo'lgan" +
//                   $" to'rtburchak chizildi");
//          }
//     }
//
//     class Program
//     {
//          static void Main(string[] args)
//          {
//               Circle circle = new Circle(5);
//               circle.Draw();
//               Triangle triangle = new Triangle(3, 4, 5);
//               triangle.Draw();
//               Rectangle rectangle = new Rectangle(4, 5);
//               rectangle.Draw();
//          }
//     }
//}




//
//Person p = new Person("Bill");
//p.Display();
//Employee emp = new Employee("Tom", "Microsoft");
//emp.Display();
//Console.Read();

//namespace PolymorphismDemoApp
//{
//     abstract class Shakl
//     {
//          public abstract void Chizish();
//     }
//
//     class Uchburchak : Shakl
//     {
//          public override void Chizish()
//          {
//               Console.WriteLine("Uchburchak chizaman");
//          }
//     }
//
//     class Aylana : Shakl
//     {
//          public override void Chizish()
//          {
//               Console.WriteLine("Aylana chizaman");
//          }
//     }
//
//     class Program
//     {
//          static void Main(string[] args)
//          {
//               //konstruktorlar e'loni
//               //Shakl shakl = new Shakl(); endi Shakl sinfining kostruktrini yaratib bo'lmaydi 
//               Shakl uchburchak = new Uchburchak();
//               Shakl aylana = new Aylana();
//
//               //Metodni chaqirish
//               uchburchak.Chizish();
//               aylana.Chizish();
//
//               Console.ReadKey();
//          }
//     }
//}
//

//using System;
//
//public class Matrix
//{
//     protected int[,] elements;
//
//     public Matrix(int[,] elements)
//     {
//          this.elements = elements;
//     }
//
//     public virtual Matrix Add(Matrix matrix)
//     {
//          int rows = elements.GetLength(0);
//          int cols = elements.GetLength(1);
//          int[,] result = new int[rows, cols];
//
//          for (int i = 0; i < rows; i++)
//          {
//               for (int j = 0; j < cols; j++)
//               {
//                    result[i, j] = elements[i, j] + matrix.elements[i, j];
//               }
//          }
//
//          return new Matrix(result);
//     }
//
//     public virtual Matrix Subtract(Matrix matrix)
//     {
//          int rows = elements.GetLength(0);
//          int cols = elements.GetLength(1);
//          int[,] result = new int[rows, cols];
//
//          for (int i = 0; i < rows; i++)
//          {
//               for (int j = 0; j < cols; j++)
//               {
//                    result[i, j] = elements[i, j] - matrix.elements[i, j];
//               }
//          }
//
//          return new Matrix(result);
//     }
//
//     public virtual Matrix Multiply(Matrix matrix)
//     {
//          int rowsA = elements.GetLength(0);
//          int colsA = elements.GetLength(1);
//          int colsB = matrix.elements.GetLength(1);
//          int[,] result = new int[rowsA, colsB];
//
//          for (int i = 0; i < rowsA; i++)
//          {
//               for (int j = 0; j < colsB; j++)
//               {
//                    int sum = 0;
//                    for (int k = 0; k < colsA; k++)
//                    {
//                         sum += elements[i, k] * matrix.elements[k, j];
//                    }
//                    result[i, j] = sum;
//               }
//          }
//
//          return new Matrix(result);
//     }
//
//     public virtual void Display()
//     {
//          int rows = elements.GetLength(0);
//          int cols = elements.GetLength(1);
//
//          for (int i = 0; i < rows; i++)
//          {
//               for (int j = 0; j < cols; j++)
//               {
//                    Console.Write(elements[i, j] + "\t");
//               }
//               Console.WriteLine();
//          }
//     }
//}
//
//public class RectangularMatrix : Matrix
//{
//     public RectangularMatrix(int[,] elements) : base(elements)
//     {
//     }
//}
//
//public class SquareMatrix : Matrix
//{
//     public SquareMatrix(int[,] elements) : base(elements)
//     {
//     }
//
//     public override void Display()
//     {
//          int size = elements.GetLength(0);
//
//          for (int i = 0; i < size; i++)
//          {
//               for (int j = 0; j < size; j++)
//               {
//                    if (j <= i)
//                    {
//                         Console.Write(elements[i, j] + "\t");
//                    }
//                    else
//                    {
//                         Console.Write(elements[j, i] + "\t");
//                    }
//               }
//               Console.WriteLine();
//          }
//     }
//}
//
//public class Program
//{
//     public static void Main(string[] args)
//     {
//          int[,] rectangularElements = { { 1, 2, 3 }, { 4, 5, 6 } };
//          int[,] squareElements = { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };
//
//          RectangularMatrix rectangularMatrix1 = new RectangularMatrix(rectangularElements);
//          RectangularMatrix rectangularMatrix2 = new RectangularMatrix(rectangularElements);
//          SquareMatrix squareMatrix1 = new SquareMatrix(squareElements);
//          SquareMatrix squareMatrix2 = new SquareMatrix(squareElements);
//
//          Console.WriteLine("Addition of rectangular matrices:");
//          Matrix rectangularSum = rectangularMatrix1.Add(rectangularMatrix2);
//          rectangularSum.Display();
//
//          Console.WriteLine("\nSubtraction of rectangular matrices:");
//          Matrix rectangularDifference = rectangularMatrix1.Subtract(rectangularMatrix2);
//          rectangularDifference.Display();
//
//          Console.WriteLine("\nMultiplication of square matrices:");
//          Matrix squareProduct = squareMatrix1.Multiply(squareMatrix2);
//          squareProduct.Display();
//
//          Console.WriteLine("\nDisplay triangular form of square matrix:");
//          squareMatrix1.Display();
//     }
//}
//



