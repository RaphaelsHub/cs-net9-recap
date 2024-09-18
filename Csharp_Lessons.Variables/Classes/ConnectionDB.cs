using System.Data.SqlClient;

namespace Csharp_Lessons.Classes;

// [Primary Key]
// Таблица "Пользователи": ID (Primary Key)   Имя   Электронная почта

// [Foreign Key]
// Таблица "Заказы": Order_ID (Primary Key)   User_ID (Foreign Key)   Дата   Сумма

public class ConnectionDB
{
    private string ConnectionString{get;set;}
    
    public ConnectionDB()
    {
        ConnectionString = new SqlConnectionStringBuilder()
        {
            DataSource = "(localdb)\\MSSQLLocalDB", //источник данных лок сервер базаданных(microsoftSql)
            InitialCatalog = "MSSQL_LocalDB_MarketPlace", //файл нашей бд который мы создали
            IntegratedSecurity = true,  //авторизация windows
            Pooling = true,
            Encrypt = true,
            TrustServerCertificate = false
        }.ToString();
        
        Connect();
    }

    private void Connect()
    {
        using(SqlConnection sqlConnection = new SqlConnection(ConnectionString))
        {
            sqlConnection.StateChange += (s, e) =>
            {
                Console.WriteLine($"SqlConnectionName = {nameof(sqlConnection)} State: {((s as SqlConnection)!).State}");
            };

            sqlConnection.Open();
        }
    }
}