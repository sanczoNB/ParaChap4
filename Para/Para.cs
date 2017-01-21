namespace Para
{
    public class Para<T>
    {
        private T _first = default(T);
        private T _second;

        public Para(T first, T second)
        {
            _first = first;
            _second = second;
        }

        public override string ToString()
        {
            return $"{_first}\t{_second}";
        }
    }
}
