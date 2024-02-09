namespace quest19._4
{
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
                arr[i] = list[i];
            return arr;
        }
    }
}
