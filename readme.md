An attempt to help https://github.com/fsprojects/SQLProvider/issues/529

The "lib" folder contains the output from commit 627c75a8eb794a4f68c7a289cf265c90183cd040 built on my machine.

# Running it:
* Create the database with the scripts in `SqlProvider\src\DatabaseScripts\MSSQLServer\*.sql`
* adjust the connectionstring in Program.fs :)
* `dotnet run`

# Recap:
* It works with `SQLProvider` Version="1.1.37"
* It does compile, but fails at runtime with v.1.1.38 (and up)
* It works with the dlls in `lib`

The exception I get:
```
Unhandled Exception: System.TypeLoadException: Could not load type 'System.Data.SqlClient.SqlConnection' from assembly
'System.Data.SqlClient, Version=4.2.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
   at FSharp.Data.Sql.Providers.MSSqlServerProvider.FSharp-Data-Sql-Common-ISqlProvider-CreateConnection(String connectionString)
   at <StartupCode$FSharp-Data-SqlProvider>.$SqlRuntime.DataContext.-ctor@37-54.Invoke(String typeName)
   at System.Collections.Concurrent.ConcurrentDictionary`2.GetOrAdd(TKey key, Func`2 valueFactory)
   at FSharp.Data.Sql.Runtime.SqlDataContext..ctor(String typeName, String connectionString, DatabaseProviderTypes providerType, String resolutionPath, String[] referencedAssemblies, String runtimeAssembly, String owner, CaseSensitivityChange caseSensitivity, String tableNames, OdbcQuoteCharacter odbcquote, SQLiteLibrary sqliteLibrary, TransactionOptions
transactionOptions, FSharpOption`1 commandTimeout, SelectOperations sqlOperationsInSelect)
   at Program.main(String[] argv) in C:\Dev\squl\Program.fs:line 17
```
