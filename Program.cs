using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_2_megoldó_képlet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ax^2: \t");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("bx: \t");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: \t");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("ax^2 + bx + c\n");
            Console.WriteLine(ax+"x^2 + "+bx+"x + "+c+"\n");
            
            int xpm=0;
            if (bx<0)
            {
                bx = bx * (-1);
                //Console.WriteLine(bx);
            }
            else if (bx>0)
            {
                bx = -(bx);
                //Console.WriteLine(xpm);
            }
            Console.WriteLine(@"
       _________
-b +-\|b^2-4*a*c
_________________
        2a");
            Console.Write(@"
       _________");
            Console.Write(               
"\n-"+bx+" +-");
            Console.Write(@"\|");
            Console.Write("{0}^2-4*{1}*{2}",bx,ax,c);
            Console.WriteLine("\n"+@"_________________");
            Console.WriteLine("\t2*"+ax+"\n");

            int negyzet=bx*bx, nevezo=2*ax;
            double gyok_alatt = negyzet - (4*ax*c);
            Console.Write(@"
       ___");
            Console.Write(
"\n-" + bx + " +-");
            Console.Write(@"\|");
            Console.Write("{0}", gyok_alatt );
            Console.WriteLine("\n" + @"__________");
            Console.WriteLine("    " + nevezo + "\n");
            int x1;
            int x2;
            if (gyok_alatt<0)
            {
                Console.WriteLine("\nNincs megoldás");
            }
            else
            {   
                x1 = (bx +((int)Math.Sqrt(gyok_alatt)))/nevezo;
                x2 =(bx - ((int)Math.Sqrt(gyok_alatt)))/nevezo;
                Console.WriteLine("\nx1: "+x1);
                Console.WriteLine("x2: "+x2);
            }




            Console.ReadKey();
        }
    }
}
