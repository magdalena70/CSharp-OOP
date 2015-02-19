using System;
using System.Text;

namespace _17_Clone_Example
{
    public class LinkedList<T> : ICloneable
    {
        private T tValue;
        private LinkedList<T> nextNode;

        public LinkedList(T tValue, LinkedList<T> nextNode = null)
        {
            this.TValue = tValue;
            this.NextNode = nextNode;
        }

        public T TValue
        {
            get{return this.tValue;}
            set{this.tValue = value;}
        }

        public LinkedList<T> NextNode
        {
            get { return this.nextNode; }
            set { this.nextNode = value; }
        }

        public LinkedList<T> Clone() // deep clonning
        {
            // copy the first element
            LinkedList<T> original = this;
            T valueOriginal = original.TValue;
            LinkedList<T> result = new LinkedList<T>(TValue); // new object (new instance)
            LinkedList<T> copy = result;
            original = original.NextNode;

            // copy the rest of the elements
            while (original != null)
            {
                valueOriginal = original.TValue;
                copy.NextNode = new LinkedList<T>(valueOriginal);
                original = original.NextNode;
                copy = copy.NextNode;
            }

            return result;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public LinkedList<T> ShallowCopy() // shallow clonning
        {
            return this; // the same object
        }

        public LinkedList<T> MemberwiseCopy()
        {
            return (LinkedList<T>)this.MemberwiseClone(); // shallow copy for each memeber
        }

        public override string ToString()
        {
            LinkedList<T> currentNode = this;
            StringBuilder sb = new StringBuilder("( ");
            while (currentNode != null)
            {
                sb.Append(currentNode.TValue);
                currentNode = currentNode.NextNode;
                    if (currentNode != null)
                    {
                    sb.Append(", ");
                    }
            }
            sb.Append(" )");
            return sb.ToString();
        }
    }
}
