using System;

namespace AlgorithmsPrinceton
{
    public class Percolation
    {
        int[,] grid;
        bool elementState;
        int site;
        Random random; 

        public Percolation(int n) // create n-by-n grid, with all sites blocked
        {
            
            if (n <= 0) throw new ArgumentException("The value should be more than 0");
            grid = new int[n, n];
            random = new Random();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    grid[i, j] = random.Next();
                }       
            }
        }
        public void open(int row, int col) // open site (row, col) if it is not open already
        {
            
        }
        public bool isOpen(int row, int col) // is site (row, col) open?
        {
            return true;
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
