using System;
using System.Collections.Generic;

namespace Project_MyList
{
    public class MyList
    {
        private int[] _tempItems;
        private int[] _items;

        public MyList()
        {
            _items = new int[] { };
        }

        public MyList(int range)
        {
            if (range < 0) Console.WriteLine("Индекс не может быть меньше 0.");
            else _items = new int[range];
        }

        public int Count()
        {
            return _items.Length;
        }

        public void Add(int item)
        {
            Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;
        }

        public void ShowMyList()
        {
            foreach (int item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index < 0) return false;
            RemoveAt(index);
            return true;
        }

        private void RemoveAt(int index)
        {
            _tempItems = new int[_items.Length - 1 - index];
            for (int i = index + 1; i < _items.Length; i++)
            {
                _tempItems[i - index - 1] = _items[i];
            }

            for (int i = index; i < _items.Length - 1; i++)
            {
                _items[i] = _tempItems[i - index];
            }

            Resize(ref _items, _items.Length -1);
        }

        public int IndexOf(int item)
        {
            return Array.IndexOf(_items, item);
        }


        public void Clear()
        {
            Array.Clear(_items, 0, _items.Length);
        }

        private void Resize(ref int[] _items, int newSize)
        {
            _tempItems = new int[newSize];

            if (newSize > _items.Length)
            {
                for (int i = 0; i < newSize-1; i++)
                {
                    _tempItems[i] = _items[i];
                }
            }
            else
            {
                for (int i = 0; i < newSize; i++)
                {
                    _tempItems[i] = _items[i];
                }
            }

            _items = _tempItems;
        }
    }
}