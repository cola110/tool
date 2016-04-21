using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cola_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = EncryptDESClass.EncryptDES("test");
            Console.WriteLine("test");
            Console.WriteLine(result);
            Console.WriteLine("");

            var rest = EncryptDESClass.DecryptDES(result);
            Console.WriteLine(rest);
        }
    }
}