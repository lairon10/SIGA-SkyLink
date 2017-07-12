using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SIGASKY
{
	public class ConsultaAlunos
	{
		public void consAlunos()
		{
			IDbConnection dbConnect;
			dbConnect = new MySqlConnection (MainClass.connectionString);
			dbConnect.Open();
			IDbCommand cmdDb = dbConnect.CreateCommand();

			string lerSql = "SELECT Nome, DataNc, Cpf, Rg " + "FROM Alunos";

			cmdDb.CommandText = lerSql;

			Console.WriteLine("|==============ALUNOS CADASTRADOS=================|");
			IDataReader leitor = cmdDb.ExecuteReader();
			while (leitor.Read()) {
				//int idd = (int)leitor ["ID"];
				string nomeAluno = (string) leitor["Nome"];
				string dNc = (string) leitor["DataNc"];
				string lCpf = (string) leitor["Cpf"];
				string lRg = (string) leitor["Rg"];

				Console.WriteLine("|Nome: "+nomeAluno+" | Nascimento: "+dNc+"| CPF: "+lCpf+" | RG: "+lRg);
			}

			leitor.Close();
			leitor = null;
			dbConnect.Close();
			dbConnect = null;
			cmdDb.Dispose();
			cmdDb = null;
		}
	}
}

