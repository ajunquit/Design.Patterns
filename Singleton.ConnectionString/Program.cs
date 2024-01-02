using Singleton.ConnectionString;

Console.WriteLine("Singleton Desing Pattern Example 2\n\n");

// get connection for the first time.
DatabaseConnection connectionSample1 = DatabaseConnection.GetConnectionDatabase();
Console.WriteLine(connectionSample1.GetConnectionString());

// get connection for the second time.
DatabaseConnection connectionSample2 = DatabaseConnection.GetConnectionDatabase();
Console.WriteLine(connectionSample2.GetConnectionString());

Console.ReadLine();