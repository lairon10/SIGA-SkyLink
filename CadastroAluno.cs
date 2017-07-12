using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SIGASKY
{
	public class CadastroAluno
	{
		private MySqlConnection connDb;

		//private string nomeAluno, dataNc, cpf, rg, sx, estCivil, nPai, nMae, endrco, cidade;

		public void cadAluno(string nomeAluno, string dataNc,string cpf,string rg ,string sx,string estCivil,string nPai,string nMae,string endrco,string cidade){
			connDb = new MySqlConnection(MainClass.connectionString);
			connDb.Open();

			MySqlCommand commInsert = new MySqlCommand("INSERT INTO Alunos(Nome,DataNc,Cpf,Rg,Sexo,EstCivil,NPai,NMae,Endereco,Cidade)"+
				"VALUES('"+nomeAluno+"','"+dataNc+"','"+cpf+"','"+rg+"','"+sx+"','"+estCivil+"','"+nPai+"','"+nMae+"','"+endrco+"','"+cidade+"')",connDb);
			commInsert.ExecuteNonQuery();
			commInsert.Dispose();
			connDb.Close();

			MessageBox.Show("Informações Armazenadas!","Informação",MessageBoxButtons.OK);
		}
	}
}

