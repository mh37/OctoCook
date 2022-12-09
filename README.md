# OctoCook

A cross platform application made with .NET MAUI and Blazor to manage your cooking recipes and search & import new ones from external sources. Currently the only supported API for the recipe search is Spoonacular. 

You are also provides with the option to import and export your recipes to and from backups. The recipes are otherwise stored in a local SQLite database. 

## Technologies used

- Blazor Hybrid with .NET MAUI
  - Razor components run natively on the device and components render to an embedded Web View control through the local interop channel (not the browser, so no Web Assembly is involved here)
  - Allows for full access to native capabilities
- TinyMCE Richtext Editor
- Local SQLite DB

## Supported Platforms

- Android 7.0 (API 24) or higher
- iOS 14 or higher
- macOS 11 or higher
- Windows 10 (1809) or higher
- Samsung Tizen

Warning: This was only tested on Android and Windows. Configurations for other platforms may be incomplete. 


## Screenshots

### Windows

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Windows/myRecipes.jpg)

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Windows/searchRecipes.jpg)

### Android

<img src="https://github.com/mh37/OctoCook/blob/master/Screenshots/Android/menu.png" width=50% height=50%>

<img src="https://github.com/mh37/OctoCook/blob/master/Screenshots/Android/myRecipes.png" width=50% height=50%>

<img src="https://github.com/mh37/OctoCook/blob/master/Screenshots/Android/searchRecipes.png" width=50% height=50%>



