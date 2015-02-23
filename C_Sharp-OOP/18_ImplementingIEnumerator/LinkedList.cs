namespace _18_ImplementingIEnumerator
{

    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        public T Value { get; set; }
        public LinkedList<T> NextNode { get; private set; }

        public LinkedList(T value, LinkedList<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); // Call the generic version of the method
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedList<T> currentNode = this;
            while (currentNode != null)
            {
                yield return currentNode.Value; // remember current value
                currentNode = currentNode.NextNode;
            }
        }
    }
}
