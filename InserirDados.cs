using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

//CLASSE DE TESTE PARA INSERIR DADOS

namespace SIGASKY
{
	public class InserirDados
	{
		private MySqlConnection mConn; // --- VARIAVEL PRA CONECTAR NO BANCO DE DADOS
		//private MySqlDataAdapter mAdapter;  --RETIRAR SE NAO FOR USAR
		//private DataSet mDataset;

		public void gravar(string nome, string sobrenome){
			mConn = new MySqlConnection(MainClass.connectionString);
			mConn.Open();

			MySqlCommand comando = new MySqlCommand("INSERT INTO employee(firstname,lastname)"+
				"VALUES('"+nome+"','"+sobrenome+"')",mConn);
			comando.ExecuteNonQuery();

			comando.Dispose();
			mConn.Close();
		
			MessageBox.Show("Gravado!","Informação",MessageBoxButtons.OK);
		}
	}
}

