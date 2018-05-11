using System;

public sealed class Book : Publication
{
    public Book(string title, string author, string publisher) :
          this(title, String.Empty, author, publisher)
    { }

    public Book(string title, string isbn, string author, string publisher) : base(title, publisher, PublicationType.Book)
    {
        if (String.IsNullOrEmpty(isbn))
            throw new ArgumentException("The ISBN is required");
        if (isbn.Length != 10 && isbn.Length != 13)
            throw new ArgumentException("The ISBN must be a 10- or 13-character numeric string.");
        ulong nISBN = 0;
        if (!UInt64.TryParse(isbn, out nISBN))
            throw new ArgumentException("The ISBN can only contain numeric characters");

        ISBN = isbn;
        Author = author;
    }

    public string ISBN { get; }
    public string Author { get; }
    public decimal Price { get; private set; }
    public string Currency { get; private set; } // 3 digit ISO

    // sets the new book price and returns the old one
    public Decimal setPrice(decimal price, string currency)
    {
        if (price < 0)
            throw new ArgumentOutOfRangeException("The price cannot be negative");
        Decimal oldVal = Price;
        Price = price;

        if (currency.Length != 3)
            throw new ArgumentException("The currency must be a 3 digit ISO code");
        Currency = currency;

        return oldVal;
    }

    public override bool Equals(object obj)
    {
        Book book = obj as Book;
        if (book == null)
            return false;
        else
            return ISBN == book.ISBN;
    }

    public override int GetHashCode() => ISBN.GetHashCode();
    public override string ToString() => $"{(String.IsNullOrEmpty(Author) ? "" : Author + ", ")}{Title}";
}