# CustomProject1
#Go to Infrastructure.Data and run following Commands:
#To Add Migration
dotnet ef migrations add InitialCreate --context BlogDbContext --startup-project "../../Web" --output-dir "Migrations/BlogContext" 
#To Update Database
dotnet ef database update --context BlogDbContext --startup-project "../../Web"

#Go to Infrastructure.Identity and run following Commands:
#To Add Migration
dotnet ef migrations add InitialCreate --context ApplicationDbContext --startup-project "../../Web" --output-dir "Migrations/BlogContext" 
#To Update Database
dotnet ef database update --context ApplicationDbContext --startup-project "../../Web"
