using System;
using System.IO;

namespace Jonpaulsalomon.JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int pulos = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i + 1 < c.Length)
                {
                    if (i + 2 >= c.Length || c[i + 1] != 0 || c[i + 2] != 0)
                    {
                        if (c[i + 1] == 0)
                        {
                            pulos += 1;
                        }
                        else if (c[i + 1] == 1)
                        {
                            pulos += 1; i += 1;
                        }
                    }
                    else
                    {
                        pulos += 1; i += 1;
                    }
                }
            }

            return pulos;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadKey();
            //Console.Flush();
            //Console.Close();
        }
    }
}
