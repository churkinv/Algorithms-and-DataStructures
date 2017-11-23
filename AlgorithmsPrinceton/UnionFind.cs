using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPrinceton
{
    class UnionFind
    {
        private int[] id;
        public UnionFind(int n) //UF(int N) initialize union-find data structure with N objects(0 to N – 1)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        private int root(int i) // quick union
        {

            #region quick union
            //while (i != id[i]) i = id[i];
            //return i;
            #endregion

            #region weighted quick union
            while (i != id[i])
            {
                id[i] = id[id[i]];
                i = id[i];
            }
            return i;
            #endregion

        }

        public void union(int p, int q) //add connection between p and q
        {
            #region quick find
            //int pid = id[p]; 
            //int qid = id[q]; 

            //for (int i = 0; i < id.Length; i++) 
            //{
            //    if (id[i] == pid) id[i] = qid; 
            //}
            #endregion

            #region quick union
            int i = root(p);
            int j = root(q);
            id[i] = j;
            #endregion

        }

        public bool connected(int p, int q) //are p and q in the same component?
        {
            //return id[p] == id[q];  // quick find
            return root(p) == root(q);  // quick union
        }

        public int find(int p) // component identifier for p(0 to N – 1)
        {

            #region quick find 
            int? q = null;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == p) q = i;
            }
            return (int)q;
            #endregion

        }

        public int count() // number of components
        {
            return 0;
        }
    }
}
