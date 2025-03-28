using System;

namespace Language.Namespaces.NamespaceA
{
    namespace NamespaceB
    {
        class NestedNamespaceClass
        {
            public static void ExampleA()
            {
                Console.WriteLine("NamespaceA > NamespaceB > NestedNamespaceClass > exampleA()");
            }
        }
    }
}

namespace Language.Namespaces.NamespaceC
{
    class NestedNamespaceClass
    {
        public static void ExampleB()
        {
            Console.WriteLine("NamespaceC > NestedNamespaceClass > exampleB()");
        }
    }
}