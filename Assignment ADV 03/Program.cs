namespace Assignment_ADV_03
{

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Book> myBooks = new List<Book>()
{
             new Book("B101", "C# Advanced", new string[] { "Hesham", "Sayed" }, new DateTime(2020, 1, 15), 55),
             new Book("B202", "OOP C#", new string[] { "Mohammed", "Sayed" }, new DateTime(2021, 6, 20), 76),
             new Book("B303", "Design Patterns", new string[] { "Khalid", "Hamza" }, new DateTime(2022, 12, 5), 99)};


            var process = LibraryEngine.ProcessBooks;


            Console.WriteLine("=== Titles ===");
            process(myBooks, BookFunctions.GetTitle);


            Console.WriteLine("\n=== Publication Years ===");
            process(myBooks, b => b.PublicationDate.Year.ToString());


            Console.WriteLine("\n=== ISBN Codes ===");
            process(myBooks, delegate (Book bk)
            {
                return $"Code: {bk.ISBN}";
            });

        }
    }
}