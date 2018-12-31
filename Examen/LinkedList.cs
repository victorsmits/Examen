using System;
namespace Examen
{
    public class LinkedList<T>
    {
        private ListItem first;
        private int size;

        public LinkedList()
        {
            first = null;
            size = 0;
        }

        private class ListItem
        {
            public T data;
            public ListItem next;

            public ListItem(T data, ListItem next)
            {
                this.data = data;
                this.next = next;
            }
        }
        public int Size { get { return size; } }

        public bool IsEmpty() { return Size == 0; }

        public override string ToString()
        {
            if (IsEmpty()) { return "[]"; }

            ListItem current = first;   // pointeur de l'élément courant
            string result = "[" + current.data;
            while (current.next != null)
            {
                current = current.next;
                result += ", " + current.data;
            }
            return result + "]";
        }

        public void addFirst(T data)
        {
            first = new ListItem(data, first);
            size++;
        }

        public void addLast(T data)
        {
            ListItem item = new ListItem(data, null);
            if (IsEmpty()) { first = item; }

            ListItem current = first;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = item;
            size++;
        }


    }
}
