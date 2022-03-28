using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Program");
            MyBinaryNode<int> bst = new MyBinaryNode<int>(3);
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }
    }
}
