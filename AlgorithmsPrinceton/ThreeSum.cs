using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPrinceton
{
    class ThreeSum
    {
        public static int Count(int [] array)
        {
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)          
                for (int j = i+1; j < n; j++)              
                    for (int k = j+1; k < n; k++)                    
                        if (array[i] + array[j] + array[k] == 0) count++;
            return count;     
        }
    }
}
