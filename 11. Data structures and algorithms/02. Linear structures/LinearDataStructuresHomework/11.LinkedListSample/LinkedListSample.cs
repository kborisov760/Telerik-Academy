namespace LinkedListSample
{
    public class LinkedListSample
    {
        public class ListItem<T> where T : struct
        {
            public T Value { get; set; }

            public ListItem<T> NextItem { get; set; }
        }

        public class LinkedList<T> where T : struct
        {
            ListItem<T> FirstElement { get; set; }
        }
    }
}
