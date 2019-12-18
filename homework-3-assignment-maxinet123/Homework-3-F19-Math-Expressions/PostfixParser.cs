/*
 * PostfixParser.cs
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
    public static class PostfixParser
    {
        /// <summary>
        /// Parses through the string using a stack to store the values seen so far. Combines the values whenever an operator is encounter.
        /// </summary>
        /// <param name="s">String to parse through</param>
        /// <param name="variableEvaluator">Reference to the function that retrieves the variable value.</param>
        /// <returns>Node on top of stack.</returns>
        public static INode ConstructTree(string s, Func<char, Func<int>> variableEvaluator)
        {
            Stack<INode> nodeStack = new Stack<INode>();
            foreach (string piece in s.Split(' '))
            {
                if (int.TryParse(piece, out int temp))
                {
                    INode val = new LiteralNode(temp);
                    nodeStack.Push(val);
                }
                else
                {
                    if (piece == "A" || piece == "B" || piece == "C")
                    {
                        INode n = new VariableNode(piece[0], variableEvaluator(char.Parse(piece)));
                        nodeStack.Push(n);
                    }
                    else if (IsOperator(char.Parse(piece)))
                    {
                        INode right = nodeStack.Pop();
                        INode left = nodeStack.Pop();
                        INode combined = new OperatorNode(piece[0], left, right);
                        nodeStack.Push(combined);
                    }
                }
            }
            return nodeStack.Pop();
        }

        /// <summary>
        /// Determines if a character is a binary operator.
        /// </summary>
        /// <param name="op">Operator going to be checked.</param>
        /// <returns>true if it is otherwise false.</returns>
        public static bool IsOperator(char op)
        {
            if (op == '*' || op == '/' || op == '+' || op == '-')
            {
                return true;
            }
            return false;
        }
    }
}
