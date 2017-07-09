using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,p=1;
            string str = Console.ReadLine();
            string[] s = str.Split('*');
            n = s.Length;
            for (i = 0; i < n; i++)
                p *= Convert.ToInt32(s[i]);
            Console.WriteLine(str + " = " + p);
            Console.ReadKey();  
        }
    }
}
