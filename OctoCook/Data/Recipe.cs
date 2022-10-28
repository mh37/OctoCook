using SQLite;
namespace EndToEnd.Data;
public class Recipe
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    
}