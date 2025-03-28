using System;
using Simple;
using Language;
using Language.Namespaces.NamespaceC;
using Language.Comparisons;
using Language.Events;

namespace Main
{
    class ApplicationMain
    {
        static void Main(string[] args)
        {
                //Terminal.Run(); 

                // The Namespace above is omitted
                Language.Namespaces.NamespaceA.NamespaceB.NestedNamespaceClass.ExampleA();
                NestedNamespaceClass.ExampleB();
                ComparisonExample.Run();
                EventExample.Run();
        }
    }
}