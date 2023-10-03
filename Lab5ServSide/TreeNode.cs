
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class TreeNode<T>
    {

        /// <summary>
        /// Generic Data is used to represent whatever datatype input is
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// The Parent Treenode that has been obersved/Assigned to this new node
        /// </summary>
        public TreeNode<T> Parent { get; set; }

        /// <summary>
        /// The List used to link together the tree based on the received input
        /// </summary>
        public List<TreeNode<T>> Children { get; set; }

        /// <summary>
        /// GetHeight is used to generate which level or height the
        /// new node will be placed in. The height is calculated 
        /// by comparing it to its parents position
        /// </summary>
        /// <returns>The int number indicating the nodes level or height</returns>

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;

            // Loops through until the height of the new node and parent are equal
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
