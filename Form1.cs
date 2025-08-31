using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_IceTask3
{
    public partial class Form1 : Form
    {
        private FamilyTree root;

        public Form1()
        {
            InitializeComponent();

            // Ensures that the tree is generated when the form loads
            this.Load += (s, e) => btnGenerate_Click(null, null);
        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {

            // When the generate button is ran, we will assemble the tree from scratch.
            var queen = new RoyalMember("Queen Elizabeth II");


            root = new FamilyTree(queen);


            var charles = new FamilyTree(new RoyalMember("King Charles III"));
            var anne = new FamilyTree(new RoyalMember("Princess Anne"));
            var andrew = new FamilyTree(new RoyalMember("Prince Andrew"));
            var edward = new FamilyTree(new RoyalMember("Prince Edward"));


            root.AddChild(charles);
            root.AddChild(anne);
            root.AddChild(andrew);
            root.AddChild(edward);


            charles.AddChild(new FamilyTree(new RoyalMember("Prince William")));
            charles.AddChild(new FamilyTree(new RoyalMember("Prince Harry")));




            // Next we will check the text boxes to see if we need to
            // - add a new child to a parent

            string parentName = txtUnderParent.Text.Trim();
            string childName = txtAddChild.Text.Trim();
            if (!string.IsNullOrWhiteSpace(parentName) && !string.IsNullOrWhiteSpace(childName))
            {
                var (parentNode, _) = root.Bfs(parentName);
                if (parentNode != null)
                {
                    parentNode.AddChild(new FamilyTree(new RoyalMember(childName)));
                }
            }

            //If the search box is empty we will just display the tree.
            string searchName = txtSearchMember.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchName))
            {
                DisplayTree();
                bfsOutput.Text = "BFS Output: ";
                dfsOutput.Text = "DFS Output: ";
                return;
            }

            // However if the tree is full, DFS and BFS will be ran to find the search term.
            var bfsResult = root.Bfs(searchName);
            var dfsResult = root.Dfs(searchName);

            DisplayTree();

            if (bfsResult.node != null)
                bfsOutput.Text = $"Bfs: Found {bfsResult.node.Member.Name} in {bfsResult.steps} steps";
            else
                bfsOutput.Text = $"Bfs: {searchName} not found after {bfsResult.steps} steps";

            if (dfsResult.node != null)
                dfsOutput.Text = $"Dfs: Found {dfsResult.node.Member.Name} in {dfsResult.steps} steps";
            else
                dfsOutput.Text = $"Dfs: {searchName} not found after {dfsResult.steps} steps";
        }



        private void DisplayTree()
        {
            tvOutput.Nodes.Clear();
            if (root != null)
            {
                AddNode(root, null);
                tvOutput.ExpandAll();
            }
        
        
        }


        private void AddNode(FamilyTree treeNode, TreeNode parent)
        {
            TreeNode newNode = new TreeNode(treeNode.Member.ToString()) { Tag = treeNode };
            if (parent == null)
                tvOutput.Nodes.Add(newNode);
            else
                parent.Nodes.Add(newNode);

            foreach (var child in treeNode.Children)
                AddNode(child, newNode);
        }



        private void tvOutput_AfterSelect(object sender, TreeViewEventArgs e) { }
        private void txtSearchMember_TextChanged(object sender, EventArgs e) { }
        private void txtAddChild_TextChanged(object sender, EventArgs e) { }
        private void txtUnderParent_TextChanged(object sender, EventArgs e) { }
    }
}
