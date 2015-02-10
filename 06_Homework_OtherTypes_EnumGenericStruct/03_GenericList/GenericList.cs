using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList 
{
    // Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
    class GenericList<T> where T : IComparable<T>
    {
        // Keep the elements of the list in an array with a certain capacity, 
        // which is given as an optional parameter in the class constructor. 
        // Declare the default capacity of 16 as constant.
        private const int DefaultCapacity = 16;

        private T[] list;
        private int capacity;
        private int count;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.List = new T[this.Capacity];
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative!");
                }

                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Count cannot be negative!");
                }

                this.count = value;

                if (value >= this.Capacity)
                {
                    this.DoubleCount();
                }
            }
        }

        // Implement auto-grow functionality: when the internal array is full, 
        // create a new array of double size and move all elements to it.
        private void DoubleCount()
        {
            this.Capacity *= 2;
            T[] newBiggerList = new T[this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newBiggerList[i] = this.List[i];
            }

            this.List = newBiggerList;
        }

        public T[] List
        {
            get
            {
                return this.list;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null.");
                }

                this.list = value;
            }
        }

        // Implement methods for: accessing element by index
        public T this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                return this.List[index];
            }

            set
            {
                if (index >= this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                this.List[index] = value;
            }
        }

        // Implement methods for: adding an element 
        public void Add(T element)
        {
            this.List[this.Count] = element;
            this.Count++;
        }

        // Implement methods for: removing element by index
        public void Remove(int index)
        {
            T[] newArr = new T[this.Capacity];

            Array.Copy(this.List, newArr, index);
            Array.Copy(this.list, index + 1, newArr, index, this.List.Length - index - 1);

            this.List = newArr;
            this.Count--;
        }

        // Implement methods for: inserting element at given position
        public void Insert(T element, int position)
        {
            T[] newArr = new T[this.Capacity];

            Array.Copy(this.List, newArr, position);
            Array.Copy(new T[1] { element }, 0, newArr, position, 1);
            Array.Copy(this.List, position, newArr, position + 1, this.List.Length - position - 2);

            this.List = newArr;
            this.Count++;
        }

        // Implement methods for: oclearing the list
        public void Clear()
        {
            this.List = new T[DefaultCapacity];
        }

        // Implement methods for: finding element index by given value
        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.List[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        // checking if the list contains a value
        public bool Contains(T element)
        {
            return this.List.Contains(element);
        }


        // printing the entire list (override ToString())
        public override string ToString()
        {
            StringBuilder listSB = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                listSB.Append(this.List[i]);

                if (i != this.Count - 1)
                {
                    listSB.Append(", ");
                }
            }

            return listSB.ToString();
        }
    }
}
