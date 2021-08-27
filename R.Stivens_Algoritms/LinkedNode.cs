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
    }
}
