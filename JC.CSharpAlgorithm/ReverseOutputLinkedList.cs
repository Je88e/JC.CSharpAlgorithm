using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;//自定义单链表
using Stack;

namespace JC.CSharpAlgorithm
{
    //https://www.cnblogs.com/edisonchou/p/4740993.html
    //单链表反转输出
    public static class ReverseOutputLinkedList
    {
        public static string Reverse1(SingleLinkedList<int> singleLinkedList)
        {
           Stack.LinkedListStack<int> stack = new Stack.LinkedListStack<int>();
            for (int i = 0; i < singleLinkedList.Count; i++)
            {
                stack.Push(singleLinkedList[i]);
            }
            int[] ints = new int[singleLinkedList.Count];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = stack.Pop();
            }  
            return OutputString(ints);
        }

        public static string Reverse2(LinkedList<int> linkedList)
        {
            var ints = linkedList.Reverse().ToArray(); 
            return OutputString(ints);
        }

        public static SingleLinkedList<int> Reverse3(SingleLinkedList<int> singleLinkedList)
        {
            Stack.LinkedListStack<int> stack = new Stack.LinkedListStack<int>();
            for (int i = 0; i < singleLinkedList.Count; i++)
            {
                stack.Push(singleLinkedList[i]);
            }
            int[] ints = new int[singleLinkedList.Count];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = stack.Pop();
            }
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            return list;
        }

        private static string OutputString(int[] ints)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ints.Length; i++)
            {
                sb.Append(ints[i]);
            }
            return sb.ToString();
        }
    }
}
