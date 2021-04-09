using System;
using System.Collections;
namespace Lab5
{
	public class EnumAuthor : IEnumerable, IEnumerator
	{
		int i = -1;

		Book[] data;

        public object Current => data[i];
        internal EnumAuthor(Book[] books)
		{
            data = (Book[])books.Clone();

            Array.Sort(data, Book.ByAuthor());
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            i++;

            if (i < data.Length) 
                return true;
            else return false;
        }

        public void Reset()
        {
            i = -1;
        }
    }
}
