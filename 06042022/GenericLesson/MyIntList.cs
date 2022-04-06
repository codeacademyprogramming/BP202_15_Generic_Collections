using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLesson
{
    internal class MyIntList
    {
        private int[] _arr;

        public MyIntList()
        {
            _arr = new int[0]; 
        }
        public int[] Array { get => _arr; }

        public void Add(int val)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }

        public int Count { get { return _arr.Length; } }

        public void Remove(int val)
        {
            //int[] newArr = new int[0];
            //int count = 0;
            //for (int i = 0; i < _arr.Length; i++)
            //{
            //    if (count>0 || _arr[i] != val )
            //    {
            //        System.Array.Resize(ref newArr, newArr.Length + 1);
            //        newArr[newArr.Length - 1] = _arr[i];
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}
            //_arr = newArr;

            int index = System.Array.IndexOf(_arr, val);
            
            if (index != -1)
            {
                for (int i = index; i < _arr.Length-1; i++)
                {
                    int swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }

        }

        public void RemoveAt(int index)
        {
            if (_arr.Length>index && index>=0)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    int swap = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = swap;
                }
                System.Array.Resize(ref _arr, _arr.Length - 1);
            }
        }



    }
}
