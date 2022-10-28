using Microsoft.AspNetCore.Components.WebView.Maui;
using EndToEnd.Data;
namespace OctoCook;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        // Set path to the SQLite database (it will be created if it does not exist)
        var dbPath =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                @"MyRecipes.db");
        // Register RecipeDataService and the SQLite database
        builder.Services.AddSingleton<RecipeDataService>(
            s => ActivatorUtilities.CreateInstance<RecipeDataService>(s, dbPath));

        return builder.Build();
	}
}
