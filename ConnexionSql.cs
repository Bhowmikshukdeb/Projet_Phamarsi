using MySql.Data.MySqlClient;

public class ConnexionSql
{
    private static ConnexionSql instance;
    private MySqlConnection maConnexion;

    private ConnexionSql(string provider, string dataBase, string uid, string mdp)
    {
        string connString = $"server={provider};port = 5222;database={dataBase};uid={uid};pwd={mdp}";
        maConnexion = new MySqlConnection(connString);
    }

    public static ConnexionSql getInstance(string provider, string dataBase, string uid, string mdp)
    {
        if (instance == null)
            instance = new ConnexionSql(provider, dataBase, uid, mdp);

        return instance;
    }

    public void OpenConnexion()
    {
        if (maConnexion.State != System.Data.ConnectionState.Open)
            maConnexion.Open();
    }

    public void CloseConnexion()
    {
        if (maConnexion.State != System.Data.ConnectionState.Closed)
            maConnexion.Close();
    }
    public MySqlCommand reqExec(string req)
    {
        return new MySqlCommand(req, maConnexion);
    }
    public MySqlConnection getSqlConnexion()
    {
        return maConnexion;
    }

}