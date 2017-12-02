using System;
using System.Collections.Generic;

namespace AlgorithmsPrinceton
{
    public class Percolation
    {
        int side = 4;
        Dictionary<Dictionary<int, bool>, bool> element;
        bool [,] grid;
        int count;   
        Random random;       

        public Percolation(int n) // create n-by-n grid, with all sites blocked
        {            
            if (n <= 0) throw new ArgumentException("The value should be more than 0");
            grid = new bool[n, n];
            element = new Dictionary<int, bool> { };
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    //site.Add(grid[i, j], false);
                }       
            }
        }
        public void open(int row, int col) // open site (row, col) if it is not open already
        {
            grid[row, col] = true;
        }
        public bool isOpen(int row, int col) // is site (row, col) open?
        {
            if(grid[row,col] == true) return true;

            return false;
        }
        public bool isFull(int row, int col) // is site (row, col) full?
        {
            return true;
        }
        public int numberOfOpenSites() // number of open sites
        {
            return 0;
        }
        public bool percolates()// does the system percolate? 
        {
            return true;
        }
    }
}
