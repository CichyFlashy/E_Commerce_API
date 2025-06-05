# E-Commerce API

Projekt Web API stworzony w .NET, służący jako backend dla aplikacji e-commerce. Umożliwia zarządzanie produktami oraz zamówieniami.

##  Technologie

- .NET 9
- Entity Framework Core
- RESTful API
- GitHub Actions (CI/CD)
- SQL Server


## Struktura projektu

```
ECommerceAPI/
├── Controllers/
├── Models/
├── Data/
├── Migrations/
├── ECommerceAPI.csproj
└── Program.cs
```

##  CI/CD – GitHub Actions

Automatyczne budowanie, testowanie i publikowanie aplikacji za pomocą GitHub Actions.

###  Workflow

Plik `.github/workflows/deploy.yml` uruchamia się automatycznie przy każdym pushu do gałęzi `main`:

```yaml
on:
  push:
    branches:
      - main
```

### Etapy workflow:

1. **Checkout kodu**
2. **Instalacja środowiska .NET (`9.0.200`)**
3. **Restore zależności** (`dotnet restore`)
4. **Budowanie aplikacji** (`dotnet build`)
5. **Publikacja do folderu `/publish`** (`dotnet publish`)

## Jak uruchomić lokalnie?

1. Zainstaluj [.NET SDK 9.0.200](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
2. Przywróć zależności:
   ```bash
   dotnet restore
   ```
3. Uruchom aplikację:
   ```bash
   dotnet run
   ```
4. Domyślny port: `https://localhost:5001`

## Jak dodać migrację i zaktualizować bazę?

```bash
dotnet ef migrations add SomeMigrationName
dotnet ef database update
```
## Jak się połączyć z wdrożoną aplikacją

**Adres API**:  
e-commerce-gbd7byc5ererf8ak.polandcentral-01.azurewebsites.net


## Wykorzystane usługi Azure

Projekt korzysta z następujących usług Azure:

- **Azure App Service** – do hostowania aplikacji webowej
- **Azure SQL Database** – jako główna relacyjna baza danych
- **Azure Managed Identity** – do bezpiecznego uwierzytelniania aplikacji bez haseł
- **Azure CLI** – do zarządzania zasobami i uprawnieniami
- **Azure Data Studio** – do zarządzania bazą danych
