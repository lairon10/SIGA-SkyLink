using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SIGASKY
{
	public static class MainClass
	{
		public static string connectionString =
			"Server='localhost';" +
			"Database='Skylink';" +
			"User ID='sga-sky';" +
			"Password='123';" +
			"Pooling=false"; 
		public static void Main (string[] args){

			Console.WriteLine("SGA - SKYLINK");

			Console.Write("MENU: \n1.Cadastro de Aluno \n2.Mostrar Alunos\n--->>");
			int opt = Char.Parse(Console.ReadLine());
			switch (opt)
			{
			case '1':
				Console.WriteLine ("Preencha o Formualario Abaixo: ");
				Console.Write ("Nome do Aluno:");
				string nomeAl = Console.ReadLine ();
				Console.Write ("\nData de Nascimento:");
				string dataNasc = Console.ReadLine ();
				Console.Write ("\nCPF (000.000.000-00):");
				string CPF = Console.ReadLine ();
				Console.Write ("RG:");
				string reg = Console.ReadLine ();
				Console.Write ("Sexo (M ou F):");
				string sex = Console.ReadLine ();
				Console.Write ("Estado Civil:");
				string estCv = Console.ReadLine ();

				CadastroAluno cadAlNovo = new CadastroAluno ();
				cadAlNovo.cadAluno (nomeAl, dataNasc, CPF, reg, sex, estCv, null, null, null, null);
				break;
			case '2':
				ConsultaAlunos consultarAl = new ConsultaAlunos ();
				consultarAl.consAlunos();
				break;
			default:
				break;
			}

			/*
			Console.Write("Cadastro de Aluno");
			string pnome = Console.ReadLine();
			string unome = Console.ReadLine();

			InserirDados inserir = new InserirDados();
			inserir.gravar(pnome, unome);


			LerTabela ler = new LerTabela();
			ler.lerDados();
			*/
		}
	}
}