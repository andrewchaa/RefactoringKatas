using System.Collections.Generic;
using System.Linq;

namespace RefactoringKatas.Compose_Method
{
    class ComposedMethodNew
    {
        private bool _isReadOnly;
        private int _size;
        private IList<object> _elements; 

        public void add(object element)
        {
            if (_isReadOnly)
                return;

            if (AtCapacity())
                Grow();

            AddElement(element);
        }

        private void AddElement(object element)
        {
            _elements[_size++] = element;
        }

        private bool AtCapacity()
        {
            return _elements.Count() < _size + 1;
        }

        private void Grow()
        {
            object[] newElements = new object[_elements.Count() + 10];
            for (int i = 0; i < _size; i++)
            {
                newElements[i] = _elements[i];
            }
            _elements = newElements;
        }
    }
}
