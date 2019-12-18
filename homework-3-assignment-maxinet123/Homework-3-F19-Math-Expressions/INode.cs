/*
 * INode.cs
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
    public interface INode : ITree
    {
        /// <summary>
        /// Value associated with a given node in the expression tree.
        /// </summary>
        /// <returns>Value associated with a given node.</returns>
        int Value();

    }
}
