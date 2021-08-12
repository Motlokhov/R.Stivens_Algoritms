using System;

namespace R.Stivens_Algoritms
{
    //Реализация с ограничителями по краям(в данной реализации невозможно грамотно сделать Count)
    public class LinkedList
    {
        // Note: в реализации от Microsoft linked list имеет закольцованую структуру
        private LinkedListNode head;
        private LinkedListNode tail;

        public LinkedList()
        {
            head = new ();
            tail = new ();

            tail.Preveous = head;
            head.Next = tail;
        }

        public class LinkedListNode
        {
            public LinkedListNode(int value = default)
            {
                Value = value;
            }

            public int Value { get; set; }
            public LinkedListNode Next { get; internal set; }
            public LinkedListNode Preveous { get; internal set; }
        }

        public static void ActionIterate (Action<int> action, LinkedListNode startNode)
        {
            LinkedListNode current = startNode;
            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public LinkedListNode Find(int target)
        {
            LinkedListNode current = head;
            while(current != null)
            {
                if(current.Value == target)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public LinkedListNode FindFrom(LinkedListNode node, int target)
        {
            LinkedListNode current = node.Next;
            while(current != null)
            {
                if(current.Value == target)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public LinkedListNode FindNodeBefore(int value)
        {
            LinkedListNode current = head;
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
            LinkedListNode @new = new()
            {
                Value = value,
                Next = head
            };

            head.Preveous = @new;
            head = @new;
        }

        public void AddAtEnd(int value)
        {
            LinkedListNode newNode = new(value);
            newNode.Preveous = tail;
            tail.Next= newNode;
            tail = newNode;
        }

        public void AddAfter(int value, int newValue)
        {
            LinkedListNode node = Find(value);
            if(node == null)
                throw new Exception("Node not found");

            AddAfter(node, newValue);
        }

        public void AddAfter(LinkedListNode arterMe, int newValue)
        {
            LinkedListNode newNode = new(newValue);
            newNode.Next = arterMe.Next;
            newNode.Preveous = arterMe;

            arterMe.Next.Preveous = newNode;
            arterMe.Next = newNode;
        }

        public void AddBefore(int value, int newValue)
        {
            LinkedListNode node = Find(value);
            if(node == null)
                throw new Exception("Node not found");

            AddBefore(node, newValue);
        }

        private void AddBefore(LinkedListNode beforeMe, int newValue)
        {
            LinkedListNode newNode = new(newValue);
            newNode.Next = beforeMe;
            newNode.Preveous = beforeMe.Preveous;

            beforeMe.Preveous.Next = newNode;
            beforeMe.Preveous = newNode;
        }
    }
}
