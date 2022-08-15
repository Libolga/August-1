using System;
using System.Globalization;
 

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i  = null!;
             i = Console.ReadLine().Split(' ');
            
            int b = Convert.ToInt32(i[1]);
            
            Console.WriteLine(b);
 
 
 
        }
    }
}

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i  = null!;
            string txt = 'Нет 3й цифры';
            
             i = Console.ReadLine().Split(' ');
            
            int b = Convert.ToInt32(i[2]);
            if (b == null) {
                    Console.WriteLine(txt);
            }
            Console.WriteLine(b);
 
 
 
        }
    }
}