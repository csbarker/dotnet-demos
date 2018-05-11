using System;

namespace inheritance_demo
{
    public class DerivedExample
    {
        public static void DerivedMain()
        {
            var book = new Book("The Tempest", "0971655819", "Shakespeare, William", "Public Domain Press");
            ShowPublicationInfo(book);

            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            var book2 = new Book("The Tempest", "0971655820", "Shakespeare, William", "Classic Works Press");

            Console.WriteLine(
                $"{book.Title} and {book2.Title} are the same publication: " +
                $"{((Publication)book).Equals(book2)}"
            );
        }

        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine(
                $"{pub.Title}, " +
                $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}"
            );
        }
    }
}