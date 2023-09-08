using System.Drawing;

namespace son_top
{
    internal class Program
    { 
        
        
        
        static int Son_top(int x=11)
        {
             Random rand = new Random();
             int tasodifiyson = rand.Next(1,x);
            Console.WriteLine($"1 dan {x} gacha son o'yladim topa olasizmi:");
            Console.WriteLine("Let's go>>");
            int taxminlar = 0;
        
            while (true)
            {
                     taxminlar += 1;
                    int taxmin=Convert.ToInt32(Console.ReadLine());
                    if(taxmin<tasodifiyson)
                     {
                    Console.WriteLine($"Xato. men o'ylagan son bundan kattaroq.Yana harakat qiling ");
                     }
                    else if(taxmin>tasodifiyson)
                     {
                    Console.WriteLine($"Xato. men o'ylagan son bundan kichikroq.Yana harakat qiling ");
                     }
                    else
                     {
                       break;
                     }

                
            }
             Console.WriteLine($"Tabriklaymiz men {tasodifiyson} sonini o'ylagandim .{taxminlar} ta urinish bilan topdingiz?");

            return taxminlar;
        }
         
        static int Son_topcomp(int x=11)
        {
            Console.WriteLine($"1 dan {x} gacha son o'ylang va istalgan tugmani bosing.Men topaman>>");
            Console.ReadLine();
            int begin = 1;
            int end = x;
            int taxminlar = 0;
            int son = 0;
            Random rand = new Random();
            
            while(true)
            {
                taxminlar++;
                if (begin != end)
                { 
                    int taxmin = rand.Next(begin,end);
                    son = taxmin;
                }
                else
                {
                    begin = end;
                }

                Console.WriteLine($"Siz {son} sonini o'yladingiz,to'g'ri (t) , men o'ylagan son bundan kattaroq (+) yoki kichikroq (-)");
                char javob=Convert.ToChar(Console.ReadLine());
                {
                    if (javob == '-')
                    {
                        end = son - 1;
                    }
                    else if (javob == '+')
                    {
                        begin = son + 1;
                    }
                    else { break; }
                }
            }
            Console.WriteLine($"Men topdim siz {son} sonini o'ylagan ekansiz");
            Console.WriteLine($"Men {taxminlar} ta  tahmin bilan topdim.");
            return taxminlar;
        }
        static void Play(int x = 11)
        {
           bool yana=true;
            while (true)
            {
               int tahminlar_user = Son_top();
               int  tahminlar_comp = Son_topcomp();
                if (tahminlar_comp > tahminlar_user)
                    Console.WriteLine("Siz yutdiz?");
                else if (tahminlar_user > tahminlar_comp)
                    Console.WriteLine("Men yutdim?");
                else
                    Console.WriteLine("Durrang");
                Console.WriteLine("O'yinni davom ettirasizmi ?.Ha(1)/yoq(0)");
                int what=Convert.ToInt32(Console.ReadLine());
                {
                    if (what == 1)
                        yana =true;
                    else
                        break;
                }
            }
        }
        static void Main(string[] args)
        {

            Play();

        }
       


    }
}
       