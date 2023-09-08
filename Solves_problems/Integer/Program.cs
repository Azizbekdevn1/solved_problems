using System.Data;
using System.Threading.Tasks.Sources;

namespace Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integer_4
            /* Console.WriteLine("A sonini kiriting");
             int A=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("B sonini kiriting");
             int B = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(" A kesmada B kesma " + A / B + " marta joylashgan");
             Console.ReadKey();*/
            //integer_5
            /* Console.WriteLine("A sonini kiriting");
             int A = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("B sonini kiriting");
             int B = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(" A kesmada B kesmaning " + (A-B*(A / B) )+ " qismi  joylashmagan");
             Console.ReadKey();*/

            //Integer_6

            /*Console.WriteLine("A sonini kiriting");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O'nlar xonasi:" + A / 10);
            Console.WriteLine("Birlar xonasi:" + A % 10);
            Console.ReadKey();*/

            //integer_7
            /* Console.WriteLine("A sonini kiriting");
             int A = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("O'nlar xonasi:" + A / 10);
             Console.WriteLine("Birlar xonasi:" + A % 10);
             Console.WriteLine("Raqamlari yig'indisi:"+(A/10+A%10));
             Console.ReadKey(); */

            //integer_8

            /*  int b,c;
              Console.WriteLine("a sonni kiriting>>:");
              int a= Convert.ToInt32(Console.ReadLine());
              c= a / 10;
              b = a % 10;
              Console.WriteLine("Natija>>:" + (10 * b + c));
              Console.ReadKey();*/

            //integer_9

            /* Console.WriteLine("a sonni kiriting>>:");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Yuzlar xoansi:" + a / 100);
             Console.ReadKey();*/


            //integer_12


            /* int b,c ,d;
             Console.WriteLine("a sonni kiriting>>:");
             int a = Convert.ToInt32(Console.ReadLine());
             b = a / 100;
             c = (a / 10) % 10;
             d = (a % 10);
             Console.WriteLine("Teskari son:>>" +( 100 * d + 10 * c + b));
             Console.ReadKey();*/


            //integer_14

            /*int b, c, d;
            Console.WriteLine("a sonni kiriting>>:");
            int a = Convert.ToInt32(Console.ReadLine());
            b = a / 100;
            c = (a / 10) % 10;
            d = (a % 10);
            Console.WriteLine("Teskari son:>>" + (100 * d + 10 * b + c));
            Console.ReadKey();*/

            //integer_17

            /*int b, c;
            Console.WriteLine("a sonni kiriting>>:");
            int a = Convert.ToInt32(Console.ReadLine());
            b = a / 100;
            c = b % 10;
            Console.WriteLine("Yuzlar xonasi:>>"+c);
            Console.ReadKey();*/

            //integer_18

            /*int b, c;
            Console.WriteLine("a sonni kiriting>>:");
            int a = Convert.ToInt32(Console.ReadLine());
            b = a / 1000;
            c = b % 10;
            Console.WriteLine("Yuzlar xonasi:>>" + c);
            Console.ReadKey();*/

            //integer_23

            /* int a,b, c;
             Console.WriteLine("N sekundni kiriting>>:");
             int N  = Convert.ToInt32(Console.ReadLine());
             a = N / 3600;
             b = (N % 3600)/ 60;
             c=(N%3600) % 60;
             Console.WriteLine(a + " soat " + b + " minut " + c + " sekund"  );
             Console.ReadKey();*/

            //integer_24
            /*int a, b;
            Console.WriteLine("K sonini kiriting:>>");
            int K = Convert.ToInt32(Console.ReadLine());
            a = K % 7;
            if (a == 0)
                Console.WriteLine("Dushanba ");
            if (a == 1)
                Console.WriteLine("Seshanba ");
            if (a == 2)
                Console.WriteLine("Chorshanba");
            if (a == 3)
                Console.WriteLine("Payshanba ");
            if (a == 4)
                Console.WriteLine("Juma ");
            if (a == 5)
                Console.WriteLine("Shanba ");
            if (a == 6)
                Console.WriteLine("Yakshanba ");
            Console.ReadKey();*/

            //integer_28

            /*int a, b;
            Console.WriteLine("K sonini kiriting:>>");
            int K = Convert.ToInt32(Console.ReadLine());
            a = K % 7;
            if (a == 0)
                Console.WriteLine("Dushanba ");
            if (a == 1)
                Console.WriteLine("Seshanba ");
            if (a == 2)
                Console.WriteLine("Chorshanba");
            if (a == 3)
                Console.WriteLine("Payshanba ");
            if (a == 4)
                Console.WriteLine("Juma ");
            if (a == 5)
                Console.WriteLine("Shanba ");
            if (a == 6)
                Console.WriteLine("Yakshanba ");
            Console.ReadKey();*/

            Console.WriteLine("K sonini kiriting:>>");
             int K = Convert.ToInt32(Console.ReadLine());
            int  a = K % 7;
             switch (a)         
             {

               case 0:
                 Console.WriteLine("Dushanba ");
                     break;
              case 1:
                 Console.WriteLine("Seshanba ");
                     break;
              case 2:
                 Console.WriteLine("Chorshanba");
                     break;
                 case 3: 
                 Console.WriteLine("Payshanba ");
                     break;
                 case 4:
                 Console.WriteLine("Juma ");
                     break;
                 case 5:
                 Console.WriteLine("Shanba ");
                     break;
                 case 6:
                     Console.WriteLine("Yakshanba ");
                     break;

              }


                 Console.ReadKey();


            //integer_29

            /* int n, s;
             Console.WriteLine("A sonni kiriting");
             int A=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("B sonni kiriting");
             int B = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("C sonni kiriting");
             int C = Convert.ToInt32(Console.ReadLine());

             n = (A / C) * (B / C);
             s = A * B - (C*C*n);
             Console.WriteLine("Kvadratlar soni:"+n);
             Console.WriteLine( "Qism yuzasi:"+s);
             Console.ReadKey();*/

            //integer_30

          /*  int a, b;
            string boshi, ortasi, oxiri;
            Console.WriteLine("A sonni kiriting");
            int A = Convert.ToInt32(Console.ReadLine());
            a = A / 100;
            b=A % 100;
            a = a + 1;
            Console.Write(a + "  asr  " );
            {
                if (b <= 20)
                    Console.Write("  boshi ");
                if (b >= 20 && b <= 60)
                    Console.Write(" o'rtalari ");
                else
                    Console.Write("  Oxiri ");
            }Console.ReadKey();*/

















        }
    }
}