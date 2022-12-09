# OctoCook

A cross platform application made with .NET MAUI and Blazor to manage your cooking recipes and search & import new ones from external sources. Currently the only supported API for the recipe search is Spoonacular. 

You are also provides with the option to import and export your recipes to and from backups. The recipes are otherwise stored in a local SQLite database. 

## Technologies used

- Blazor Hybrid with .NET MAUI
  - Razor components run natively on the device and components render to an embedded Web View control through the local interop channel (not the browser, so no Web Assembly is involved here)
  - Allows for full access to native capabilities
- TinyMCE Richtext Editor
- Local SQLite DB

## Screenshots

### Windows

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Windows/myRecipes.jpg)

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Windows/searchRecipes.jpg)

### Android

<img src="https://raw.githubusercontent.com/mh37/OctoCook/master/Screenshots/Android/menu.png?token=GHSAT0AAAAAAB2NL5WZ6EQD4VT7LHE4DHFWY4TFIHQ" width=50% height=50%>

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Android/myRecipes.png)

![image](https://github.com/mh37/OctoCook/blob/master/Screenshots/Android/searchRecipes.png)

