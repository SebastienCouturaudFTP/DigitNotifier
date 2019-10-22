using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using Dapper;

namespace TestNotify.Repositories
{
    class ListeFilmsDigitRepository
    {
        public IDbConnection GetConnection()
        {
            var connectionString = Program.ConnexionBDD;
            var conn = new OracleConnection(connectionString);
            return conn;
        }

        const string sqlListeFilm = "select * from film_prevbe where STATUT = 190 AND IDCAMPAGNETYPE = 2 and dateupload > (sysdate - 1)";

        public IEnumerable<FilmPreVBE> GetFilmsDigitList()
        {
            IEnumerable<FilmPreVBE> result = null;
            try
            {
                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    result = conn.Query<FilmPreVBE>(sqlListeFilm);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
