# Isaac Characters Notetaking

A list of characters in The Binding of Isaac: Repentance. Comes with the stats of the characters, allows for users to write the "Gimmicks" in themselves. Built for .NET Web Development at WCTC.

**Live:** https://ff-web-kp8594.azurewebsites.net/

## What it does

- Browse all Characters in a list.
- Open a Character to see specific details and add a Gimmick.
- Gimmicks allow for a timestamp given by you and a "Gimmick" you write.

## The three things I fixed for the midterm

1. Details link is a link instead of a button, and the navbar doesn't need a Home link if the title brings to the home as well.
2. Characters/Delete shows raw data instead of styling it. Ex: Isaac 3 2 2
3. Buttons in details page are not in line with each other.

## Built with

ASP.NET Core MVC (.NET 10), Entity Framework Core, SQL Server, Bootstrap.

## Running it locally

The connection string lives in user secrets, not in this repo:

    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<your connection string>"
    dotnet ef database update
    dotnet watch