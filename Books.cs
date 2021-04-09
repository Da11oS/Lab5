using System;
using System.Collections;

namespace Lab5
{
    class Books 
    {
        public Book[] books;
        public Books() 
        {
            books = Book.TestBooks();

        }
        public IEnumerable GetByAuthor()
        {
            return new EnumAuthor(books);
        }
        public IEnumerable GetByPrice()
        {
            return new EnumPrice(books);
        }
        public IEnumerable GetReverseEnum() 
        {
            for (int i = books.Length - 1; i >= 0; --i)

                yield return books[i];
        }


    }
}
