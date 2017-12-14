using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Store.DB;
using Entities;
using MySql.Data.MySqlClient;

namespace Store
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            string connectionString = "server=localhost;port=3306;database=store;uid=root;password=1234";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (var context = new Context(connection, false))
                {
                    context.Database.CreateIfNotExists();
                }
            }
        }
    }
}
