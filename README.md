# Xacte.UOW.POC

## How to test

There are 2 web projects in this solution, one is built with .NET 7 and the other one is built with .NET Framework

1. Navigate to the solution properties and update the project so you can run both the web projects at the same time.

### Running the migrations toc create your DB

1. Open your nugget management console.
2. Select Xacte.NETF.DATA as the base project to run the commands.
3. Run the command `update-database` this command should create your local database for the POC (make sure you have the correct connectionstring setup in the DBContexts, IT'S HARDCODED (just for the purpose of the demo)).

### the controllers

* `api/xacte` : This controller uses EntityFramework behind the scenes.
* `api/xacte/petapoco` : This controller uses the well known PetaPoco.

### .NET 7 web project

* this project automatically loads swagger where you will see 2 methods `api/xacte` and `api/xacte/petapoco`, just open them up in swagger and run the methods.

### .NET Framework project

* In the browser window that got opened for this project just attach the endpoint  `api/xacte` for the EF functionality and  `api/xacte/petapoco` for the data access through petapoco.

### Changes to PETAPOCO for .NET 7

Since the namespace for System.Data.SqlClient has changed to Microsoft.Data.SqlClient and the fact that there is no automatic library registration in .NET 7 for this component, we have to register it for the DBFactory.

```csharp
/// <summary>
/// Provides common initialization for the various constructors
/// </summary>
public void CommonConstruct()
{
    DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", Microsoft.Data.SqlClient.SqlClientFactory.Instance);

    // Reset
    _transactionDepth = 0;
    EnableAutoSelect = true;
    EnableNamedParams = true;

    // If a provider name was supplied, get the IDbProviderFactory for it
    if (_providerName != null)
        _factory = DbProviderFactories.GetFactory(_providerName);

    // Resolve the DB Type
    string DBTypeName = (_factory == null ? _sharedConnection.GetType() : _factory.GetType()).Name;
    _dbType = DatabaseType.Resolve(DBTypeName, _providerName);

    // What character is used for delimiting parameters in SQL
    _paramPrefix = _dbType.GetParameterPrefix(_connectionString);
}
```
