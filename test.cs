using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    public class program
    {
        static void Main()
        {
            Console.WriteLine("Beginning add test");
            number a = new number(1);
            number b = new number(5);
            Console.WriteLine(a.Execute());
            Console.WriteLine("+" + b.Execute());

            number j = new number(3);
            number k = new number(456);

            SubtractOperator subtract = new SubtractOperator(a, b);
            //Console.WriteLine(add.Execute());

            AddOperator subTwo = new AddOperator(subtract,b);
            Console.WriteLine(subtract.Execute());

            Console.WriteLine("Press any key to start for loop testing... ");
            Console.ReadKey();

            number index = new number(0);
            number ceiling = new number(10);
            number manipulate = new number(0);
            ForLoop forloop = new ForLoop(index.Execute(), ceiling.Execute());
            forloop.addCommand(new AssignmentOperator(manipulate,new AddOperator(manipulate, new number(1))));
            
            
            Console.WriteLine("Output of ForLoop = " + manipulate.Execute());

            Console.ReadKey();

        }
    }
}
