
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    /// <summary>
    /// BinaryTreeNode<T> class is the object/Constructor class for 
    /// generic BinaryTreeNodes. The class is instantized like an normal 
    /// node using the input list, with the added benefit of a direct
    /// left and right node.
    /// </summary>
    /// <typeparam name="T">A Generic Data Type to allow for different types of BinaryTreeNodes</typeparam>
    internal class BinaryTreeNode<T> : TreeNode<T>
    {

        /// <summary>
        /// Constrcutor Class creating a node based on created list.
        /// </summary>
        public BinaryTreeNode() => Children =
         new List<TreeNode<T>>() { null, null };

        /// <summary>
        /// Left BinaryTreeNode assigns the Left node of the originally
        /// called node.
        /// </summary>
        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        /// <summary>
        /// Right BinaryTreeNode assign the Right node of the originally 
        /// called node
        /// </summary>
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
    }
}
