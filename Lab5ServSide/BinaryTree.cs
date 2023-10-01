///////////////////////////////////////////////////////////////////////////////
//
// Author: Gavin Frisby, frisbyg@etsu.edu
// Jacob Gillenwater, Gillenwater@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 5 - Binary Tree Quiz
// Description: The BinaryTree file is constructor/Object file 
// That serves as the linking object between lists/nodes. 
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{

    /// <summary>
    /// The BinaryTree<T> Class serves as the generic constructor for
    /// different types of binary trees. 
    /// </summary>
    /// <typeparam name="T">Generic Type to allow for varying tree creation</typeparam>
    internal class BinaryTree<T>
    {
        /// <summary>
        /// Assigns the Root/Top node of the binary tree being created.
        /// </summary>
        public BinaryTreeNode<T> Root { get; set; }

        /// <summary>
        /// Count method refers the the current number of nodes within the binary tree
        /// </summary>
        public int Count { get; set; }
    }
}
