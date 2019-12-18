/*
 * OperatorNode.cs
 * By: Maxine Teixeira
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;


namespace KSU.CIS300.Math.Expressions
{
    public class OperatorNode : INode
    {
        /// <summary>
        /// Gets operator.
        /// </summary>
        public char Operator { get; }
        /// <summary>
        /// Gets the left child.
        /// </summary>
        public INode LeftChild { get; }
        /// <summary>
        /// Gets the right child.
        /// </summary>
        public INode RightChild { get; }
        /// <summary>
        /// Returns the Operator property.
        /// </summary>
        public object Root => Operator; 
        /// <summary>
        /// Creats and returns a new ITree holding the left child and right child.
        /// </summary>
        public ITree[] Children => new ITree[] {LeftChild, RightChild }; 
        /// <summary>
        /// Return false by default.
        /// </summary>
        public bool IsEmpty => false; 

        /// <summary>
        /// A constructor that initializes that class properties and fields with the receiving parameters.
        /// </summary>
        /// <param name="op">Operator in the node.</param>
        /// <param name="left">Left child.</param>
        /// <param name="right">Right child.</param>
        public OperatorNode(char op, INode left, INode right)
        {
            Operator = op;
            LeftChild = left;
            RightChild = right;
        }
        /// <summary>
        /// Recursively calls itself to calculate the value of its children.
        /// </summary>
        /// <returns>Node's value.</returns>
        public int Value()
        {
            if (Operator == '/')
            {
                return LeftChild.Value() / RightChild.Value();
            }
            else if (Operator == '*')
            {
                return LeftChild.Value() * RightChild.Value();
            }
            else if (Operator == '+')
            {
                return LeftChild.Value() + RightChild.Value();
            }
            else
            {
                return LeftChild.Value() - RightChild.Value();
            }
        }
    }
}
