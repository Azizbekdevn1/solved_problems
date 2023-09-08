using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Massivni hosil qilish va elementlarini kiritish:
            //Array_1
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            int[] toq = new int[n];
            for (int i = 1; i <=2*n; i += 2)
            {
                Console.WriteLine(i);
            }
            */

            //Array_2
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            int[] degre=new int[n];
            for(int i=0; i<=n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            */
            //Array_3
            /*
            int n=Convert.ToInt32(Console.ReadLine());  
            int d=Convert.ToInt32(Console.ReadLine());
            int[] prog=new int[n]; 
            prog[0]=Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<n; i++)
            {
               
                prog[i] = prog[i-1]+d;
                
                Console.WriteLine($"{i}-had {prog[i]}");
            }
            */
            //Array_6
            /*
            int n=Convert.ToInt32(Console.ReadLine());  
            double[] ar = new double[n];
           int a=Convert.ToInt32(Console.ReadLine()); 
           int  b =Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <n; i++)
            {
                ar[i]=(Math.Pow(2,i-2))*(a + b);
                Console.WriteLine($"{i}-had {ar[i]}");
            }
              */
            //Array_7
            /*
            int p=Convert.ToInt32(Console.ReadLine());
            int[] numbers=new int[p];
            int n = numbers.Length; // massiv uzunligi
            int k = n / 2; // massivning o'rtasi
            int temp; //qiymat almashinuvi uchun yordamchi o’zgaruvchi
            for(int i=0;i<p;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());   
            }
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */
            //Array_8
            /*
            int n = Convert.ToInt32(Console.ReadLine()),num=0;
            int[] a=new int[n];
           // int[] b=new int[n];
            Console.WriteLine("Umumiy ");
            for (int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Toqlari o'sish tartibida");
            for(int i = 0 ; i <=n; i++)
            {
               bool x=true;
                if (a[i] % 2 == 1 )
                {
                    
                    num++;

                    
                   Console.WriteLine($"{i}-{a[i]}");
                } 
                
            }
            Console.WriteLine($"\t {num}");
            */
            //Array_11
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double[] a=new double[n];
            for (int i=0; i<n; i++)
            {
                a[i]=Convert.ToDouble(Console.ReadLine());  
            }
            int k=Convert.ToInt32(Console.ReadLine());  
            for(int i=0; i<n; i++)
            {
               bool x = true;
                if (i%k==0)
                {
                    Console.WriteLine(i+" had "+a[i]);


                }

            }
            */


            //Array_15
            /*
            int n = Convert.ToInt32(Console.ReadLine()), num = 0;
            int[] a = new int[n];
            // int[] b=new int[n];
            Console.WriteLine("Umumiy ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Toqlari o'sish tartibida");
            for (int i = 0; i < n; i+=2)
            {
                Console.WriteLine($"{i}-{a[i]}");
            }

            Console.WriteLine("Juftlari kamayish tartibida");
            for(int i = n-1; i >=0; i-=2)
            {
                Console.WriteLine($"{i}-{a[i]}");
            }
            */

            //Array_16
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            double[]b=new double[n];
            double[]a=new double[n];
            for(int i=0; i<n; i++)
            {
                a[i]=Convert.ToDouble(Console.ReadLine()); 
                
            }
            Console.WriteLine("Tartiblangan ko'rinishi ");
         
            for(int i=n-1; i>=0; i--)
            {   
                Console.WriteLine(a[i]);
               
               
            }

            for(int i=1; i<n; i++)
            {
                Console.Write($"{i}-{a[i]},{n-i}-{a[n-i]}\n");
             
            }

            */
            //Array_18
            /*
             int n =Convert.ToInt32(Console.ReadLine()),min=0;
            int[] maxs=new int[n];
            for (int i = 0; i < n; i++)
            {
                maxs[i] = Convert.ToInt32(Console.ReadLine());

            }
              //bool large=true;
            for (int i = 0;i<n-1; i++)
            {
                min=maxs[n-1];
                if (min >maxs[i])
                {
                    min = maxs[i];
                    break;
                }
            }
            if (min == maxs[n-1])
            { 

                Console.WriteLine("0");
            }
              
            else
                Console.WriteLine(min);
            */
            //Array_19
            /*
            int n = Convert.ToInt32(Console.ReadLine()), min=0 ,max=0,index=0,p=0;
            int[] maxs = new int[n];
            for (int i = 0; i < n; i++)
            {
                maxs[i] = Convert.ToInt32(Console.ReadLine());

            }
           
            for (int i = 0; i < n - 1; i++)
            {
                max = maxs[n - 1];
                min=maxs[0];
                index=maxs[i];
                if (max>maxs[i] && maxs[i]>min)
                {
                    p= i;
                   
                }
                
                   
            }
            if (max > index && index > min)
            {

                Console.WriteLine(p);
            }
            else
                Console.WriteLine("0");
            */
            //Array_21
            /*
            int n=Convert.ToInt32(Console.ReadLine());
           
            int[] a=new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Indexlar oralig'ini kiriting:");
            int k =Convert.ToInt32(Console.ReadLine());
            double arif = 0;
            int m=Convert.ToInt32(Console.ReadLine());
            for(int i = k; i <= m; i++)
            {
                arif+=a[i];
            }
            Console.WriteLine($"O'rta arifmetik qiymat:{arif / (m - k+1)}");
            */
            //Array_24
            /*
            int n = Convert.ToInt32(Console.ReadLine()),difference=0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool b = true;
            int dif;
            dif = a[1] - a[0];
            for (int i = 0; i < n-1; i++)
            {
                difference = a[i + 1] - a[i];
                if (dif==difference)
                {  
                    b=true;
                }
                else
                {  
                    b = false; 
                    break;
                }
            }
            if (b)
                Console.WriteLine(difference);
            else
                Console.WriteLine("0");
                */



            //Array_26
            /*
            int breaknumber=0;  
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool p=true ;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] % 2 == 1 && arr[i+1] % 2 == 0 || arr[i] % 2 == 0 && arr[i + 1] % 2 == 1)
                {
                    p=true;
                }
                else
                { 
                    breaknumber=i+1;
                    p=false;
                    break;
                }
            }

            if (p)
            {
                Console.WriteLine(0);
            }
            else
                Console.WriteLine(breaknumber);

            */

            //Array_28

            /*
            int n=Convert.ToInt32(Console.ReadLine());  
            int[] couplearr = new int[n];
            
            for(int i=0; i<n; i++)
            {
                couplearr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            int pro = couplearr[0];

            for(int i=0; i<n; i+=2)
            {
                if(couplearr[i]<=pro)
                {
                    couplearr[i] = pro;
                }
            }
            Console.WriteLine(pro);   
            */

            //Array_30
            /*
             int n = Convert.ToInt32(Console.ReadLine());
             int[] sortarr = new int[n];
             int counter = 0;
             List<int> list = new List<int>();
             for(int i = 0; i < n; i++)
             {
                 sortarr[i] = Convert.ToInt32(Console.ReadLine());   
             }

             for(int i = 0; i < sortarr.Length-1; i++)
             {
                 if(sortarr[i]>sortarr[i+1])
                 {
                     list.Add(i);
                     counter++;
                 }
                 else
                     continue;
             }
             list.Sort();
             foreach (int i in list)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine(list.Count);
            */


            //Array_40
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int R = Convert.ToInt32(Console.ReadLine());
            int[] near = new int[n];
            int distance = 0;
            for (int i = 0; i < n; i++)
            {
                near[i] = Convert.ToInt32(Console.ReadLine());
            }
                distance = Math.Abs(near[1] - R);
            for (int i = 0; i < n; i++)
            {
                
                if (distance >= Math.Abs(near[i] - R))
                {
                    distance=Math.Abs(near[i]-R);
                }
            }
            Console.WriteLine(distance);
            Console.ReadKey();
            */















        }
    }
}