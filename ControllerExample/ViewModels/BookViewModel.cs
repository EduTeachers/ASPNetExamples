namespace ControllerExample.ViewModels;

public class BookViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ISBN = "978-80-271-0795-7";
    public string Author { get; set; }
    public DateTime YearPublished { get; set; }
}