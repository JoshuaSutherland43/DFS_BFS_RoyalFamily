using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_IceTask3
{
    public class FamilyTree
    {

        public RoyalMember Member { get; set; }
        public List<FamilyTree> Children { get; set; }



        public FamilyTree(RoyalMember member)
        {
            Member = member;
            Children = new List<FamilyTree>();
        }



        public void AddChild(FamilyTree child)
        {
            Children.Add(child);
        }




        public (FamilyTree node, int steps) Bfs(string name)
        {
            Queue<FamilyTree> queue = new Queue<FamilyTree>();
            queue.Enqueue(this);
            int steps = 0;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                steps++;

                if (current.Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return (current, steps);

                foreach (var child in current.Children)
                    queue.Enqueue(child);
            }
            return (null, steps);
        }



        public (FamilyTree node, int steps) Dfs(string name)
        {
            int steps = 0;
            return DfsRec(this, name, ref steps);
        }



        // Making use of recursion to implement DFS.
        // (Kartik, 2025)
        private (FamilyTree, int) DfsRec(FamilyTree node, string name, ref int steps)
        {
            steps++;
            if (node.Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return (node, steps);

            foreach (var child in node.Children)
            {
                var found = DfsRec(child, name, ref steps);
                if (found.Item1 != null)
                    return found;
            }
            return (null, steps);
        }
    }
}

// Reference:

//Kartik (2025)
//Depth first search or DFS for a graph, GeeksforGeeks.
//Available at: https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/
//(Accessed: 31 August 2025). 