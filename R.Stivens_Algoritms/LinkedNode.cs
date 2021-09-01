using System.Collections;

namespace R.Stivens_Algoritms
{
    public class LinkedNode
    {
        
        public LinkedNode Next { get; set; }

        public static bool HasLoopUsingHashTable(LinkedNode start)
        {
            Hashtable visited = new();

            LinkedNode node = start;
            while(node is not null)
            {
                if(visited.Contains(node))
                    return true;
                visited.Add(node, node);
                node = node.Next;
            }

            return false;
        }

        public static bool HasLoopUsingTracing(LinkedNode sentinel)
        {
            LinkedNode cell = sentinel;
            while(cell.Next != null && cell.Next != sentinel)
            {
                LinkedNode tracer = sentinel;
                while(tracer != cell)
                {
                    if(tracer.Next == cell.Next)
                        return true;
                    tracer = tracer.Next;
                }
                cell = cell.Next;
            }
            return cell.Next == sentinel;
        }
    }
}
