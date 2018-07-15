using System;
using System.Collections.Generic;

namespace StackStart.Library
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();

        public MyStack() { }

        public MyStack<T> Push(T item) {
            _items.Add(item);
            return this;
        }

        public T Pop() {
            if (_items.Count == 0) {
                return default(T);
            } else {
                var item = _items[_items.Count - 1];
                _items.RemoveAt(_items.Count -1);
                return item;
            }
        }
    }
}
