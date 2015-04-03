using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringKatas.Compose_Method
{
    class ComposedMethod
    {
        private bool _isReadOnly;
        private int _size;
        private IList<object> _elements; 

        public void add(object element)
        {
            if (_isReadOnly)
            {
                var newSize = _size + 1;
                if (newSize > _elements.Count())
                {
                    object[] newElements = new object[_elements.Count() + 10];
                    for (int i = 0; i < _size; i++)
                    {
                        newElements[i] = _elements[i];
                    }
                    _elements = newElements;
                }
                _elements[_size++] = element;
            }
        }
    }
}
