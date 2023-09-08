using static System.Net.Mime.MediaTypeNames;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            String s10 = String.Join(" ", values); // 
            //natija: "apple a day keeps a doctor away" satri
            Console.WriteLine(s10);
                        string s1 = "hello";
            string s2 = "world";
            int result = String.Compare(s1, s2);
            if (result < 0)
            { Console.WriteLine("s1 satr s2 satrni oldida"); }
            else if (result > 0)
            { Console.WriteLine("s1 satr s2 satrni oxirida"); }
            else
            { Console.WriteLine("s1 va s2 satrlari bir xil"); }
            // natija: "s1 satr s2 satrni oldida"
            
            string s1 = "hello world";
            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch); // 4 ga teng
            Console.WriteLine(indexOfChar);
            string subString =
            "wor";
            int indexOfSubstring = s1.IndexOf(subString);
            // 6 ga teng
            Console.WriteLine(indexOfSubstring);
            
            string text ="Shuning uchun ham shu ish sodir bo'ldi";

            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            string text = "Assalomu aleykum";
            // uchinchi belgidan boshlab qirqish
            text = text.Substring(5);
            // natija "salomu aleykum"
            Console.WriteLine(text);
            // birinchidan oxirgi ikki belgigacha kesish
            text = text.Substring(0, text.Length - 5);
            // natija "salomu aleyk"
            Console.WriteLine(text);
            
            string text = "Xayrli kun";
            string subString =
            "va baroqatli ";
            text = text.Insert(7, subString);
            Console.WriteLine(text);
            string text = "Assalomu aleykum";
            // oxirgi belgining indeksi
            int ind = text.Length - 1;
            // oxirgi belgini o’chiramiz
            text = text.Remove(ind);
            Console.WriteLine(text);
            // birinchi ikkita belgini o’chiramiz
            text = text.Remove(0, 2);
            Console.WriteLine(text);
            string text = "Assalomu aleykum";
            text = text.Replace("Assalomu","vo");
            Console.WriteLine(text);
            text = text.Replace("a","v");
            Console.WriteLine(text);
            */

            // string second = "Yaqin kunlarda ";

            //Console.WriteLine((second.GetType));
            //Console.WriteLine("n sonni kiriting:");
            //double k = 1, s;
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] massiv = new double[n];
            //double p = (1/n);
            //for (int i = 0; i < n; i++)
            //{
            //    massiv[i] = Convert.ToDouble(Console.ReadLine());


            //}

            //Console.WriteLine($"Natija:{Math.Pow(c,p)}");*/



            //string text =Console.ReadLine();
            //string result = "";
            //foreach (var item in text)
            //{
            //    if (!result.Contains(item))
            //    {
            //        result += item;
            //    }
            //}
            //System.Console.WriteLine(result);
            //Console.ReadKey();



            //
            // Strings_1
            //Console.Write("Enter a character: ");
            //char input = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //int asciiCode = Convert.ToInt32(input);
            //Console.WriteLine("ASCII code of {0} is {1}", input, asciiCode);

            //Strings_2
            //for(int n = 32; n < 127; n++)
            //{
            //    Console.WriteLine("{0}>>{1}",n,(char)n);
            //}

            //Strings_3
            //Console.Write("Enter a character: ");
            //char input = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //int asciiCode = Convert.ToInt32(input);
            //Console.WriteLine("Left {0}  Right {1}", (char)(asciiCode-1), (char)(asciiCode+1));

            //Strings_4
            //int n=Convert.ToInt32(Console.ReadLine());
            //for(int i=65; i<n+65; i++)
            //{
            //    Console.WriteLine((char)i);
            //}

            //String_5
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 122; i >122-n; i--)
            //{
            //    Console.WriteLine((char)i);
            //}

            //Strings_6
            //Console.WriteLine("Enter a character: ");
            //char input =Convert.ToChar(Console.ReadLine());
            //int asciiCode = Convert.ToInt32(input);
            //Console.WriteLine();
            //if(48<=asciiCode && asciiCode<=57)
            //{
            //    Console.WriteLine("This is digit");
            //}
            //else if(65 <= asciiCode && asciiCode <= 90 || 97 <= asciiCode && asciiCode <= 122)
            //{
            //    Console.WriteLine("This is lotin");
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}

            //Strings_7
            //Console.WriteLine("Bironta so'zni kiriting:");
            //string entered=Convert.ToString(Console.ReadLine());
            //Console.WriteLine(Convert.ToInt32(entered[entered.Length-1]));
            //Console.WriteLine(Convert.ToInt32(entered[0]));



            //string_8
            /*
            int n=Convert.ToInt32(Console.ReadLine());
            char harf = 'A';
             string soz=new string(harf,n);
            Console.WriteLine(soz);
            */
            //string_9
            /*
            string first = "Sessiya jadvali qachon chiqadi";
         
            Console.WriteLine(first+" "+second);
            */
            //string_10
            /*
            string str =Console.ReadLine();
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
            for(int c = str.Length-1;c>=0;c--)
            {
                Console.Write(str[c]);
            }
            */
            //string_11
            /*
            string inered=Console.ReadLine();
            foreach(char i in inered)
            {
                Console.Write(" "+i);
            }
            */
            //string_12

            //string enterd=Console.ReadLine();
            //int n=Convert.ToInt32(Console.ReadLine());
            //string belgi=new string('*',n);

            //for(int i=0;i<enterd.Length;i++)
            //{
            //    Console.Write(enterd[i]+belgi);   

            //string_13
            /*
            string input = Console.ReadLine();
            int[] ascicode=new int[input.Length];
            int numbers=0,upper=0,lower=0;  
            for(int i = 0; i < input.Length; i++)
            {
                ascicode[i] = Convert.ToInt32(input[i]);
            }
            Console.WriteLine();
            for(int i = 0; i < ascicode.Length; i++)
            {
                 if (48 <= ascicode[i] && ascicode[i] <= 57)
                    {
                        numbers++;
                    }
                 else if (65 <= ascicode[i] && ascicode[i] <= 90 )
                    {
                        upper++;    
                    }
                 else if(97 <= ascicode[i] && ascicode[i] <= 122)
                    {
                        lower++;
                    }
            }
            Console.WriteLine("Bosh harflar:{0}",upper);
            Console.WriteLine("Kichik harflar:{0}",lower);
            Console.WriteLine("Sonlar harflar:{0}",numbers);
            */

            //Strings_16
            //1-usul
            //string input = Console.ReadLine();
            //Console.WriteLine(input.ToLower());
            //Console.WriteLine(input.ToUpper());

            //2-usul
            //string input = Console.ReadLine();
            //string changed ="";
            //int[] ascicode = new int[input.Length];
            //int numbers = 0, upper = 0, lower = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    ascicode[i] = Convert.ToInt32(input[i]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < ascicode.Length; i++)
            //{
            //    if (97 <= ascicode[i] && ascicode[i] <= 122)
            //    {
            //        changed+=(char)(ascicode[i]-32);
            //    }
            //    else if (65 <= ascicode[i] && ascicode[i] <= 92)
            //    {
            //        changed += (char)(ascicode[i] + 32);
            //    }

            //}
            //Console.WriteLine(changed);

            //Strings_19 
            string input = Console.ReadLine();
            int[] ascicode = new int[input.Length];
            bool floatname=true,notnumber=true,doublenumber=true;   
            for (int i = 0; i < input.Length; i++)
            {
                ascicode[i] = Convert.ToInt32(input[i]);
            }
            for (int i = 0; i < ascicode.Length; i++)
            {
                if (48 <= ascicode[i] && ascicode[i] <= 57)
                {
                   floatname = true;
                    doublenumber = false;
                    notnumber = false;
                }
                else if (ascicode[i] == 46)
                {
                    doublenumber = true;
                    notnumber = false;
                    floatname = false;
                }
                else
                {
                    notnumber = true;
                    floatname = false;
                    doublenumber = false;
                }

            }
            if (floatname)
            {
                Console.WriteLine("This is float");
            }
            else if (!doublenumber)
            {
                Console.WriteLine("This is double");
            }
            else Console.WriteLine("This isn't number");

        }
    }
}