using System;

namespace R.Stivens_Algoritms
{
    //Реализация с через кольцевую структуру.
    public class LinkedList
    {
        private LinkedListNode head;

        public class LinkedListNode
        {
            internal int _value;
            internal LinkedListNode _next;
            internal LinkedListNode _previous;
            internal LinkedList _list;

            public LinkedListNode(int value)
            {
                _value = value;
            }

            public int Value { get => _value;}
            public LinkedListNode Next => _next == _list.head ? null : _next;
            public LinkedListNode Previous => _list.head == this ? null : _previous;
            internal LinkedList List => _list;
        }

        public LinkedListNode Find(int target)
        {
            LinkedListNode current = head;

            do
            {
                if(current.Value == target)
                    return current;
                current = current._next;
            } while(current != head);

            return null;
        }

        public LinkedListNode FindFrom(LinkedListNode node, int target)
        {
            LinkedListNode current = node;

            do
            {
                if(current.Value == target)
                    return current;
                current = current._next;
            } while(current != head);

            return null;
        }

        public LinkedListNode FindBefore(int value)
        {
            LinkedListNode current = head;

            do
            {
                if(current._next.Value == value)
                    return current;
                current = current._next;
            } while(current._next != head);

            return null;
        }

        public void AddFirst(int value)
        {
            LinkedListNode newNode = new(value);
            if(head == null)
                InsertNodeToEmptyList(newNode);
            else
            {
                InsertNodeBefore(head, newNode);
                head = newNode;
            }
            newNode._list = this;
        }

        public void AddLast(int value)
        {
            LinkedListNode newNode = new(value);
            if(head == null)
                InsertNodeToEmptyList(newNode);
            else
                InsertNodeBefore(head, newNode);
            newNode._list = this;
        }

        public void AddAfter(int value, int newValue)
        {
            LinkedListNode node = Find(value);
            if(node == null)
                throw new Exception("Node not found");

            LinkedListNode newNode = new(newValue);
            AddAfter(node, newNode);
        }

        public void AddAfter(LinkedListNode node, LinkedListNode newNode)
        {
            InsertNodeBefore(node._next, newNode);
            newNode._list = this;
        }

        public void AddBefore(int value, int newValue)
        {
            LinkedListNode node = Find(value);
            if(node == null)
                throw new Exception("Node not found");

            LinkedListNode newNode = new(newValue);
            AddBefore(node, newNode);
        }

        public void AddBefore(LinkedListNode node, LinkedListNode newNode)
        {
            InsertNodeBefore(node,newNode);
            if(node == head)
                head = newNode;
            newNode._list = this;
        }

        private void InsertNodeToEmptyList(LinkedListNode node)
        {
            node._previous = node;
            node._next = node;
            head = node;
        }

        private void InsertNodeBefore(LinkedListNode node, LinkedListNode newNode)
        {
            newNode._next = node;
            newNode._previous = node._previous;

            node._previous._next = newNode;
            node._previous = newNode;
        }
    }
}
