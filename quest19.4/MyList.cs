using System;

namespace quest19._4
{
    public class MyList<T>
    {
        private T[] _array;
        private int current = 0;
        public int Count { get { return _array == null ? 0 : _array.Length; } }
        public void Add(T value)
        {
            if (_array == null)
                _array = new T[1];
            if (_array.Length == current)
                Array.Resize(ref _array, _array.Length + 1);
            _array[current] = value;
            current++;
        }
        public T this[int index]
        {
            get
            {
                if (_array == null) throw new NullReferenceException();
                else
                {
                    if (index < 0 || index > _array.Length - 1) throw new IndexOutOfRangeException();
                    else { return _array[index]; }
                }
            }
        }
    }
}
