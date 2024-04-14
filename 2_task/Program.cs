using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //test1();
                //test2();
                //test3();
                //test4();
                //test5();
                //test6();
                test7();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static void test1()
        {
            Circle a = new Circle(2);
            Console.WriteLine(a.GetSquare());
            Triangle b = new Triangle(1, 3, 3);
            Console.WriteLine(b.GetSquare());
        }
        static void test2()
        {
            Shape a = new Circle(2);
            Console.WriteLine(a.GetSquare());
            Shape b = new Triangle(1, 3, 3);
            Console.WriteLine(b.GetSquare());
        }
        static void test3()
        {
            Circle a = new Circle(0);
            Console.WriteLine(a.GetSquare());
        }
        static void test4()
        {
            Shape b = new Triangle(1, 2, 3);
            Console.WriteLine(b.GetSquare());
        }
        static void test5()
        {
            Shape b = new Triangle(-2, 2, 2);
            Console.WriteLine(b.GetSquare());
        }
        static void test6()
        {
            Triangle b = new Triangle(3, 4, 5);
            Console.WriteLine(b.GetSquare());
            Console.WriteLine(b.IsRight());
        }
        static void test7()
        {
            Triangle b = new Triangle(3, 4, 6);
            Console.WriteLine(b.GetSquare());
            Console.WriteLine(b.IsRight());
        }
    }
}
