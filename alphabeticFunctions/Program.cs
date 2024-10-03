using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabeticFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Berkay";
            string surname = "      Karaduman";
            Console.WriteLine(name.ToLower() + " " + surname.ToUpper());
            Console.WriteLine(name.StartsWith("B") + " " + surname.EndsWith("K"));
            Console.WriteLine(name.IndexOf("B") + " " + surname.Insert(0,"Berkay"));
            Console.WriteLine(name.Remove(3, 1) + " " + surname.Substring(8, 5));
            Console.WriteLine(name.Remove(3) + " " + surname.Substring(6, 4));
            Console.WriteLine(name.Replace("kay","kara") + " " + surname.Trim());
            Console.WriteLine(name.Length + " " + surname.Length);
        }
    }
}
