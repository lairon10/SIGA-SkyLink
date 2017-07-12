using System;
using System.Data;
using MySql.Data.MySqlClient;

// CLASSE DE TESTE PARA LER TABELAS

namespace SIGASKY
{
	public class LerTabela
	{
		public void lerDados()
		{
			IDbConnection dbcon;
			dbcon = new MySqlConnection(MainClass.connectionString);
			dbcon.Open();
			IDbCommand dbcmd = dbcon.CreateCommand();
			// requires a table to be created named employee
			// with columns firstname and lastname
			// such as,
			//        CREATE TABLE employee (
			//           firstname varchar(32),
			//           lastname varchar(32));
			string sql =
				"SELECT firstname, lastname " +
				"FROM employee";

			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			while(reader.Read()) {
				string FirstName = (string) reader["firstname"];
				string LastName = (string) reader["lastname"];
				Console.WriteLine("Name: " +
					FirstName + " " + LastName);
			}
			// clean up
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			dbcon.Close();
			dbcon = null;
		}
	}
}

