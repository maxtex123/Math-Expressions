/*
 * InfixParser.cs
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
    public static class InfixParser
    {
        /// <summary>
        /// Builds the expression tree.
        /// </summary>
        /// <param name="s">String to parse through</param>
        /// <param name="variableEvaluator">Reference to the function that retrieves the variable value.</param>
        /// <returns>variable off the numeric stack</returns>
        public static INode ConstructTree(string s, Func<char, Func<int>> variableEvaluator)
        {
            Stack<INode> numericStack = new Stack<INode>();
            Stack<char> operatorStack = new Stack<char>();
            for (int i = 0; i < s.Length; i ++)
            {
                if ((i < s.Length - 1 && s[i] == '-') && (s[i + 1] >=  '0' && s[i+1] <= '9'))
                {
                    i = ConstructInt(s, i, out int val);
                    numericStack.Push(new LiteralNode(val));
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    i = ConstructInt(s, i, out int val);
                    numericStack.Push(new LiteralNode(val));
                }
                else if (s[i] >= 'A' && s[i] <= 'C')
                {
                    numericStack.Push(new VariableNode(s[i], variableEvaluator(s[i])));
                }
                else if (s[i] == '(')
                {
                    operatorStack.Push(s[i]);
                }
                else if (IsOperator(s[i]))
                {
                    while(operatorStack.Count > 0 && numericStack.Count > 1 && operatorStack.Peek() != '(' && GetPrecedence(operatorStack.Peek()) <= GetPrecedence(s[i]))
                    {
                        ApplyOperation(numericStack, operatorStack);
                    }
                    operatorStack.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    while (operatorStack.Peek() != '(')
                    {
                        ApplyOperation(numericStack, operatorStack);
                    }
                    operatorStack.Pop();
                }
            }
            while (operatorStack.Count > 0)
            {
                ApplyOperation(numericStack, operatorStack);
            }
            return numericStack.Pop();

        }
        /// <summary>
        /// Combines two sub-nodes of the tree to form a larger portion of the expression tree.
        /// </summary>
        /// <param name="numStack">Stack of numbers and variables.</param>
        /// <param name="opStack">Stack of operators.</param>
        public static void ApplyOperation(Stack<INode> numStack, Stack<char> opStack)
        {
            char op = opStack.Pop();
            INode right = numStack.Pop();
            INode left = numStack.Pop();
            INode combined = new OperatorNode(op, left, right);
            numStack.Push(combined);
        }
        /// <summary>
        /// Finds the order in which operators should evaluate.
        /// </summary>
        /// <param name="op">Operator going to be checked.</param>
        /// <returns>Integer of what order.</returns>
        public static int GetPrecedence(char op)
        {
            if (op == '(' || op == ')')
            {
                return 0;
            }
            else if (op == '*' || op == '/')
            {
                return 1;
            }
            else if (op == '+' || op == '-')
            {
                return 2;
            }
            return -1;
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
        /// <summary>
        /// Constructs double digit numbers and negative numbers.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="start_ind">Index number starts at.</param>
        /// <param name="value">Value after whole number is found.</param>
        /// <returns>Index of where the number ends.</returns>
        public static int ConstructInt(string s, int start_ind, out int value)
        {
            int end_ind = start_ind;
            bool isNeg = false;
            int totalVal = 0;
            if (s[end_ind] == '-')
            {
                isNeg = true;
                end_ind++;
            }
            while (end_ind < s.Length && s[end_ind] >= '0' && s[end_ind] <= '9')
            {
                totalVal *= 10;
                totalVal += s[end_ind] - '0';
                end_ind++;
            }
            if (isNeg)
            {
                totalVal *= -1;
            }
            value = totalVal;
            return end_ind - 1;
        }
    }
}
