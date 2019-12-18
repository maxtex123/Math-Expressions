using NUnit.Framework;
using System;

namespace KSU.CIS300.Math.Expressions.Tests
{
    public class NodeTests
    {
        [Test]
        public void TestA1_LiteralNodeProperties()
        {
            LiteralNode node = new LiteralNode(0);
            Assert.That(node, Has.Property("LiteralValue"));
        }

        [Test]
        public void TestA2_VariableNodeProperties()
        {
            VariableNode node = new VariableNode('A', () => 0);
            Assert.That(node, Has.Property("Identifier"));
        }

        [Test]
        public void TestA3_OperatorNodeProperties()
        {
            OperatorNode node = new OperatorNode('+', null, null);
            Assert.That(node, Has.Property("Operator"));
            Assert.That(node, Has.Property("LeftChild"));
            Assert.That(node, Has.Property("RightChild"));
        }



        [Test]
        public void TestB1_InitializeLiteralNode()
        {
            LiteralNode[] nodes = new LiteralNode[10];
            for (int i = 0; i < 10; i++)
            {
                nodes[i] = new LiteralNode(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(nodes[i].LiteralValue, i);
                Assert.IsFalse(nodes[i].IsEmpty);
                Assert.AreEqual(nodes[i].Value(), i);
            }
        }

        [Test]
        public void TestB2_InitializeVariableNode()
        {
            Func<int> eval = () => 3;
            VariableNode node = new VariableNode('A', eval);

            Assert.AreEqual(node.Identifier, 'A');
            Assert.IsFalse(node.IsEmpty);
            Assert.AreEqual(node.Value(), 3);
        }

        [Test]
        public void TestB3_InitializeOperatorNode()
        {
            Func<int> eval = () => 3;
            VariableNode node1 = new VariableNode('A', eval);
            LiteralNode node2 = new LiteralNode(5);
            OperatorNode node = new OperatorNode('*', node1, node2);

            Assert.AreEqual(node.Operator, '*');
            Assert.IsFalse(node.IsEmpty);
            Assert.AreEqual(node.Value(), 15);
        }
    }
}