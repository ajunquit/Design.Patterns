namespace Singleton.ConnectionString;

public class DatabaseConnection
{
    private string Server { get; set; }
    private string Database { get; set; }
    private string UserId { get; set; }
    private string Password { get; set; }

    private static DatabaseConnection _connectionDatabase;

    private DatabaseConnection()
    {
        Server = "myServer";
        Database = "myDatabase";
        UserId = "myUserId";
        Password = "myPassword";
    }

    public string GetConnectionString()
    {
        return $"Server={Server};Database={Database};User Id={UserId};Password={Password};";
    }

    public static DatabaseConnection GetConnectionDatabase()
    {
        if (_connectionDatabase == null)
        {
            _connectionDatabase = new DatabaseConnection();
        }
        return _connectionDatabase;
    }

}
