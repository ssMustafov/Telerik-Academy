using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class GenericList<T> 
        where T : IComparable<T>
    {
        private T[] list;
        private int count = 0;
        private int capacity = 0;

        public GenericList(int capacity = 4)
        {
            this.capacity = capacity;
            list = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        private void GrowCapacity(T[] oldList)
        {
            this.capacity = this.capacity * 2;
            this.list = new T[capacity];

            for (int i = 0; i < this.count; i++)
            {
                this.list[i] = oldList[i];
            }
        }

        public void AddElement(T element)
        {
            if (this.capacity > this.count)
            {
                this.list[count] = element;
                count++;
            }
            else
            {
                this.GrowCapacity(this.list);
                this.AddElement(element);
            }
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentException("Index was out of range.");
            }

            return this.list[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentException("Index was out of range.");
            }

            if (index == this.count - 1)
            {
                this.list[this.count - 1] = default(T);
            }
            else
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    this.list[i] = this.list[i + 1];
                }

                this.list[this.count - 1] = default(T);
                this.count--;
            }
        }

        public void InsertElement(T element, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index was out of range.");
            }

            this.count++;

            if (index < this.capacity)
            {
                this.list[index] = element;
            }
            else if (index == this.capacity)
            {
                this.GrowCapacity(this.list);
                this.InsertElement(element, index);
            }
            else
            {
                for (int i = this.count - 1; i > index; i--)
                {
                    this.list[i] = this.list[i - 1];
                }

                this.list[index] = element;
            }
        }

        public void Clear()
        {
            this.count = 0;
            this.capacity = 4;
            this.list = new T[this.capacity];
        }

        public int FindElement(T element)
        {
            for (int index = 0; index < this.count; index++)
            {
                if (this.list[index].CompareTo(element) == 0)
                {
                    return index;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                sb.AppendLine(this.list[i].ToString());
            }

            return sb.ToString();
        }

        public T Min<K>()
        {
            T min = this.list[0];

            for (int i = 1; i < this.count; i++)
            {
                if (this.list[i].CompareTo(min) < 0)
                {
                    min = this.list[i];
                }
            }

            return min;
        }

        public T Max<K>()
        {
            T max = this.list[0];

            for (int i = 1; i < this.count; i++)
            {
                if (this.list[i].CompareTo(max) > 0)
                {
                    max = this.list[i];
                }
            }

            return max;
        }
    }
}
