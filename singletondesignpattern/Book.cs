namespace SingletonDesignPattern;
public sealed class Book
{
    private static readonly Lazy<Book> bookInstance = new Lazy<Book>(() => new Book());

    private Book()
    {
        Console.WriteLine("Book new Instance is created");
    }

    public static Book Instance => bookInstance.Value;

    public void GetBookTitle()
    {
        Console.WriteLine("C# for dummies");
    }
}