using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackStart.Library;
using System;

namespace StackStart.Tests
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void CanPushAnItem() {
            var stack = new MyStack<string>();
            var fooStack = stack.Push("foo");

            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(1, fooStack.Count);
        }

        [TestMethod]
        public void CanPeekItem() {
            var stack = new MyStack<string>();
            var fooStack = stack.Push("foo");

            Assert.AreEqual("foo", fooStack.Peek());
            Assert.AreEqual("foo", fooStack.Peek());
        }

        public void CanPopOffItem() {
            var stack = new MyStack<string>();
            var barStack = stack.Push("foo").Push("bar");

            var fooStack = barStack.Pop();
            var emptyStack = barStack.Pop();

            Assert.AreEqual(2, barStack.Count);
            Assert.AreEqual(1, fooStack.Count);
            Assert.AreEqual(0, emptyStack.Count);
        }

        // [TestMethod]
        // public void CanPopOffMultipleItems() {
        //     var stack = new MyStack<string>()
        //         .Push("foo")
        //         .Push("bar");
                
        //     Assert.AreEqual("bar", stack.Pop());
        //     Assert.AreEqual("foo", stack.Pop());
        // }

        // [TestMethod]
        // public void CanPopFromEmptyStack() {
        //     var stack = new MyStack<string>();
        //     Assert.AreEqual(null, stack.Pop());
        // }
    }
}
