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

        
        public FamilyTree Bfs(string name)
        {
            Queue<FamilyTree> queue = new Queue<FamilyTree>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return current;

                foreach (var child in current.Children)
                    queue.Enqueue(child);
            }
            return null;
        }

        
        public FamilyTree Dfs(string name)
        {
            if (Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return this;

            foreach (var child in Children)
            {
                var found = child.Dfs(name);
                if (found != null)
                    return found;
            }
            return null;
        }
    }
}