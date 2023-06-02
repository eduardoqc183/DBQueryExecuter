using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace DatabaseCommandUpdater
{
    public enum TipoMotor
    {
        Mssql,
        Pgsql
    }

    public class ConexionData
    {
        public string ServerName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }

        public DbConnection ObtenerConexion(TipoMotor tm, string dbname = null)
        {
            switch (tm)
            {
                case TipoMotor.Mssql:
                    {
                        var cm = new SqlConnectionStringBuilder()
                        {
                            DataSource = this.ServerName,
                            UserID = this.User,
                            Password = this.Password,
                            InitialCatalog = dbname ?? "master",
                            Pooling = false
                        };

                        return new SqlConnection(cm.ConnectionString);
                    }

                case TipoMotor.Pgsql:
                    {
                        var cm = new NpgsqlConnectionStringBuilder()
                        {
                            Host = this.ServerName,
                            Password = this.Password,
                            Database = dbname ?? "postgres",
                            Port = this.Port,
                            Username = this.User,
                            Pooling = false
                        };

                        return new NpgsqlConnection(cm.ConnectionString);
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tm), tm, null);
            }
        }

        public async Task<List<DbInfo>> ObtenerDatabases(TipoMotor tm)
        {
            try
            {
                using (var cnx = ObtenerConexion(tm))
                {
                    var q = tm == TipoMotor.Pgsql
                        ? "SELECT datname as \"DbName\" FROM pg_database WHERE datistemplate = false and datname <> 'postgres';"
                        : "SELECT name as DbName FROM master.dbo.sysdatabases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";

                    var data = await cnx.QueryAsync<DbInfo>(q);

                    return data.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}