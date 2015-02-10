using System;

namespace _10_Generic_Example
{
    public class GenericList<T> where T : IComparable<T>
    {
        const int DefaultCapacity = 15;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capasity of {0} was exceeded.", elements.Length));
                
            }

            this.elements[count] = element;
            count++;
        }

        // indexator
        public T this[int index]
        {
            get
            {
                // if elements[index] is empty -> throw Exeption
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }

                T result = elements[index];
                return result;
            }
            set
            {
                this.elements[index] = value;
            }
        }
    }
}
