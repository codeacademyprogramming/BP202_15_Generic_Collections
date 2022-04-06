using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLesson
{
    internal class MyStringList
    {
        private string[] _arr;

        public MyStringList()
        {
            _arr = new string[0];   
        }

        public string[] Array { get => _arr; }

        public void Add(string val)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }

        public int Count { get { return _arr.Length; } }

        public void Remove(string val)
        {
            int index = System.Array.IndexOf(_arr, val);

            if (index != -1)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    string swap = _arr[i];
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
                    string swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }
        }

    }
}
