using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLesson
{
    internal class MyHumanList
    {
        private Human[] _arr;

        public MyHumanList()
        {
            _arr = new Human[0];
        }

        public int Count { get { return _arr.Length; } }
        public Human[] Array { get { return _arr; } }

        public void Add(Human val)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }

        public void Remove(Human val)
        {
            int index = System.Array.IndexOf(_arr, val);

            if (index != -1)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    Human swap = _arr[i];
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
                    Human swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }
        }

    }
}
