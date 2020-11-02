using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGestionMemoire
{
    class Program
    {
        delegate int DELG(int v1, int v2);

        static void Main(string[] args)
        {
            int k = 0;
            int j = 0;
            DELG d = new DELG(work.methode);
            Console.WriteLine("donnez le 1er nombre :");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("donnez le 2eme nombre :");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((d.Invoke(k, j).ToString()));
            Console.Read();
        }
    }
    static class work
    {
        static public int methode(int v1, int v2)
        {
            return v1 + v2;
        }

    }
}
