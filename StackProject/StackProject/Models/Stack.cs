using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject.Models
{
   public class Stack
    {
        private List<object> _items = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null to the stack.");
            _items.Add(obj);
        }

        public object Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            object lastItem = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return lastItem;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
