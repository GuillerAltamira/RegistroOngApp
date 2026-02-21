using System.Data.SqlClient;

public sealed class ConexionDB
{
    private static ConexionDB _instance = null;
    private static readonly object _lock = new object();
    private SqlConnection _conexion;

    private ConexionDB()
    {
        _conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RegistroOngDB;Integrated Security=True");
        _conexion.Open();
    }

    public static ConexionDB Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new ConexionDB();
                return _instance;
            }
        }
    }

    public SqlConnection GetConnection()
    {
        return _conexion;
    }
}