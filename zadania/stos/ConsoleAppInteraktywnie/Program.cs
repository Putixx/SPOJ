using System;
using System.Collections.Generic;

namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        List<T> values;

        public Stos()
        {
            values = new List<T>();
        }

        public void Push(T value)
        {
            values.Add(value);
        }

        public T Peek
        {
            get
            {
                if (Count <= 0) throw new StosEmptyException();
                

                return values[LastIndex];
            }
        }

        public T Pop()
        {
            if (Count <= 0) throw new StosEmptyException();

            var lastItem = values[LastIndex];
            values.RemoveAt(LastIndex);
            return lastItem;
        }

        public int Count
        {
            get => values.Count;
        }

        int LastIndex
        {
            get => values.Count - 1;
        }

        public bool IsEmpty
        {
            get => Count == 0;
        }

        public void Clear()
        {
            values.Clear();
        }

        public T[] ToArray()
        {
            return values.ToArray();
        }
    }
}