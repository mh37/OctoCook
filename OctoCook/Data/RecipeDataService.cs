using SQLite;
namespace EndToEnd.Data;
public class RecipeDataService
{
    string _dbPath;
    public string StatusMessage { get; set; }
    private SQLiteAsyncConnection conn;
    public RecipeDataService(string dbPath)
    {
        _dbPath = dbPath;
    }
    private async Task InitAsync()
    {
        // Don't Create database if it exists
        if (conn != null)
            return;
        // Create database and Recipe Table
        conn = new SQLiteAsyncConnection(_dbPath);
        await conn.CreateTableAsync<Recipe>();
    }
    public async Task<List<Recipe>> GetRecipesAsync()
    {
        await InitAsync();
        return await conn.Table<Recipe>().ToListAsync();
    }

    public async Task<Recipe> GetRecipeAsync(int id)
    {
        return await conn.GetAsync<Recipe>(id);
    }

    public async Task<Recipe> CreateRecipeAsync(
        Recipe paramRecipe)
    {
        // Insert
        await conn.InsertAsync(paramRecipe);
        // return the object with the
        // auto incremented Id populated
        return paramRecipe;
    }
    public async Task<Recipe> UpdateRecipeAsync(
        Recipe paramRecipe)
    {
        // Update
        await conn.UpdateAsync(paramRecipe);
        // Return the updated object
        return paramRecipe;
    }
    public async Task<Recipe> DeleteRecipeAsync(
        Recipe paramRecipe)
    {
        // Delete
        await conn.DeleteAsync(paramRecipe);
        return paramRecipe;
    }
}