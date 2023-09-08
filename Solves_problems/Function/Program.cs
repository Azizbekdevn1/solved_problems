using System.Numerics;

namespace Function
{
    internal class Program
    {           //Func_1
        /*
        static double Powera3 (double a)
        {
            double d=Math.Pow(a,3);
            return d;
        }

        static void Main(string[] args)
        {
            double A = -435, B = 4, C = -20, D = 10;
            Console.WriteLine(Powera3(A)); 
            Console.WriteLine(Powera3(B));
            Console.WriteLine(Powera3(C));
            Console.WriteLine(Powera3(D));
            Console.ReadKey();
        }
        */
        //Func_2
        /*
        static double Powera234(double a,int b)
        {
            double d=Math.Pow(a, b);
            return d;
          
        }
        static void Main(string[] args)
        {
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Powera234(a,2));
            Console.WriteLine(Powera234(a,3));
            Console.WriteLine(Powera234(a,4));
            Console.ReadKey();
        }
        */
        //Func_3
        /*
        static void Mean(double a,double b)
        {
            Console.WriteLine($"O'rta arifmetik:{(a+b)/2}");
            Console.WriteLine();
            Console.WriteLine($"O'rta geometrik:{Math.Sqrt(a * b)}");
           
        }
        static void Main(string[] args)
        {
            double A=Convert.ToDouble(Console.ReadLine());
            double B=Convert.ToDouble(Console.ReadLine());  
            double C=Convert.ToDouble(Console.ReadLine());
            double D=Convert.ToDouble(Console.ReadLine());
            Mean(A,B);
            Mean(A,D);  
            Mean(A,C);
            Console.ReadKey();
        }
        */
        //Func_4
        /*
        static void Triengli(double a)
        {
            double yuza=(Math.Sqrt(3)*Math.Pow(a,2))/4;
            Console.WriteLine($"Uchburchak yuzasi: { yuza}");
            Console.WriteLine($"Uchburchak peremetri: {3*a}");
        }
        static void Main(string[] args)
        {
            Triengli(3);
            Triengli(54.7);
            Triengli(1);
            Triengli(100);

        }
        */
        //Func_5
        /*
        static void rectps(int x1,int x2,int y1,int y2)
        {
            Console.WriteLine($"To'rtburchakning yuzasi:S={Math.Abs((x1-x2)*(y1-y2))}");
            Console.WriteLine($"To'rtburchakning perimetri: P={2*(Math.Abs(x1-x2)+Math.Abs(y1-y2))}");

        }
        static void Main(string[] args)
        {
            rectps(1, 2, 3, 4);
            rectps(10,-23,43,75);
            rectps(10, 30, 50, 70);
            Console.ReadKey();
        }
        */
        static void DigitcountSum(int a)
        {
            a = Math.Abs(a);
            int sum = 0;
            int xona=0;
            while (a != 0)
            {
                sum+= a % 10;
                a /= 10;
                xona += 1;
            }
            Console.WriteLine($"Bu sonning raqamlar yig'indisi:{sum} ga teng");
            Console.WriteLine($"Bu {xona} xonali  son");
            
          
        }
        static void Main(string[] args)
        {
            DigitcountSum(372324972);
            
            Console.ReadKey();

        }


    }
}