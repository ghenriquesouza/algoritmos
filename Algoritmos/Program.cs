using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    class Program
    {
       
        static int jumpingOnClouds(int[] c)
        {
            int jump = 0;
            int countZeros = 0;
            for (int i = 0; i < c.Length; i++)
            {
                
                if (c[i] == 0)
                {
                    if (countZeros >=2 )
                    {
                        jump++;
                        countZeros = 0;
                    }
                        
                    countZeros++;
                }
                else
                {
                    if (countZeros >= 2 && (i + 1< c.Length -1))
                    {
                        jump += 2;
                    }
                    else
                        jump++;
                    countZeros = 0;
                }

                if (i + 1 == c.Length)
                {
                    if (countZeros > 0)
                    {
                        jump++;
                        break;
                    }

                }


            }
                return jump;

        }

        static void Main(string[] args)
        {
            //0, 1, 0, 0, 1, 0
            //0, 0, 1, 0, 0, 1, 0
            //0, 0, 0, 1, 0, 0
            //0, 0, 0, 0, 0, 0
            //0, 0, 0, 0, 0, 1, 0
            var teste = jumpingOnClouds(new int[] { 0, 0, 0, 0, 0, 1, 0 });
        }
    }
}
