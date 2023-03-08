
using AccessModifiers;

Book[] books = new Book[3];


for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine("Enter a book name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter page count: ");
    int num = int.Parse(Console.ReadLine());
    
    while (!CheckName(name))
    {
        name = Console.ReadLine();
    }
    while (!CheckPageCount(num))
    {
        num = int.Parse(Console.ReadLine());
    }
    
    
    Book book = new Book(name,num);
    books[i] = book;

}


bool CheckName(string name)
{
    if(!string.IsNullOrEmpty(name))
        return true;

    return false;
}

bool CheckPageCount(int num)
{
    if (num > 10)
        return true;

    return false;
}

Console.WriteLine("\n\n**OUTPUT**\n");

foreach (Book libro in books)
{
    Console.WriteLine($"Name: {libro.Name}\nPage Count: {libro.PageCount}\n");
}