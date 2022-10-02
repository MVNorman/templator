0) Install EF Migration CLI:

dotnet tool install --global dotnet-ef --version 6.0.9

1) Go to project root directory

2) Add New Migration:

dotnet ef migrations add InitialCreate --project src/Infrastructure/Infrastructure.csproj --startup-project src/Api/Api.csproj --json --output-dir Ef/Migrations

3) Remove Latest Migration:

dotnet ef migrations remove --project src/Infrastructure/Infrastructure.csproj --startup-project src/Api/Api.csproj --json

4) Update Database to Latest Migration:

dotnet ef database update --project src/Infrastructure/Infrastructure.csproj --startup-project src/Api/Api.csproj

5) Update Database to a specific Migration:

dotnet ef database update InitialCreate --project src/Infrastructure/Infrastructure.csproj --startup-project src/Api/Api.csproj