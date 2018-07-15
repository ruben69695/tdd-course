using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackStart.Library;
using System;

namespace StackStart.Tests
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopOffMultipleItems() {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopFromEmptyStack() {
            var stack = new MyStack(100);
            Assert.AreEqual(null, stack.Pop());
        }

        [TestMethod]
        public void ShouldFailWhenPushingNull() {
            var stack = new MyStack(100);
            Assert.ThrowsException<ArgumentNullException>(() => {
                stack.Push(null);
            });
        }
    }
}
