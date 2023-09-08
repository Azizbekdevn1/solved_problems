//Console.WriteLine("Hello, World!");
//  21. Uchburchakning uchlarining koordinatalari berilgan.
//  Ular (x1,y1), (x2,y2), (x3,y3) hisoblanadi. Ikki nuqta orasidagi masofani topish formulasi
//  va Geron formulasidan foydalanib uning perimetri hamda yuzasi hisoblansin.
//  A(x1:y1)
//   B(x2:y2
// C(x3:y3)
/*
double P, S, a,b,c;

 Console.WriteLine(" x1 sonni kiriting");
 double x1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" x2 sonni kiriting");
 double x2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" x3 sonni kiriting");
 double x3 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" y1 sonni kiriting");
 double y1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" y2 sonni kiriting");
 double y2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine(" y3 sonni kiriting");
 double y3 = Convert.ToDouble(Console.ReadLine());

 a=Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1, 2));
 Console.WriteLine(" AB tomon uzunligi:"+a);
 b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
 Console.WriteLine(" BC tomon uzunligi:"+b);
 c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
 Console.WriteLine(" AC tomon uzunligi:"+c);

 P = a + b + c;
 Console.WriteLine("Uchburchak perimetri:"+P);
 S = Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
 Console.WriteLine("Uchburchak yuzasi:" + S);
 Console.ReadKey();
*/
/*
double x=2.444,y=0.00869,z=-130,h,a,b,c;
a=1+Math.Abs(y-x);
b = (Math.Pow(x, y + 1) + Math.Exp(y - 1) )/(1 + x * (Math.Abs(y - Math.Tan(z))));
c =( Math.Pow(y - x, 2) / 2) - (Math.Pow(Math.Abs(y - x), 3) / 3);
h = (a * b )+ c;
Console.WriteLine("Natija:"+h);
Console.ReadKey();

 double x = 17.421, y = 10.365 * Math.Pow(10, -3), z = 0.828 * Math.Pow(10, 5), a=Math .Sin (Math.PI *x);
 double f = (Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));
 Console.WriteLine("f=" + f);
 Console.ReadKey();*/
/*
double  y, a = 2, b = 5;
Console.WriteLine(" x sonni kiriting");
double x = Convert.ToDouble(Console.ReadLine());

y = (x > 2) ? Math.Exp(a * x) * Math.Cos(b * x) :
    (x >= 1 && x <= 2) ? a * Math.Pow(x, 2) * Math.Log(x, Math.E) :
    (x < 1) ? 1 : x;
Console.WriteLine("Natija:" +y);
Console.ReadKey();
*/


/*  int i, s = 0;
  int n=Convert.ToInt32(Console.ReadLine());
  for (i = 1; i <= n; i++) 
  s = s + i * i;
  Console.WriteLine(s);
  Console.ReadKey();*/
/* float
     i, s = 1, p = 1;
 int n = Convert.ToInt32(Console.ReadLine());
 for (i = 1; i <= n; i++)
 {
     p = p * i;
     s = s + 1 / p;
 }
 Console.WriteLine(s);
 Console.ReadKey();*/
//30. 1 - 999 oraliqdagi butun sonlar berilgan.
//U son quyidagicha satr ko‘rinishda ifodalansin:
//“2 xonali juft son”, “3 xonali toq son” va hokazo.
/*
int b;
Console.WriteLine("a sonni kiriting>>");
int a = Convert.ToInt32(Console.ReadLine());
b = a % 2;
{
    if (b == 0 && a > 99)
        Console.WriteLine("a 3 xonali juft son");
    if (b == 1 && a > 99)
        Console.WriteLine("a 3 xonali toq son");
    if (b == 0 && a > 9 && a < 100)
        Console.WriteLine("a  2 xonali juft son");
    if (b == 1 && a > 9 && a < 100)
        Console.WriteLine("a  2 xonali toq son");
    if (b == 0 && a < 9)
        Console.WriteLine("a  1 xonali juft son");
    if (b == 1 && a < 9)
        Console.WriteLine("a  1 xonali juft son");

}
Console.WriteLine("Natija>>");
Console.ReadKey();
*/
//10. Robot to‘rtta yo‘nalish bo‘yicha harakatlanishi mumkin.
//(“1” Shimol, “2” G‘arb, “3” Janub, “4” Sharq); va uch xil buyruqni qabul qila oladi,
//ya`ni 0 harakatni davom ettirish, 1-chapga burilish, -1 o‘ngga burilish,
//c-robotning berilgan yo‘nalishi bo‘lib,
//n-unga uzatilgan buyruq bo‘lsa, berilgan buyruqdan keyingi robotning holati chop etilsin.
/*
Console.Write("c yunalishni kiriting;>>");
int c=Convert.ToInt32(Console.ReadLine());
Console.Write("n buyruqni kiriting:>>");
int n = Convert.ToInt32(Console.ReadLine());

switch(c)
{   
    case 1:
        {
            if (n == 0)
                Console.Write("Shimol");
            if (n == 1)
                Console.Write("G'arb");
            if(n==-1)
                Console.Write("Sharq ");
            break;
        }
    case 2:
        {
            if (n == 0)
                Console.Write("G'arb");
            if (n == 1)
                Console.Write("Janub");
            if(n==-1)
                Console.Write("Shimol");
            break;
        }
    case 3:
        {
            if (n == 0)
                Console.Write("Janub");
            if (n == 1)
                Console.Write("Sharq");
            if(n==-1)
                Console.Write("G'arb");
            break;
        }
    case 4:
        {
            if (n == 0)
                Console.Write(" Sharq ");
            if (n == 1)
                Console.Write(" Shimol ");
            else
                Console.Write("Janub");
            break;
        }

}

        Console.ReadKey();
*/
/*
double a=1, b=1,s = 1;
Console.Write("x sonni kiriting:>>");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("n sonni kiriting:>>");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{

    a=a*i;
    b=b*x ;
    s= s+(b/a);
}
Console.WriteLine(s);
Console.ReadKey();
*/
/*
Console.WriteLine("n sonni kiriting");
int n=int.Parse(Console.ReadLine());
int[] a = new int[n];
a[0] = 1;
    a[1] = 1;
for (int i = 2; i < n; i++)
{
    a[i] = a[i - 1] + a[i - 2];
     Console.WriteLine(a[i]);
}
Console.ReadKey();

*/
//Massiv_45- masala
/*
Console.WriteLine("n sonni kirting:");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] a=new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
  
  }
int birin = 0, final=0;
int minAbs=Math.Abs(a[1]-a[0]);
for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        int tempAbs = Math.Abs(a[i] - a[j]);
        if (tempAbs <= minAbs)
        {
            minAbs = tempAbs;
            birin = i;
            final = j;
        }
    }
}
Console.WriteLine(( birin+1)+" "+(final+1));
Console.WriteLine(minAbs);
Console.ReadKey();
*/

/*
Console.WriteLine("n sonni kirting:");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{

    a[i] = Convert.ToInt32(Console.ReadLine());

}
int d = 0, e = 0;
bool isFirst = false;
for (int i = 0; i < n; i++)
{
    if(!isFirst && a[i] == 0)
    {
        d = i;
        isFirst = true;
    }
    if (a[i] == 0)
    {
        e = i;
    }
 }
int sum = 0;
for (int i = d; i <= e; i++)
{
    sum += a[i];
}
Console.WriteLine(sum);

Console.ReadKey();
*/

/*
int n = int.Parse(Console.ReadLine()),i,j,p;
int m = int.Parse(Console.ReadLine());
int[,] a = new int[m,n];    

for(i = 0; i < n; i++)
{  
for(j= 0; j < m; j++)
    {
  
    Console.Write(a[i, j] + "\t");
      
    }
    ;
    
    Console.Write(" \n ");
}  

*/
/*

using System;
using System.Collections.Generic;
class HelloWorld
{
    static void Main()
    {
        string son = Console.ReadLine();
        Dictionary<char, int> takrorlanish = new Dictionary<char, int>();
        for (int i = 0; i < son.Length; i++)
        {
            if (takrorlanish.ContainsKey(son[i]))
            {
                takrorlanish[son[i]]++;
            }
            else
            {
                takrorlanish.Add(son[i], i);
            }
        }
        Console.WriteLine(takrorlanish.Count);
    }
}
*/
/*

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine()), s = 0;
Random r = new Random();
int[,] satr = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {

        Console.Write((satr[i, j] = r.Next(50)) + " ");
    }
    Console.WriteLine();
}
bool isOk;
for (int i = 0; i < n; i++)
{
    isOk = true;
    for (int j = 1; j < m; j++)
    {
        if (satr[i, j] < satr[i, j - 1])
        {
            isOk = false;
            break;
        }
        
    }
    if (isOk)
    {
        s++;
        for (int j = 0; j < m; j++)
        
            Console.Write($"{satr[i,j]} ");
        Console.WriteLine();
    }


}
Console.WriteLine(s);

*/
/*
int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
Console.WriteLine("Ketma-ketlikni kiriting:");
bool grow = true;
for(int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < n - 1; i++)
{
       if (massiv[i] > massiv[i +1])
        {
          grow =false;
          Console.WriteLine("Yo'q ");
          break;
        }
                
}
if(grow)
    Console.WriteLine("O'suvchi ");
*/

/*
Console.Write("n sonni kiriting:");
int n=Convert.ToInt32(Console.ReadLine());
double s = 0,k=1;
for (int i = 2; i <=2* n; i+=2)
{
    for(int j = 1; j <= i; j++)
    {
        k *= j;
    }
    
    s += k ;
    

}
Console.WriteLine($"Natija >>{s}");

Console.ReadKey();
*/
// vektor
// n ta butun sonlardan tashkil topgan massiv
// foydalanuvchini o'zi tanlagan holda
// yo max yo min topadigan dastur
// 1 marta ishlaganidan keyin yana boshidan ishlasin
// a) massiv kiritish
// b) massivdan max topish
// c) massivdan min topish
// d) tugatish

/*int min, max, n = 0, topshiriq;
int[] massiv = new int[n];

Console.WriteLine("Massivlar bilan ishlovchi dastur");
while (true)
{
    Console.WriteLine("Nima qilmoqchisiz?");
    Console.WriteLine("a) massiv kiritish (1)");
    Console.WriteLine("b) max topish (2)");
    Console.WriteLine("c) min topish (3)");
    Console.WriteLine("d) tugatish (4)");
    topshiriq = Convert.ToInt32(Console.ReadLine());
    if (topshiriq == 4)
    {
        break;
    }
    if (topshiriq == 1)
    {
        Console.Write("massiv elementlari sonini kiriting: ");
        n = Convert.ToInt32(Console.ReadLine());
        massiv = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            massiv[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    if (topshiriq == 2)
    {
        if (n <= 0)
        {
            Console.WriteLine("Hali massiv kiritilmagan!");
            continue;
        }
        max = massiv[0];
        for (int i = 0; i < n; i++)
        {
            if (max < massiv[i]) min = massiv[i];
        }
        Console.WriteLine("max = " + max);
    }
    if (topshiriq == 3 && n > 0)
    {
        min = massiv[0];
        for (int i = 0; i < n; i++)
        {
            if (min > massiv[i]) min = massiv[i];
        }
        Console.WriteLine("min = " + min);
    }
}
Console.WriteLine("Dastur tugadi");*/
/*
int min, max, n = 0, topshiriq;
int[] massiv = new int[n];
bool birinchi = true;

Console.WriteLine("Massivlar bilan ishlovchi dastur");
while (true)
{
    Console.WriteLine("Nima qilmoqchisiz?");
    if (birinchi)
    {
        Console.WriteLine("a) massiv kiritish (1)");
        Console.WriteLine("b) tugatish (4)");
    }
    else
    {
        Console.WriteLine("a) massiv kiritish (1)");
        Console.WriteLine("b) max topish (2)");
        Console.WriteLine("c) min topish (3)");
        Console.WriteLine("d) tugatish (4)");
    }
    topshiriq = Convert.ToInt32(Console.ReadLine());
    if (topshiriq == 4)
    {
        break;
    }
    if (topshiriq == 1)
    {
        Console.Write("massiv elementlari sonini kiriting: ");
        n = Convert.ToInt32(Console.ReadLine());
        massiv = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            massiv[i] = Convert.ToInt32(Console.ReadLine());
        }
        birinchi = false;
    }
    if (topshiriq == 2)
    {
        if (n <= 0)
        {
            Console.WriteLine("Hali massiv kiritilmagan!");
            continue;
        }
        max = Int32.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (max < massiv[i])
                max = massiv[i];
        }
        Console.WriteLine("max = " + max);
    }
    if (topshiriq == 3 && n > 0)
    {
        min = massiv[0];
        for (int i = 1; i < n; i++)
        {
            if (min > massiv[i]) min = massiv[i];
        }
        Console.WriteLine("min = " + min);
    }
}
Console.WriteLine("Dastur tugadi");
*/
//Console.WriteLine("n sonni kiriting:");
//double k = 1, s;
//int n=Convert.ToInt32(Console.ReadLine());
//int[] massiv=new int[n];
//for(int i=0; i<n; i++)
//{
//    massiv[i]=Convert.ToInt32(Console.ReadLine()); 
//    k=k*massiv[i]; 
//    double p = k;
//}

//Console.WriteLine(k);
//s = Math.Pow(k,(1/n));
//Console.WriteLine($"Natija:{s}");
//Console.ReadKey();
//static int F(int n, int k = 5)
//{
//    k = n / k;
//    return n - k;
//}

//static void Main(string[] args)
//{
//    int n = 7, c = 2, k = 2;
//    int[] a = { 1, 2, 3, 6, 4 };
//    for (int i = 0; i < 5; i++)
//    {
//        if (F(n, a[i] - n) - F(n - a[i], c) < 0)
//            c = c + F(c, c);
//    }
//    Console.WriteLine(c);


//    Console.ReadKey();


//int n=Convert.ToInt32(Console.ReadLine());
//double sumone = 0, sumtwo = 0;
//int first=0,final = 0;
//int[] arr=new int[n];
//int i = 1;
//for(;i<n;i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//for(i=0;i<n;i++)
//{

//}
//using System;

//int[,] A=new int[4,5];
//int[,] B = new int[4, 5];
//int[,] C = new int[4, 5];
//int[,] N = new int[4, 5];
//int[,] D = new int[8, 15];

//for(int i=0; i<4; i++)
//{
//    for(int j=0; j<5; j++)
//    {
//        A[i, j] = 1;
//        Console.Write(" " + A[i,j]);
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        B[i, j] = 2;
//        Console.Write(" " + B[i, j]);
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        C[i, j] = 3;
//        Console.Write(" " + C[i, j]);
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        A[i, j] = 0;
//        Console.Write(" " + N[i, j]);
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("D matritsani hosil qilinishi:");

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        D[i, j] = 1;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");

//    for (int j = 5; j < 10; j++)
//    {
//        D[i, j] = 2;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");

//    for (int j = 10; j < 15; j++)
//    {
//        D[i, j] = 3;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");
//    Console.WriteLine();

//}
//Console.WriteLine();

//for (int i = 4; i < 8; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        D[i, j] = 2;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");

//    for (int j = 5; j < 10; j++)
//    {
//        D[i, j] = 0;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");
//    for (int j = 10; j <15; j++)
//    {
//        D[i, j] = 1;
//        Console.Write(" " + D[i, j]);
//    }
//    Console.Write(" ");
//    Console.WriteLine();
//}




//Here 's an example C# code that finds a pair of numbers from 1 to n whose sum of divisors is equal:

//csharp
//Copy code


//static int SumOfDivisors(int num)
//{
//    int sum = 0;
//    for (int i = 1; i <= num / 2; i++)
//    {
//        if (num % i == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum + num;
//}
//static void Main(string[] args)
//{
//    int n = 100;

//    for (int i = 1; i <= n; i++)
//    {
//        int sumOfDivisors_i = SumOfDivisors(i);
//        for (int j = i + 1; j <= n; j++)
//        {
//            int sumOfDivisors_j = SumOfDivisors(j);
//            if (sumOfDivisors_i == sumOfDivisors_j)
//            {
//                Console.WriteLine("{0} and {1} have the same sum of divisors: {2}", i, j, sumOfDivisors_i);
//                return ;
//            }
//        }
//    }
//}
//SumOfDivisors(10);




//static int SumOfDivisors(int num)
//{
//    int sum = 0;

//    for (int i = 1; i <= num; i++)
//    {
//        if (num % i == 0)
//        {
//            sum += i;
//        }
//    }

//    return sum;
//}



//Console.WriteLine("N sonni kiriting>>");
//int n = Convert.ToInt32(Console.ReadLine()); 
//static void Findnumbers(int n)
//{
//    int num1 = 0, num2 = 0;
//    for (int i = 1; i <= n; i++)
//    {
//      int sum1 = SumOfDivisors(i);
//        for (int j = i+1; j <= n; j++)
//        {
//         if (sum1 == j)
//            {
//                num1 = sum1 ;
//                num2 = j;
//            }
//        }

//        Console.WriteLine($"Do'st sonlar juftligi: ({num1}, {num2})");
//    }
//}

//Findnumbers(n);



//Console.WriteLine("N sonni kiriting");
// int n =Convert.ToInt32(Console.ReadLine());
//Dictionary<int, int> sumOfDivisors = new Dictionary<int, int>();

//// Precompute sum of divisors for all numbers from 1 to n
//for (int i = 1; i < n; i++)
//{
//    int sum = 0;
//    for (int j = 1; j * j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            sum += j;
//            if (j * j != i)
//            {
//                sum += i / j;
//            }
//        }
//    }
//    sumOfDivisors[i] = sum;
//}

////
//for (int i = 1; i < n; i++)
//{
//    for (int j = i + 1; j < n; j++)
//    {
//        if (sumOfDivisors[i] == sumOfDivisors[j])
//        {
//            Console.WriteLine("{0} and {1} have the same sum of divisors ({2})", i, j, sumOfDivisors[i]);
//        }
//    }
//}



//Console.WriteLine("N sonni kiriting");
//int n = Convert.ToInt32(Console.ReadLine());
//Dictionary<int, int> sumOfDivisors = new Dictionary<int, int>();


//for (int i = 1; i <= n; i++)
//{
//    int sum = 0;
//    for (int j = 1; j <= i / 2; j++)
//    {
//        if (i % j == 0)
//        {
//            sum += j;
//        }
//    }
//    sumOfDivisors[i] = sum;
//}


//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= n; j++)
//    {
//        if (sumOfDivisors[i] ==j)
//        {
//            Console.WriteLine("Friend numbers: {0}, {1}", i, j);

//        }
//    }
//}

//int[] sumOfDivisors = new int[n + 1];

//// Calculate sum of divisors for each number from 1 to n
//for (int i = 1; i <= n; i++)
//{
//    for (int j = i; j <= n; j += i)
//    {
//        sumOfDivisors[j] += i;
//    }
//}

//for (int i = 1; i <= n; i++)
//{
//    for (int j = i + 1; j <= n; j++)
//    {
//        if (sumOfDivisors[i] == sumOfDivisors[j])
//        {
//            Console.WriteLine("Pair of numbers: {0}, {1},{2}", i, j, sumOfDivisors[i]);

//        }
//    }
//}



//This problem solved 

//using System;

//public class Program
//{
//    static void Main()
//    {
//        var watch = new System.Diagnostics.Stopwatch();
//        watch.Start();
//        Console.WriteLine("n sonni kiriting:");
//        int limit = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("{0} gacha  bo'gan sonlar orasidan do'st sonlarni izlaymiz:", limit);
//        for (int i = 1; i < limit; i++)
//        {


//            for (int j = i + 1; j <= limit; j++)
//            {
//                int iSum = SumDivisors(i);
//                int jSum = SumDivisors(j);
//                if (iSum == j && jSum == i)
//                {
//                Console.WriteLine($"{i},{j}");
//                ShowDivisors(i);
//                Console.WriteLine();
//                ShowDivisors(j);
//                Console.WriteLine();
//                }

//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Finished");
//        watch.Stop();
//        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
//        Console.ReadKey();
//    }

//    static int SumDivisors(int n)
//    {
//        int sum = 0;
//        for (int i = 1; i <= n/2; i++)
//        {
//            if (n % i == 0)
//            {
//                sum += i;
//            }
//        }
//        return sum;
//    }

//    static void ShowDivisors(int num)
//    {
//        Console.Write($"{num} ning bo'luvchilari: ");
//        for (var i = 1; i <= num/2; i++)
//        {
//            if (num % i == 0)
//            {
//                Console.Write(i + ",");
//            }
//        }
//    }
//}


//This problem solved too
//Random rand = new Random();
//int[,] A = new int[4, 5] { { 1, 1, 1, 1, 1 },
//                         { 1, 1, 1, 1, 1 },
//                         { 1, 1, 1, 1, 1 },
//                         { 1, 1, 1, 1, 1 } };
//int[,] B = new int[4, 5] { { 2, 2, 2, 2, 2 },
//                            { 2, 2, 2, 2, 2 },
//                            { 2, 2, 2, 2, 2 },
//                            { 2, 2, 2, 2, 2 } };

//int[,] C = new int[4, 5] { { 3, 3, 3, 3, 3 },
//                           { 3, 3, 3, 3, 3 },
//                           { 3, 3, 3, 3, 3 },
//                           { 3, 3, 3, 3, 3 }, };

//int[,] D = new int[8, 15];
//int[,] N = new int[4, 5] { { 0, 0, 0, 0, 0 },
//                            { 0, 0, 0, 0, 0 },
//                            { 0, 0, 0, 0, 0 },
//                            { 0, 0, 0, 0, 0 }, };


//static int[,] Constr(int[,] A, int[,] B, int[,] C, int[,] D)
//{

//    int[,] N = new int[4, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, };
//    for (int i = 0; i < 4; i++)
//    {
//        for (int j = 0; j < 15; j++)
//        {
//            if (j < 5)
//            {
//                D[i, j] = A[i, j];
//            }
//            if (5 <= j && j < 10)
//            {
//                D[i, j] = B[i, j - 5];
//            }
//            if (10 <= j && j < 15)
//            {
//                D[i, j] = C[i, j - 10];
//            }
//        }
//    }
//    for (int i = 4; i < 8; i++)
//    {
//        for (int j = 0; j < 15; j++)
//        {
//            if (j < 5)
//            {
//                D[i, j] = B[i - 4, j];
//            }
//            if (5 <= j && j < 10)
//            {
//                D[i, j] = N[i - 4, j - 5];
//            }
//            if (10 <= j && j < 15)
//            {
//                D[i, j] = A[i - 4, j - 10];
//            }
//        }
//    }

//    for (int i = 0; i < 8; i++)
//    {
//        for (int j = 0; j < 15; j++)
//        {

//            Console.Write(D[i, j] + " ");
//            if (j == 4 | j == 9)
//                Console.Write("\t");
//        }
//        if (i == 3)
//            Console.WriteLine();
//        Console.WriteLine();
//    }
//    return D;
//}

//Constr(A, B, C, D);
//int n=Convert.ToInt32(Console.ReadLine());
//double[] numbers =new double[n];
//double almashuvchi;
//for(int i=0;i<n;i++)
//{
//    numbers[i] = Convert.ToDouble(Console.ReadLine());  
//}
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[i] > numbers[j])
//        {
//            almashuvchi = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = almashuvchi;
//        }
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(numbers[i]);
//}





//a-sharti
//string temp = "One two three .Welcome to Uzbekistan";

//Console.WriteLine(temp.Replace("One"," 1 "));


//b-sharti
//string input = "examplexjjxfs";

//if (input.EndsWith("x"))
//{
//    string output = input.Substring(0, input.Length - 1) + "ks";
//    Console.WriteLine(output);
//}
//else
//{
//    Console.WriteLine(input);
//}
//d-sharti

//string enterstring = "I am solving the problems at the moments";

//string deletedstring = enterstring.Replace("th", "");

//Console.WriteLine(deletedstring);

//e-sharti

//string matn=Convert.ToString(Console.ReadLine());
//string changedstring = matn.Replace("q", "qu");
//Console.WriteLine(changedstring);


//using Labaratory_uneversity1;
//Example people = new Example();
//people.age = 19;
//people.name = "Baxtjon";
//people.job = "Teacher";
//people.Get_age();


//Animal dog=new Animal();
//dog.name = "Xatiko";
//dog.gender = "erkak";
//dog.color = "qora";
//dog.get_info();

//To_rtburchakcs shakl1 = new To_rtburchakcs(1, 3, 2, 5);
//To_rtburchakcs shakl2 = new To_rtburchakcs(3, 9, 7, 2);
//Console.WriteLine(shakl1.Yuza());
//Console.WriteLine(shakl2.Yuza());
//Console.WriteLine(shakl1.Taqqoslash(shakl2.Yuza()));
//Console.WriteLine();

using System;

abstract class Distance {
    public abstract double Calculate(double[] point1, double[] point2);
}

class Cartesian : Distance {
    public override double Calculate(double[] point1, double[] point2) {
        double sum = 0;
        for (int i = 0; i < point1.Length; i++) {
            double diff = point1[i] - point2[i];
            sum += diff * diff;
        }
        return Math.Sqrt(sum);
    }
}

class Chebyshev : Distance {
    public override double Calculate(double[] point1, double[] point2) {
        double maxDiff = 0;
        for (int i = 0; i < point1.Length; i++) {
            double diff = Math.Abs(point1[i] - point2[i]);
            if (diff > maxDiff) {
                maxDiff = diff;
            }
        }
        return maxDiff;
    }
}

class Hemming : Distance {
    public override double Calculate(double[] point1, double[] point2) {
        int numDiff = 0;
        for (int i = 0; i < point1.Length; i++) {
            if (point1[i] != point2[i]) {
                numDiff++;
            }
        }
        return numDiff;
    }
}
```

You can then use these classes as follows:

```
double[] point1 = new double[] { 1, 2 };
double[] point2 = new double[] { 3, 4 };

Distance distance = new Cartesian();
double dist = distance.Calculate(point1, point2);   // calculates Cartesian distance
Console.WriteLine(dist);

distance = new Chebyshev();
dist = distance.Calculate(point1, point2);   // calculates Chebyshev distance
Console.WriteLine(dist);

distance = new Hemming();
dist = distance.Calculate(point1, point2);   // calculates Hemming distance
Console.WriteLine(dist);

