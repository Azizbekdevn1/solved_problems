using System.ComponentModel;
using System.Globalization;

namespace Foor_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {   // For_1>>
            /*
            Console.Write("n sonni kiriting>>");
            int n=Convert.ToInt32(Console.ReadLine()),a=0;
            Console.Write("k sonni kiriting>>");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                 Console.WriteLine(k+" \t" );
            }
           
            Console.ReadKey();
            */
            //For_2
            /*           
            Console.WriteLine("a sonni kiriting");
            int a=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("b sonni kiriting");
            int b = Convert.ToInt32(Console.ReadLine());
            for( int i=a; i<=b ;i++)
            {
                Console.Write(i+"\n");
            }
            if(a>0 & b > 0 || a<0 & b<0)
            {
                Console.Write("Natija>>" + (Math.Abs(a - b)));
            }
            else
            Console.WriteLine("Elementlar soni>>"+(Math.Abs(a)+Math.Abs(b)+1));
            Console.ReadKey();  
            */
            //For_3
            /*
            Console.WriteLine("a sonni kiriting");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b sonni kiriting");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.Write(i + "\n");
            }
            for (int i = b; i > a; i--)
            {
                Console.Write(i + "\n");
            }

            if (a > 0 & b > 0 || a < 0 & b < 0)
            {
                Console.Write("Natija>>" + (Math.Abs(a - b)));
            }
            else
                Console.WriteLine("Elementlar soni>>" + (Math.Abs(a) + Math.Abs(b) + 1));
            Console.ReadKey();
            */
            //For_4
            /*
            int c = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(c*i);

            } Console.ReadKey();
            */
            //For_7
            /*
             int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine()),t=0;
            for(int i=a;i<=b;i++)
            {
                t += i;
            }
            Console.WriteLine(t);
            */
            //For_8
            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()), t = 1;
            for (int i = a; i <= b; i++)
            {
                t *= i;
            }
            Console.WriteLine(t);
            */
            //For_9
            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()), t = 0;
            for (int i = a; i <= b; i++)
            {
                t += i*i;
            }
            Console.WriteLine(t);
            */
            //For_10
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            double t = 0;
            for (double i = 1; i <= n; i++)
            {
                t += (1 / i);
            }
            Console.WriteLine(t);
            */
            //For_11
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            double t = 0;
            for (double i = n; i <= 2*n; i++)
            {
                t += i*i;
            }
            Console.WriteLine(t);
            */
            // For_12
            /*
            double n=Convert.ToDouble(Console.ReadLine());
             double s = 1;
             for(double i = 1; i <= n;)
             {
                 i = i + 0.1;
                 s= s * i;   
             }
             Console.WriteLine(s);
            */
            //For_13
            /*
            Console.Write("n sonni kiriting :");
            int n=Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i = 1; i <= 2*n-1; i+=2)
            {
                s += i;
            Console.WriteLine("n^2= "+s);
            }
            */

            //For_15
            /*
            int n = Convert.ToInt32(Console.ReadLine()); 
            int s = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s =s * a;
            }
            Console.WriteLine( "a sonining n chi darajasi:"+s);
            */
            //For_16
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                s = s *  a;
                Console.WriteLine($"{a} sonining {i} darajasi:{s}");
            }
            */
            //For_17
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double  s = 1;
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                s += Math.Pow(a,i); 
            }
            Console.WriteLine(s);
            Console.ReadKey();
            */
            //For_18
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double s = 0;
            int a=Convert.ToInt32(Console.ReadLine());  
            for(int i=0;i<=n;i++)
            {
                s+=Math.Pow(-a,i);

            }
            Console.WriteLine(s);
            */
            //For_19
            /*
            int k = 1;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                k*=i;

            }
            Console.WriteLine(k);
            */
            //For_20
            /*
            int k = 1,s=0;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                k*=i;
                s+=k;
            }
            Console.WriteLine(k+" "+s);
            */
            //For_21
            /*
            double  p = 1, m = 1;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                p *= i;
                m += (1 / p);

            }
            Console.WriteLine(p+" "+m);
            */
            //For_22

            /*
            double p = 1, m = 1;
            int n=Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                p *= i;
                m += (Math.Pow(x, i)) / p;
            }
            Console.WriteLine(p+" "+m);
            */
            //For_23
            /*
            double fac, s = 0;
            int n=Convert.ToInt32(Console.ReadLine());
            int x=Convert.ToInt32(Console.ReadLine());  
            for(int i=0; i<=n;i++ )
            {
                fac = 1;
                for(int j=1; j<=2*i+1; j++)
                {
                    fac *= j;
                }
                s+=(Math.Pow(-1, i) * Math.Pow(x, 2*i + 1))/fac;
                
            }
            Console.WriteLine($"Result " + s);
            */
            // For_29
            /*
            double A=Convert.ToDouble(Console.ReadLine()),p=A;
            double B= Convert.ToDouble(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine()); 
            double t = (B - A) / n;
            for(double i=A;i<B;)
            {   i += t;
                Console.WriteLine(i);
                
            }
            */
            //For_24
            /*
            double fac, s = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                fac = 1;
                for (int j = 1; j <= 2 * i ; j++)
                {
                    fac *= j;
                }
                s += (Math.Pow(-1, i) * Math.Pow(x, 2 * i )) / fac;

            }
            Console.WriteLine($"Result " + s);
            */

            //For_30
            /*
            double A = Convert.ToDouble(Console.ReadLine()), p = A;
            double B = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double t = (B - A) / n;
            for (double i = A; i < B;)
            {
                i += t;
                double f = 1 - Math.Sin(i);
                Console.WriteLine(i +$"\t = {f}");
                


            }
            */

            //For_31
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double[] ar=new double[n];
            for (int k = 1; k <n; k++)
            {  
                ar[0] = 2;
                ar[k ] = 2 + (1 / ar[k-1]);
                Console.WriteLine($"{k}-{ar[k]}");
                ar[0] = ar[k];
            }
            */
            //For_32
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            double[] ar = new double[n];
            for (int k = 1; k < n; k++)
            {
                ar[0] = 1;
                ar[k] = (ar[k - 1]+1)/k;
                Console.WriteLine($"{k}-{ar[k]}");
                ar[0] = ar[k];
            }
            */
            //For_33
            /*
            int n=Convert.ToInt32(Console.ReadLine());  
            double[] fibo=new double[n];    
            for(int i=3; i<=n; i++)
            {
                fibo[1] = 1;
                fibo[2] = 1;
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                Console.WriteLine();
                Console.WriteLine($"{i}-son {fibo[i]}");
            }
            */
            //For_34
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            double[] fibo = new double[n];
            for (int i = 3; i <= n; i++)
            {
                fibo[1] = 1;
                fibo[2] = 2;
                fibo[i] = (2*fibo[i - 1] + fibo[i - 2])/3;
                Console.WriteLine();
                Console.WriteLine($"{i}-son {fibo[i]}");
            }*/
            //For_35
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 4; i <n; i++)
            {
                a[1] = 1;
                a[2] = 2;
                a[3] = 3;
                a[i] = a[i - 1] + a[i - 2] - 2 * a[i - 3];
                Console.WriteLine($"{i}-son {a[i]}");
            }
            */
            //For_36
            /*
            double k=Convert.ToDouble(Console.ReadLine());  
            double n=Convert.ToDouble(Console.ReadLine()),s=0;
            for(int i=1;i<=n;i++)
            {
                s += Math.Pow(i, k);

            }
            Console.WriteLine(s);
            */
            //For_37
            /*
            double n=Convert.ToDouble(Console.ReadLine()),s=0;
            for (int i = 1,j=1; i <= n;j++, i++)
            {
           
                Console.WriteLine(Math.Pow(j,i));
                s += Math.Pow(j, i);
   
               
            }
            Console.WriteLine($"Sum : {s}");
            */
            //For_38
            double n=Convert.ToDouble(Console.ReadLine()),s=0;
            for(double i=1;i<=n;i++)
            {
                s += Math.Pow(i, n);
                n--;

            }  
            Console.WriteLine(s);
            Console.ReadKey();
        }  
       }    
    }