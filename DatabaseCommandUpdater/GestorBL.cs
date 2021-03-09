using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DatabaseCommandUpdater
{
    public class GestorBL
    {
        private readonly TipoMotor _tm;

        public GestorBL(TipoMotor tm)
        {
            _tm = tm;
        }

        public async Task CompletarComandos(ConexionData data, string dbname, List<string> query)
        {
            try
            {
                using (var cnx = data.ObtenerConexion(_tm, dbname))
                {
                    if (cnx.State != ConnectionState.Open) await cnx.OpenAsync();
                    var t = cnx.BeginTransaction();

                    try
                    {
                        foreach (var q in query)
                        {
                            await cnx.ExecuteAsync(q, transaction: t);
                        }

                        t.Commit();
                    }
                    catch (Exception ee)
                    {
                        t.Rollback();
                        throw ee;
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
    }
}
