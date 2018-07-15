using System;

namespace StackStart.Library
{
    public class MyStack
    {

        private object[] _item;
        private int _currentIndex;

        public MyStack(int capacity) {
            _item = new object[capacity];
            _currentIndex = 0;
        }

        public void Push(object item) {
            if(item == null) {
                throw new ArgumentNullException();
            }
            else {
                _item[_currentIndex] = item;
                _currentIndex++;
            }

        }

        public object Pop() {
            if (_currentIndex == 0)
                return null;
            else {
                var item = _item[_currentIndex - 1];
                _currentIndex--;
                return item;
            }
        }
    }
}
