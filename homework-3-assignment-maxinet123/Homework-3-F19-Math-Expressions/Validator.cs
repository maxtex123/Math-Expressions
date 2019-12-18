/*
 * Validator.cs
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
    public static class Validator
    {
        /// <summary>
        /// Validates that the expression is not empty, only includes acceptable characters, has matching parenthesis, 
        /// all operators have a number or variable after them, and the expression starts with a number or variable.
        /// </summary>
        /// <param name="input">Math expression.</param>
        /// <returns>True if all variables are valid.</returns>
        public static bool InfixValidation(string input)
        {
            Stack<char> parenthesisStack = new Stack<char>();
            input = input.Replace(" ", String.Empty);
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') //check if first char is (
                {
                    parenthesisStack.Push(input[i]);
                }
                else if (input[i] == ')') //check if first char is )
                {
                    if (i == 0)
                    {
                        return false;
                    }
                    else if (input[i - 1] == '+' || input[i - 1] == '-' || input[i - 1] == '*' || input[i - 1] == '/' || input[i - 1] == '(') // check if next to operator or (
                    {
                        return false;
                    }
                    else if (parenthesisStack.Count == 0) //check if has a match
                    {
                        return false;
                    }
                    else
                    {
                        parenthesisStack.Pop();
                    }
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    if (i == 0 || i == input.Length - 1)
                    {
                        return false;
                    }
                    else if ((input[i + 1] < '0' && input[i + 1] > '9') && input[i + 1] != 'A' && input[i + 1] != 'B' && input[i + 1] != 'C' && input[i + 1] != ')')
                    {
                        if (input[i + 1] != '-' || (input[i + 2] == '-'))
                        {
                            return false;
                        }
                    }
                }
                else if ((input[i] < '0' || input[i] > '9') && input[i] != 'A' && input[i] != 'B' && input[i] != 'C')
                {
                    return false;
                }
            }
            if (parenthesisStack.Count != 0)
            {
                return false;
            }
            if ((input[input.Length - 1] < '0' || input[input.Length - 1] > '9') && input[input.Length - 1] != 'A' && input[input.Length - 1] != 'B' && input[input.Length - 1] != 'C' && input[input.Length - 1] != ')')
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Validates that the expression has a format of postfix math expression. Input string has to not be empty, only include acceptable characters,
        /// have tokens separated by a space (except when entering a negative number), and two operands preceding an operator.
        /// </summary>
        /// <param name="input">Math expression.</param>
        /// <returns>True if all variables are valid.</returns>
        public static bool PostfixValidation(string input)
        {
            int temp;
            input = input.Trim();
            string[] s = input.Split(' ');
            if (input.Length == 0)
            {
                return false;
            }
            int count = 0;
            if (!int.TryParse(s[0], out temp) && s[0] != "A" && s[0] != "B" && s[0] != "C")
            {
                return false;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (!int.TryParse(s[i], out temp))
                {
                    if (s[i] == "+" || s[i] == "-" || s[i] == "*" || s[i] == "/")
                    {
                        count--;
                    }
                    else if (s[i] == "A" || s[i] == "B" || s[i] == "C")
                    {
                        count++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    count++;
                }
                if (count < 0)
                {
                    return false;
                }
            }
            if (count != 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Validates that the expression has a format of prefix math expression. Input string has to not be empty, only include acceptable characters,
        /// starts with an operator, have tokens separated by a space (except when entering a negative number), and an operand preceding two operator.
        /// </summary>
        /// <param name="input">Math expression.</param>
        /// <returns>True if all variables are valid.</returns>
        public static bool PrefixValidation(string input)
        {
            int temp;
            input = input.Trim();
            string[] s = input.Split(' ');
            if (input.Length == 0)
            {
                return false;
            }
            int count = 0;
           
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (!int.TryParse(s[i], out temp))
                {
                    if (s[i] == "+" || s[i] == "-" || s[i] == "*" || s[i] == "/")
                    {
                        count--;
                    }
                    else if (s[i] == "A" || s[i] == "B" || s[i] == "C")
                    {
                        count++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    count++;
                }
                if (count > 0)
                {
                    return false;
                }
            }
            if (count != 0)
            {
                return false;
            }
            if (!int.TryParse(s[s.Length-1], out temp) && s[s.Length - 1] != "A" && s[s.Length - 1] != "B" && s[s.Length - 1] != "C")
            {
                return false;
            }
            return true;
        }
    }
}
