using System;
using MesMethodes.core;

namespace Travail_algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 7, 8, 9 };
            MesMethodesList mesMethodesList = new MesMethodesList();
            mesMethodesList.InverseListe(list);
            int s = mesMethodesList.SommeListe(list);
            Console.WriteLine(s);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}