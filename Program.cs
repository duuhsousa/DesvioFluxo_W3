using System;

namespace DesvioFluxo_W3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=1,h=5,j;
            for(int i=0;i<=10;i++)
            {
                for(j=k;j<=h;j++)
                {
                    Console.Write(j+"X"+i+"="+j*i+"\t");
                }
                Console.WriteLine();
                if(i==10 && j==6)
                {
                    i=0;
                    k=6;
                    h=10;
                    Console.WriteLine();
                } 
            }
            Console.WriteLine();
        }
    }
}
