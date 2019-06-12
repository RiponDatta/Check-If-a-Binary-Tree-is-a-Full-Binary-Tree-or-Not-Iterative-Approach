using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_is_a_Full_BinaryTree_or_Not_Iterative
{
    public class BinaryTree
    {
        public Node Root;

        public bool IsFullBinaryTree()
        {
            if(Root == null)
            {
                return true;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                if(node.Left == null && node.Right == null)
                {
                    continue;
                }
                if(node.Left == null || node.Right == null)
                {
                    return false;
                }

                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }
            return true;
        }       
    }
}
