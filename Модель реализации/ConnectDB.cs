using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Модель_реализации
{
    public class ConnectDB
    {
        public static MySqlConnectionStringBuilder db;
        public static MySqlConnection GetConnecton()
        {
            db = new MySqlConnectionStringBuilder();

            db.Server = "pgsha.ru";
            db.Database = "sofr0008";
            db.UserID = "sofr0008";
            db.Password = "b2TAEsRu ";

            db.CharacterSet = "utf8";
            return new MySqlConnection(db.ConnectionString);
        }
        
        }
}
