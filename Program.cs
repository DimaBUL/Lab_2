using System;
using System.Security.Cryptography;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Shed("Ser1", 2,3,5);
            var a2 = new Shed("Ser2", 3,3,10);

            
            a2.TypeAttrShed();
            
            Console.WriteLine(a1.GetSize());
            Console.WriteLine(a1.GetName());
            
            a1.ExpandSize(2,1,2);
            
            Console.WriteLine(a1.GetSize());
            
            var a3 = a1.Clone();
            Console.WriteLine(a1.Equals(a3));
            Console.WriteLine(a3);
            
            Console.WriteLine(a1.GetHashCode() + " " + a3.GetHashCode());
            Console.WriteLine(a1.CompareTo(a2));
            
            
        }
    }
}