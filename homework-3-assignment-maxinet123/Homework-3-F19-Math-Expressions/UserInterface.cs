/*
 * UserInterface.cs
 * By: Maxine Teixeira
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KansasStateUniversity.TreeViewer2;

namespace KSU.CIS300.Math.Expressions
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Root of the tree representing the math expression entered; initially null.
        /// </summary>
        private INode _exprTree = null;
        /// <summary>
        /// Daws the equation in tree form.
        /// </summary>
        private TreeForm Drawing => new TreeForm(_exprTree, 100);
        /// <summary>
        /// Initializes the components and Changes updates text when changing.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            uxExpression.TextChanged += new EventHandler(uxExpression_TextChanged);
        }
        /// <summary>
        /// Calls validator corresponding to the radio button that was clicked. If methods return true, shows message that expression is valid, otherwise messagebox will say expression is invalid. Enables the create button and variable textboxes.
        /// </summary>
        /// <param name="sender">Reference to object</param>
        /// <param name="e">Event data</param>
        private void uxValidateExp_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (uxInfixSelection.Checked)
            {
                valid = Validator.InfixValidation(uxExpression.Text);
            }
            else if (uxPostfixSelection.Checked)
            {
                valid = Validator.PostfixValidation(uxExpression.Text);
            }
            else if (uxPrefixSelection.Checked)
            {
                valid = Validator.PrefixValidation(uxExpression.Text);
            }
            if (valid)
            {
                MessageBox.Show("Valid Input.");
                uxCreateTree.Enabled = true;
                uxVarAVal.Enabled = true;
                uxVarBVal.Enabled = true;
                uxVarCVal.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }
        /// <summary>
        /// Depending on the radio button selection, It will contruct the tree in the form the user checked on the radio button and enables the evaluate button.
        /// </summary>
        /// <param name="sender">Reference to object</param>
        /// <param name="e">Event data</param>
        private void UxCreateTree_Click(object sender, EventArgs e)
        {
            if (uxInfixSelection.Checked)
            {
                _exprTree = InfixParser.ConstructTree(uxExpression.Text, RetrieveVariables);
                Drawing.Show();
                uxEvaluate.Enabled = true;
            }
            else if (uxPostfixSelection.Checked)
            {
                _exprTree = PostfixParser.ConstructTree(uxExpression.Text, RetrieveVariables);
                Drawing.Show();
                uxEvaluate.Enabled = true;
            }
            else if (uxPrefixSelection.Checked)
            {
                _exprTree = PrefixParser.ConstructTree(uxExpression.Text, RetrieveVariables);
                Drawing.Show();
                uxEvaluate.Enabled = true;
            }
            else
            {
                uxEvaluate.Enabled = false;
            }
            UpdateExpression();
        }
        /// <summary>
        /// Calls the values for the results of each expression form and displays the answer. Catches error if they try to divide by zero.
        /// </summary>
        /// <param name="sender">Reference to object</param>
        /// <param name="e">Event data</param>
        private void UxEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_exprTree != null)
                {
                    uxInfixResult.Text = Convert.ToString(_exprTree.Value());
                    uxPostfixResult.Text = Convert.ToString(_exprTree.Value());
                    uxPrefixResult.Text = Convert.ToString(_exprTree.Value());
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Cannot divide by zero!!!");
            }
        }
        /// <summary>
        /// Clears and disables most buttons, expression textboxes, variable textboxes and results if the user begins to change the expression they input.
        /// </summary>
        /// <param name="sender">Reference to object</param>
        /// <param name="e">Event data</param>
        private void uxExpression_TextChanged(object sender, EventArgs e)
        {
            uxCreateTree.Enabled = false;
            uxEvaluate.Enabled = false;
            uxInfixExpression.Clear();
            uxPostfixExpression.Clear();
            uxPrefixExpression.Clear();
            uxInfixResult.Clear();
            uxPostfixResult.Clear();
            uxPrefixResult.Clear();
            uxVarAVal.Clear();
            uxVarBVal.Clear();
            uxVarCVal.Clear();
            uxVarAVal.Enabled = false;
            uxVarBVal.Enabled = false;
            uxVarCVal.Enabled = false;
        }
        /// <summary>
        /// Calls all Display methods to update all the contents in the GUI.
        /// </summary>
        private void UpdateExpression()
        {
            if (uxExpression.Text != null)
            {
                uxInfixExpression.Text = DisplayInfix(_exprTree);
                uxPostfixExpression.Text = DisplayPostfix(_exprTree);
                uxPrefixExpression.Text = DisplayPrefix(_exprTree);
            }
        }
        /// <summary>
        /// Builds and Displays the expression in infix form
        /// </summary>
        /// <param name="tree">Node that will be checked and built.</param>
        /// <returns>The whole expression in infix form</returns>
        private string DisplayInfix(INode tree)
        {
            switch (tree) 
            {
                case LiteralNode ln:
                    return ln.LiteralValue.ToString();
                case VariableNode vn:
                    return vn.Identifier.ToString();
                case OperatorNode on:
                    StringBuilder sb = new StringBuilder();
                    if (on.LeftChild is OperatorNode leftNode && GetPrecedence(leftNode.Operator) > GetPrecedence(on.Operator))
                    {
                        sb.Append('(');
                        sb.Append(DisplayInfix(on.LeftChild));
                        sb.Append(')');
                    }
                    else
                    {
                        sb.Append(DisplayInfix(on.LeftChild));
                    }
                    sb.Append(' ');
                    sb.Append(on.Operator);
                    sb.Append(' ');
                    if (on.RightChild is OperatorNode rightNode && GetPrecedence(rightNode.Operator) <= GetPrecedence(on.Operator))
                    {
                        sb.Append('(');
                        sb.Append(DisplayInfix(on.RightChild));
                        sb.Append(')');
                    }
                    else
                    {
                        sb.Append(DisplayInfix(on.RightChild));
                    }
                    return sb.ToString();
            }
            return "";

        }
        /// <summary>
        /// Builds and Displays the expression in postfix form
        /// </summary>
        /// <param name="tree">Node that will be checked and built.</param>
        /// <returns>The whole expression in postfix form</returns>
        private string DisplayPostfix(INode tree)
        {
            switch (tree)
            {
                case LiteralNode ln:
                    return ln.LiteralValue.ToString();
                case VariableNode vn:
                    return vn.Identifier.ToString();
                case OperatorNode on:
                    StringBuilder sb = new StringBuilder();

                    sb.Append(DisplayPostfix(on.LeftChild));
                    sb.Append(' ');
                    sb.Append(DisplayPostfix(on.RightChild));
                    sb.Append(' ');
                    sb.Append(on.Operator);
                    return sb.ToString();
            }
            return "";
        }
        /// <summary>
        /// Builds and Displays the expression in prefix form
        /// </summary>
        /// <param name="tree">Node that will be checked and built.</param>
        /// <returns>The whole expression in prefix form</returns>
        private string DisplayPrefix(INode tree)
        {
            switch (tree)
            {
                case LiteralNode ln:
                    return ln.LiteralValue.ToString();
                case VariableNode vn:
                    return vn.Identifier.ToString();
                case OperatorNode on:
                    StringBuilder sb = new StringBuilder();

                    sb.Append(on.Operator);
                    sb.Append(' ');
                    sb.Append(DisplayPrefix(on.LeftChild));
                    sb.Append(' ');
                    sb.Append(DisplayPrefix(on.RightChild));
                    return sb.ToString();
            }
            return "";
        }
        /// <summary>
        /// Sets the precedence in which the operators should be performed.
        /// </summary>
        /// <param name="op">Checks the operator</param>
        /// <returns>0 if parenthesis, 1 if mulitiply/divide, or 2 if plus/minus, otherwise returns -1</returns>
        private static int GetPrecedence(char op)
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
        /// Retrieves the variable that is equal to the parameter.
        /// </summary>
        /// <param name="c">variable being checked.</param>
        /// <returns>Returns function for variable found.</returns>
        private Func<int> RetrieveVariables(char c)
        {
            if (c == 'A')
            {
                return GetVariableA;
            }
            else if (c == 'B')
            {
                return GetVariableB;
            }
            else if (c == 'C')
            {
                return GetVariableC;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets variable for A if it can be parsed
        /// </summary>
        /// <returns>Variable for A otherwise returns 0</returns>
        private int GetVariableA()
        {
            if (int.TryParse(uxVarAVal.Text, out int result))
            {
                return result;
            }
            return 0;
        }
        /// <summary>
        /// Gets variable for B if it can be parsed
        /// </summary>
        /// <returns>Variable for B otherwise returns 0</returns>
        private int GetVariableB()
        {
            if (int.TryParse(uxVarBVal.Text, out int result))
            {
                return result;
            }
            return 0;
        }
        /// <summary>
        /// Gets variable for C if it can be parsed
        /// </summary>
        /// <returns>Variable for C otherwise returns 0</returns>
        private int GetVariableC()
        {
            if (int.TryParse(uxVarCVal.Text, out int result))
            {
                return result;
            }
            return 0;
        }
    }
}
