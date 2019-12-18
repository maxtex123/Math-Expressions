/*
 * VairiableNode.cs
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
    public class VariableNode : INode
    {
        /// <summary>
        /// Holds the reference to the function that retrieves the variable value and is initially null.
        /// </summary>
        private Func<int> _variableEvaluator = null;
        /// <summary>
        /// Gets identifier.
        /// </summary>
        public char Identifier { get; }
        /// <summary>
        /// Returns Identifier property.
        /// </summary>
        public object Root => Identifier;
        /// <summary>
        /// Creates and returns a new ITree
        /// </summary>
        public ITree[] Children => new ITree[] { };
        /// <summary>
        /// Returns false by default.
        /// </summary>
        public bool IsEmpty => false;

        //Methods
        /// <summary>
        /// A constructor that initializes the class properties and fields with the receiving parameters
        /// </summary>
        /// <param name="ident">Indetifier.</param>
        /// <param name="f">Variable evaulator.</param>
        public VariableNode(char ident, Func<int> f)
        {
            _variableEvaluator = f;
            Identifier = ident;
        }
        /// <summary>
        /// Finds the value associated with this node using the function referenced by the _variableEvalutor field if it is not null; otherwise, it should return zero.
        /// </summary>
        /// <returns>Value associated with node.</returns>
        public int Value()
        {
            if (_variableEvaluator != null)
            {
                return _variableEvaluator();
            }
            return 0;
            
        }
    }
}
