using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class MyBinaryNode<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public MyBinaryNode<T> LeftTree { get; set; }
        public MyBinaryNode<T> RightTree { get; set; }

        public MyBinaryNode(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T CurrentNodeValue = this.NodeData;
            if ((CurrentNodeValue.CompareTo(item) > 0))
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }

            }

        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
    }
}

