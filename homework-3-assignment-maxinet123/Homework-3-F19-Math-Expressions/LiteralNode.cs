/*
 * LiteralNode.cs
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
    public class LiteralNode :INode
    {
        /// <summary>
        /// Gets literal value.
        /// </summary>
        public int LiteralValue { get; }
        /// <summary>
        /// Creates and returns a new ITree
        /// </summary>
        public ITree[] Children  => new ITree[] { };
        
        /// <summary>
        /// Returns the LiteralValue property.
        /// </summary>
        public object Root  => LiteralValue; 
        /// <summary>
        /// Returns false by default.
        /// </summary>
        public bool IsEmpty => false;

        /// <summary>
        /// The constructor that intializes the class property with the receiving parameters.
        /// </summary>
        /// <param name="val">Value being checked.</param>
        public LiteralNode(int val)
        {
            LiteralValue = val;
        }
        /// <summary>
        /// Finds the value associated with this node.
        /// </summary>
        /// <returns>Value associated with node.</returns>
        public int Value()
        {
            return LiteralValue;
        }
    }
}
