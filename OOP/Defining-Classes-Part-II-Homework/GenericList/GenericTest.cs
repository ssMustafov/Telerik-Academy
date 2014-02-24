using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    class GenericTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();

            list.AddElement(5);
            list.AddElement(2);
            list.AddElement(3);
            list.AddElement(4);
            list.AddElement(-5);
            list.RemoveAt(2);
            list.AddElement(10);
            list.AddElement(9);
            list.AddElement(11);
            list.InsertElement(100, 7);
            var finded = list.FindElement(100);
            var min = list.Min<int>();
            var max = list.Max<int>();
            list.Clear();
        }
    }
}
