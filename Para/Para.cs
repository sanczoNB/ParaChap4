using System;

namespace Para
{
    public class Para<T> : IComparable<Para<T>> where T : IComparable<T>
    {
        private T _first = default(T);
        private T _second = default(T);

        public Para(T first, T second)
        {
            _first = first;
            _second = second;
        }

        public int CompareTo(Para<T> other)
        {
            var comparisonFirstElem = _first.CompareTo(other._first);
            if (comparisonFirstElem == 0)
            {
                return _second.CompareTo(other._second);
            }
            return comparisonFirstElem;
        }

        public override string ToString()
        {
            return $"{_first}\t{_second}";
        }
    }
}
