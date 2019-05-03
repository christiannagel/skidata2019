using System;

namespace InheritanceSample
{
    class A
    {
        public virtual void M() => Console.WriteLine("A");
    }

    class B : A
    {
        public override void M() => Console.WriteLine("B");
    }

    class C : B
    {
        new public virtual void M() => Console.WriteLine("C");
    }

    class D : C
    {
        public override void M() => Console.WriteLine("D");
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;
            a.M(); b.M(); c.M(); d.M();
        }
    }
}
