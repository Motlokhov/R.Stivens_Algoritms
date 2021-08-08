using System;

namespace R.Stivens_Algoritms
{
    public class OneWayLinkedList
    {
        // Note: в реализации от Microsoft linked list имеет закольцованую структуру
        private OneWayLinkedListNode first;

        public OneWayLinkedList()
        {
            first = new OneWayLinkedListNode();
        }

        public class OneWayLinkedListNode
        {
            public int Value { get; set; }
            public OneWayLinkedListNode? Next { get; internal set; }
        }

        public void ActionIterate (Action<int> action)
        {
            OneWayLinkedListNode current = first;
            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public OneWayLinkedListNode Find(int target)
        {
            OneWayLinkedListNode current = first;
            while(current != null)
            {
                if(current.Value == target)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public OneWayLinkedListNode FindNodeBefore(int value)
        {
            OneWayLinkedListNode current = first;
            while(current.Next != null)
            {
                if(current.Next.Value == value)
                    return current;
                current = current.Next;
            }

            return null;
        }

        public void AddAtTop(int value)
        {
            OneWayLinkedListNode @new = new()
            {
                Value = value,
                Next = first
            };
            
            first = @new;
        }

        public void AddAtEnd(int value)
        {
            OneWayLinkedListNode current = first;
            while(current.Next != null)
                current = current.Next;

            current.Next = new OneWayLinkedListNode { Value = value };
        }

        public void AddAfter(int value, int newValue)
        {
            OneWayLinkedListNode node = Find(value);
            if(node == null)
                throw new Exception("Node not found");

            OneWayLinkedListNode nodeAfter = node.Next;
            node.Next = new OneWayLinkedListNode { Value = newValue };
            node.Next.Next = nodeAfter;
        }
    }

    
}
