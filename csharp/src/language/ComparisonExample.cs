using System;
using Language.Properties;
using Language.Interfaces;

namespace Language.Comparisons
{
    class ComparisonExample: IExample
    {
        public static void Run()
        {
            int A = 1;
            int B = 1;
            string C = "C";
            string D = "C";

            Console.WriteLine($"Comparison by Value Equality: A == B -> {A == B}");

            try 
            {
                /*
                    Types must be the same!

                    error CS0019: Operator '==' cannot be applied to operands of type 'int' and 'string'.
                    
                    Checked Excpetion that can't be wrapped by a Try-Catch clause.
                */

                //Console.WriteLine("Comparison by Value Equality: A == C");
                //Console.WriteLine(A == C);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Types must be the same!");
            }

            Console.WriteLine($"Comparison by Value Equality: A == A -> {A == A}");
            Console.WriteLine($"Comparison by Value Equality: C == D -> {C == D}");
    
            PropertyExample propertyExampleA = new PropertyExample();
            propertyExampleA.num = 1;
            propertyExampleA.msg = "propertyExampleA";
            
            PropertyExample propertyExampleB = new PropertyExample();
            propertyExampleA.num = 10;
            propertyExampleA.msg = "propertyExampleB";

            Console.WriteLine($"Comparison by Value Equality: propertyExampleA.num == propertyExampleA.num -> {propertyExampleA.num == propertyExampleA.num}");
            Console.WriteLine($"Comparison by Value Equality: propertyExampleA.num == propertyExampleB.num -> {propertyExampleA.num == propertyExampleB.num}");
            Console.WriteLine($"Comparison by Referential Equality: Object.ReferenceEquals(propertyExampleA, propertyExampleA)) -> {Object.ReferenceEquals(propertyExampleA, propertyExampleA)}");
            Console.WriteLine($"Comparison by Referential Equality: Object.ReferenceEquals(propertyExampleA, propertyExampleB)) -> {Object.ReferenceEquals(propertyExampleA, propertyExampleB)}");
        }
    }
}