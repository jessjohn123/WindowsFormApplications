using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
   
    class TreeNode
    {
        public int Depth = 0;
        public string Text = "";
        // List of tree node objects that are node's children in the tree
        public List<TreeNode> childrens = new List<TreeNode>();

        public TreeNode(string text)
        {
            Text = text;
        }

        // Add and create children - Adds a new child to the node's 
        // children list and returns the new child.
        public TreeNode AddChild(string text)
        {
            TreeNode child = new TreeNode(text);
            child.Depth += 1;
            childrens.Add(child);
            return child;
        }

        // Return tree nodes in preorder traversalss
        // Each node is displayed before its children
        public List<TreeNode> Preorder()
        {
            // Make the result list
            List<TreeNode> nodes = new List<TreeNode>();

            // Traverse this node's subtree
            TraversePreorder(nodes);

            //Return the result
            return nodes;
        }

        // Adds the curr node to the list of nodes, and
        // recursively call each of its child nodes traversal methods 
        // so that they can add themselves to the list.
        private void TraversePreorder(List<TreeNode>nodes)
        {
            // Traverse this node
            nodes.Add(this);

            // Traverse the childrens
            foreach (TreeNode child in childrens)
                child.TraversePreorder(nodes);
        }

        // Return an enumerator
        public IEnumerable<TreeNode> GetTraversal()
        {
            //Get the preorder traversal - Get the list containing tree nodes
            List<TreeNode> traversal = Preorder();

            // Yield the nodes in the traversal - Loops over nodes in the list calling
            // yield return to add each to the enumeration and it finishes enumeration
            // by calling yield break.
            foreach (TreeNode node in traversal)
                yield return node;
            yield break;
        }

    }
}
