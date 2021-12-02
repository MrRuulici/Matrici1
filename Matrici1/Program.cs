using System;

namespace Matrici1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            bool Identitate = true;
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j < matrix.GetLength(1);j++)
                {
                    Console.Write($"[{i},{j}]= ");
                    matrix[i,j] = Int32.Parse(Console.ReadLine());
                    if(i!=j)
                    {
                        if(matrix[i,j] != 0)
                        {
                            Identitate = false;
                        }
                    }
                    else if (matrix[i, j] != 1)
                    {
                        Identitate = false;
                    }
                }
            }
            if (Identitate == true)
                Console.WriteLine("Este matrice identitate");
            else Console.WriteLine("Nu este matrice identitate");

        }
    }
}
