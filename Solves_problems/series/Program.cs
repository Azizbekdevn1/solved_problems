namespace sequence
{
    internal class Program
    {

        //Series_1

        /*
        int number;
        double sum=0;   
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}-sonni kiriting:");
            number=Convert.ToInt32(Console.ReadLine());  
            sum+=number;
        }

        Console.WriteLine("Rezult "+sum);

        */

        //series_2
        /*
        int num;
        double sum=1;
        for(int i=1; i<=5; i++)
        {
            num=Convert.ToInt32(Console.ReadLine());
            sum*=num;
        }
        Console.WriteLine(sum);
        */
        //series_5
        /*
        double n=Convert.ToDouble(Console.ReadLine());
        double sum = 0;
        double floor;
        for(int i = 1; i <=n; i++)
        {
            Console.Write($"{i}-sonni kiriting:");
            floor = Convert.ToDouble(Console.ReadLine());
            sum+=Math.Floor(floor);

        }
        Console.WriteLine($" Natija>> {sum}");
        */
        // series_6
        /*
        double n = Convert.ToDouble(Console.ReadLine());
        double sum = 1;
        double floor;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i}-sonni kiriting:");
            floor = Convert.ToDouble(Console.ReadLine());
            sum *=floor-Math.Floor(floor);

        }
        Console.WriteLine($" Natija>> {sum}");
        */
        //series_7
        /*
        double n=Convert.ToDouble(Console.ReadLine());
        double sum = 0,yax;
        for(int i =1; i <= n; i++)
        {
            Console.Write($"{i}-sonni kiriting:");
            yax = Convert.ToDouble(Console.ReadLine());
            sum += Math.Round(yax);
        }
        Console.WriteLine($" Natija>> {sum}");
        */
        //series_8
        /*
        int juft = 0;
        int n=Convert.ToInt32(Console.ReadLine());
        double[] son = new double[n];
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"{i}-sonni kiriting:");
            son[i]=Convert.ToDouble(Console.ReadLine());



        }
        for(int i=0; i<n; i++)
        {
            if (son[i] % 2 == 0)
            {

                Console.WriteLine($"{son[i]} ");
                juft++;
            }

        }
        Console.WriteLine(juft);
        */
        // series_10
        /*
         int n=Convert.ToInt32(Console.ReadLine());
         double[] arr=new double[n]; 
         for(int i=0;i<arr.Length;i++)
         {
             Console.WriteLine($"{i}-sonni kiriting:");
             arr[i]=Convert.ToDouble(Console.ReadLine());
         }
         bool p=false;
         for(int i=0;i<n;i++)
         { 

             if(arr[i]>0)
             {
                 p = true;
                 break;
             }

         }
         if(p==true)    
             Console.WriteLine("True");  
         else if(p==false)  
             Console.WriteLine("False");
         */
        //Series_11
        /*
        int k=Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        double[] mas=new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i}-sonni kiriting:");
            mas[i] = Convert.ToDouble(Console.ReadLine());
        }
        bool p = false;
        for (int i = 0; i < n; i++)
        {

            if (mas[i] <k)
            {
                p = true;
                break;
            }

        }
        if (p == true)
            Console.WriteLine("True");
        else if (p == false)
            Console.WriteLine("False");
        */
        //Series_13
        /*
        bool how=true;
        double sum = 0;
        double[] nul = new double[6];
        for(int i=0; i<6; i++)
        {
            nul[i]=Convert.ToDouble(Console.ReadLine());
        }


        for (int i = 0; i < nul.Length; i++)
        {
            if (nul[i] > 0 && nul[i]%2==0)
            {   how = true;
                sum += nul[i];

            }



        }
        if (how)
            Console.WriteLine(sum);
        else
            Console.WriteLine("0");
        */
        //Series_15
        /*
        int k=Convert.ToInt32(Console.ReadLine());
        bool how = true;
        double[] nul = new double[6];
        for (int i = 0; i < 6; i++)
        {
            nul[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < nul.Length; i++)
        {
            if (nul[i] > k)
            {
                how = true;
                Console.WriteLine(i);
                break;

            }
            else;
            how = false;

        }

        if(!how)
            Console.WriteLine("0");

        Console.ReadKey();
        */
        //Series_16
        //int k = Convert.ToInt32(Console.ReadLine());
        //bool how = true;
        //double max = 0;
        //double min = 0; 
        //double[] nul = new double[6];
        //for (int i = 0; i < 6; i++)
        //{
        //    nul[i] = Convert.ToDouble(Console.ReadLine());
        //}

        //for (int i = 0; i < nul.Length; i++)
        //{
        //    if (nul[i] > k && nul[i]>min)
        //    {
        //        how = true;
        //        min = nul[i];
        //        max=i;

        //    }
        //}
        //if (how)  Console.WriteLine(max);
        //else Console.WriteLine("0");
        static int F(int n,int k=5)
        {
            k = n / k;
            return n-k;
        }

        static void Main(string[] args)
        {
            int n=7,c=2,k = 2;
            int[] a = { 1, 2, 3, 6, 4 };
            for(int i=0;i<5;i++)
            {
                if (F(n, a[i] - n) - F(n - a[i], c) < 0)
                    c = c + F(c, c);
            }
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}