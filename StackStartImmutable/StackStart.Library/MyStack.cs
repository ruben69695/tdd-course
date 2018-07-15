using System;
using System.Collections.Generic;

namespace StackStart.Library
{
    public class MyStack<T>
    {
        private int _count;
        private T _item;
        private MyStack<T> _previousStack;

        public int Count {
            get { return _count; }
        }

        public MyStack() {
            _previousStack = null;
            _count = 0;
            _item = default(T);
        }

        private MyStack(MyStack<T> previousStack, T item, int count) {
            _previousStack = previousStack;
            _count = count;
            _item = item;
        }

        public MyStack<T> Push(T item) {
            return new MyStack<T>(this, item, _count + 1);
        }

        public T Peek() {
            return _item;
        }

        public MyStack<T> Pop() {
            return _previousStack;
        }

        // private IList<T> _items;

        // public int Count {
        //     get { return _items.Count; }
        // }

        // public MyStack() {
        //     _items = new List<T>();
        // }

        // public MyStack(IList<T> items) {
        //     _items = items;
        // }

        // public T Peek() {
        //     return _items[_items.Count - 1];
        // }

        // public MyStack<T> Push(T item) {
        //     var newItems = new List<T>(_items);
        //     newItems.Add(item);
        //     return new MyStack<T>(newItems);
        // }

        // public MyStack<T> Pop() {
        //     var newItems = new List<T>(_items);
        //     newItems.RemoveAt(_items.Count - 1);
        //     return new MyStack<T>(newItems);
        // }
    }
}
