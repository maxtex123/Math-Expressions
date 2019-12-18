using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KSU.CIS300.Math.Expressions.Tests
{
    public class ParserTests
    {
        [Test, Timeout(1000)]
        public void TestA1_IsOperator()
        {
            Assert.IsTrue(InfixParser.IsOperator('/'));
            Assert.IsTrue(InfixParser.IsOperator('*'));
            Assert.IsTrue(InfixParser.IsOperator('+'));
            Assert.IsTrue(InfixParser.IsOperator('-'));
            Assert.IsFalse(InfixParser.IsOperator('A'));
            Assert.IsFalse(InfixParser.IsOperator('('));
            Assert.IsFalse(InfixParser.IsOperator(')'));
        }

        [Test, Timeout(1000)]
        public void TestA2_GetPrecedence()
        {
            int openPrec = InfixParser.GetPrecedence('(');
            int closePrec = InfixParser.GetPrecedence(')');
            int plusPrec = InfixParser.GetPrecedence('+');
            int dividePrec = InfixParser.GetPrecedence('/');
            int timesPrec = InfixParser.GetPrecedence('*');
            int minusPrec = InfixParser.GetPrecedence('-');
            int randPrec = InfixParser.GetPrecedence('A');

            bool openCloseMatch = (openPrec == closePrec);
            bool divideTimesMatch = (dividePrec == timesPrec);
            bool plusMinusMatch = (plusPrec == minusPrec);
            bool randomSmallest = (randPrec < openPrec && randPrec < plusPrec && randPrec < timesPrec);
            bool openNextSmallest = (openPrec < plusPrec && openPrec < timesPrec);
            bool addNextSmallest = (plusPrec > timesPrec);

            Assert.IsTrue(openCloseMatch);
            Assert.IsTrue(divideTimesMatch);
            Assert.IsTrue(plusMinusMatch);
            Assert.IsTrue(randomSmallest);
            Assert.IsTrue(openNextSmallest);
            Assert.IsTrue(addNextSmallest);
        }

        [Test, Timeout(1000)]
        public void TestA3_ApplyOperation()
        {
            Stack<INode> numStack = new Stack<INode>();
            Stack<char> opStack = new Stack<char>();

            numStack.Push(new LiteralNode(3));
            numStack.Push(new LiteralNode(9));
            opStack.Push('*');

            InfixParser.ApplyOperation(numStack, opStack);

            Assert.AreEqual(opStack.Count, 0);
            Assert.AreEqual(numStack.Count, 1);
            Assert.IsTrue(numStack.Peek() is OperatorNode);
            Assert.IsTrue(((OperatorNode)numStack.Peek()).LeftChild is LiteralNode);
            Assert.IsTrue(((OperatorNode)numStack.Peek()).RightChild is LiteralNode);
        }

        [Test, Timeout(1000)]
        public void TestA4_ConstructIntSingleDigit()
        {
            int newIdx = InfixParser.ConstructInt("1 + 305 * -206", 0, out int val);
            Assert.AreEqual(val, 1);
            Assert.AreEqual(newIdx, 0);
        }

        [Test, Timeout(1000)]
        public void TestA4_ConstructIntMultiDigit()
        {
            int newIdx = InfixParser.ConstructInt("1 + 305 * -206", 4, out int val);
            Assert.AreEqual(val, 305);
            Assert.AreEqual(newIdx, 6);
        }

        [Test, Timeout(1000)]
        public void TestA4_ConstructIntNegative()
        {
            int newIdx = InfixParser.ConstructInt("1 + 305 * -206", 10, out int val);
            Assert.AreEqual(val, -206);
            Assert.AreEqual(newIdx, 13);
        }

        [Test, Timeout(1000)]
        public void TestA5_SimpleInfixExpression()
        {
            INode node = InfixParser.ConstructTree("3 + 4", DummyEval);
            OperatorNode testNode = node as OperatorNode;
            Assert.IsNotNull(testNode);
            Assert.AreEqual(testNode.LeftChild.Value(), 3);
            Assert.AreEqual(testNode.RightChild.Value(), 4);
            Assert.AreEqual(testNode.Value(), 7);
        }


        [Test, Timeout(1000)]
        public void TestA6_LongInfixExpression()
        {
            INode node = InfixParser.ConstructTree("1 + 2 + 3 + 4 + 5 + 6", DummyEval);
            Assert.AreEqual(node.Value(), 21);
        }

        [Test, Timeout(1000)]
        public void TestA7_VariableInfixExpression()
        {
            INode node = InfixParser.ConstructTree("(A + 1) * (B*B - C)", SimpleEval);
            Assert.AreEqual(node.Value(), 2);
        }

        [Test, Timeout(1000)]
        public void TestB1_SimplePostfixExpression()
        {
            INode node = PostfixParser.ConstructTree("3 4 +", DummyEval);
            OperatorNode testNode = node as OperatorNode;
            Assert.IsNotNull(testNode);
            Assert.AreEqual(testNode.LeftChild.Value(), 3);
            Assert.AreEqual(testNode.RightChild.Value(), 4);
            Assert.AreEqual(testNode.Value(), 7);
        }

        [Test, Timeout(1000)]
        public void TestB2_LongPostfixExpression()
        {
            INode node = PostfixParser.ConstructTree("1 2 3 4 5 6 + + + + +", DummyEval);
            Assert.AreEqual(node.Value(), 21);
        }

        [Test, Timeout(1000)]
        public void TestB3_VariablePostfixExpression()
        {
            INode node = PostfixParser.ConstructTree("A 1 + B B * C - *", SimpleEval);
            Assert.AreEqual(node.Value(), 2);
        }

        [Test, Timeout(1000)]
        public void TestC1_SimplePrefixExpression()
        {
            INode node = PrefixParser.ConstructTree("+ 3 4", DummyEval);
            OperatorNode testNode = node as OperatorNode;
            Assert.IsNotNull(testNode);
            Assert.AreEqual(testNode.LeftChild.Value(), 3);
            Assert.AreEqual(testNode.RightChild.Value(), 4);
            Assert.AreEqual(testNode.Value(), 7);
        }

        [Test, Timeout(1000)]
        public void TestC2_LongPrefixExpression()
        {
            INode node = PrefixParser.ConstructTree("+ + + + + 1 2 3 4 5 6", DummyEval);
            Assert.AreEqual(node.Value(), 21);
        }

        [Test, Timeout(1000)]
        public void TestC3_VariablePrefixExpression()
        {
            INode node = PrefixParser.ConstructTree("* + A 1 - * B B C", SimpleEval);
            Assert.AreEqual(node.Value(), 2);
        }

        [Test, Timeout(1000)]
        public void TestD_TreesAreIdentical()
        {
            INode inNode = InfixParser.ConstructTree("3 + 3 * 3 + 3 * 3", DummyEval);
            INode postNode = PostfixParser.ConstructTree("3 3 3 * + 3 3 * +", DummyEval);
            INode preNode = PrefixParser.ConstructTree("+ + 3 * 3 3 * 3 3", DummyEval);

            int i = 0;
            INode walk = null;
            while (i < 3)
            {
                if (i == 0) walk = inNode;
                if (i == 1) walk = postNode;
                if (i == 2) walk = preNode;

                while (!(walk is LiteralNode))
                {
                    INode right = ((OperatorNode)walk).RightChild;
                    OperatorNode opRight = right as OperatorNode;
                    Assert.IsNotNull(opRight);
                    Assert.AreEqual(opRight.Operator, '*');
                    Assert.That(opRight.LeftChild, Is.InstanceOf(typeof(LiteralNode)));
                    Assert.AreEqual(opRight.LeftChild.Value(), 3);
                    Assert.That(opRight.RightChild, Is.InstanceOf(typeof(LiteralNode)));
                    Assert.AreEqual(opRight.RightChild.Value(), 3);

                    walk = ((OperatorNode)walk).LeftChild;
                }
                Assert.AreEqual(walk.Value(), 3);
                i++;
            }
        }




        private Func<int> DummyEval(char c)
        {
            return () => 0;
        }

        private Func<int> SimpleEval(char c)
        {
            if (c == 'A') return () => 1;
            if (c == 'B') return () => 2;
            if (c == 'C') return () => 3;
            return null;
        }
    }
}