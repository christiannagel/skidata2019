using System;
using System.Collections;

namespace RefAndValueTypes
{
    struct X  // pass by value, on stack (default) or heap (boxing)
    {
        public int A;
    }

    ref struct XRef // pass by value, only on stack
    {
        public int A;
        public override string ToString() => "XRef";
    }

    class Program
    {
        static void Main(string[] args)
        {
            XRef xref1 = new XRef();
            string s= xref1.ToString();

            X x = new X();
            x.A = 1;
            ChangeX(ref x);
            Console.WriteLine(x.A);  // 1 or 2 or 3

            int val1 = 42;
            object o1 = val1;  // boxing
            val1 = (int)o1;  // unboxing

            ArrayList list1 = new ArrayList();
            list1.Add(4);  // boxing
            list1.Add("4");
            list1.Add(9);

            foreach (int item in list1)  // unboxing
            {
                Console.WriteLine(item);  
            }

            IEnumerator enumerator = list1.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int item = (int)enumerator.Current;

            }

        }

        static void ChangeX(ref X x1)
        {
            x1.A = 2;

            //x1 = new X();
            //x1.A = 3;
        }
    }
}
