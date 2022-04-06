using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericLesson
{
    //internal class MyList<T> where T:class, new()
    internal class MyList<T>:IEnumerable<T>
    {
        public MyList()
        {
            _arr = new T[0];
        }
        private T[] _arr;

        public void Add(T val)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }
        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }
        public T[] Array { get => _arr; }

        public int Count { get { return _arr.Length; } }

        public void Remove(T val)
        {
            int index = System.Array.IndexOf(_arr, val);

            if (index != -1)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    T swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }
        }

        public void RemoveAt(int index)
        {
            if (_arr.Length > index && index >= 0)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    T swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
           for (int i = 0; i < _arr.Length; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                yield return _arr[i];
            }
        }
    }
}
