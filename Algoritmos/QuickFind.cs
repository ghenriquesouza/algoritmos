using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class QuickFind
    {
        private int[] itens;
        public QuickFind(int arraySize)
        {
            itens = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                itens[i] = i;
            }
        }

        public bool isConnected(int point1, int point2)
        {
            return itens[point1] == itens[point2];
        }

        public void unionPoints(int point1, int point2)
        {
            int idPoint1 = itens[point1];
            int idPoint2 = itens[point2];


            for (int i = 0; i < itens.Length; i++)
            {
                if (itens[i] == idPoint1) itens[i] = idPoint2;
            }
        }
    }
}
