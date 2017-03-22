using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Func
{
    class Program
    {
        static void Main(string[] args)
        {
        // the func<input variable type, output variable type> is a c# feature.
        // using this method, you dont need to Create delegate seperatly first, you can declare and define the function all in one line.
        //
        //

            Func<int, int> A = x => x * x;
            Console.WriteLine(A(3));
            Console.Read();
        }
    }
}
