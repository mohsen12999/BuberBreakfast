# Buber Breakfast

- course that developers can use as a template to onboard/structure small to medium sized industry-level CRUD applications.

- make solution: `dotnet new sln -o BuberBreakfast`.
- add git ignore file: `dotnet new gitignore`.
- add class library for DTOs: `dotnet new classlib -o BuberBreakfast.Contracts`.
- add web api: `dotnet new webapi -o BuberBreakfast`.
- add projects to sln: `dotnet sln add (ls -r **/*.csproj)` or `dotnet sln add .\BuberBreakfast.Contracts\ .\BuberBreakfast\`.
- add breakfast contract reference: `dotnet add .\BuberBreakfast\ reference .\BuberBreakfast.Contracts\`.

## Reference

- base on [Youtube video](https://youtu.be/PmDJIooZjBE) by [Amichai Mantinband](https://twitter.com/amantinband)
- code on github: https://github.com/amantinband/buber-breakfast