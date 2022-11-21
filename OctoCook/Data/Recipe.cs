using OctoCook.Data.API.Spoonacular;
using SQLite;
namespace EndToEnd.Data;
public class Recipe
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public int ReadyInMinutes { get; set; }
    public int Servings { get; set; }
    public string Ingredients { get; set; }
    public string Summary { get; set; }
    public string Instructions { get; set; }

}