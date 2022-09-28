using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue;

namespace JC.CSharpAlgorithm
{
    //https://www.cnblogs.com/edisonchou/p/4743930.html
    public interface ITwoStackQueue<T>
    {
        void AppendTail(T item);
        T DeleteHead();

    }
    public class TwoStackQueue1<T> : ITwoStackQueue<T>
    {
        private Stack<T> _headStack = new ();
        private Stack<T> _tailStack = new();

        public void AppendTail(T item)//queue push
        {
            _headStack.Push(item);
        }

        public T DeleteHead()//queue pop
        {
            while (_headStack.Count > 0)
            { 
                _tailStack.Push(_headStack.Pop());
            }
            if (_tailStack.Count == 0)
            {
                throw new NullReferenceException("Queue Is Empty");
            }
            return _tailStack.Pop();
        }
    }

    public class TwoStackQueue2<T> : ITwoStackQueue<T>
    {
        private Stack<T> _headStack = new();
        private Stack<T> _tailStack = new();

        public void AppendTail(T item)//queue push
        {
            _headStack.Push(item);
        }

        public T DeleteHead()//queue pop
        {
            if (_tailStack.Count <= 0)
            {
                while (_headStack.Count > 0)
                {
                    T item = _headStack.Pop();
                    _tailStack.Push(item);
                }
            }

            if (_tailStack.Count == 0)
            {
                throw new Exception("The queue is empty!");
            } 

            return _tailStack.Pop();
        }
    }
}
