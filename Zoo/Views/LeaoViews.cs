using System;
using Controllers;

namespace Views
{
    public class LeaoViews
    {
        
        public static void UpdateLeaoView()
        {
            string Nome = "";
			int Id = 0;
			int Alimento = 0;
			int Visita = 0;
         	Console.WriteLine("\n Atualizar Leão");
			Console.WriteLine("\n Informe o Id do Leão");
			try
			{
				Id = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Id inválido");
			}
			Console.WriteLine("\n Informe o nome: ");
			try
			{
				Nome = Console.ReadLine();
			}
			catch(Exception)
			{
				Console.WriteLine("\n Nome inválido!");
			}
			
			Console.WriteLine("\n Informe a quantidade de visita: ");
			try
			{
				Visita = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Visita inválida!");
			}
			
			Console.WriteLine("\n Informe a quantidade de Alimento: ");
			try
			{
				Alimento = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Quantidade de Alimento inválido!");
			}
            try
			{
				LeaoControllers.UpdateLeao(Id, Nome, Visita, Alimento);
			}
			catch(Exception)
			{
				Console.WriteLine("\n Erro no metodo para atualizar Leão");
			}
        }

        public static void DeleteLeaoView()
        {
            int Id = 0;
			Console.WriteLine("\n Informe o id: ");
			try
			{
				Id = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n O Id informado é inválido!");
			}
			try
			{
				LeaoControllers.DeleteLeao(Id);
			}
			catch(Exception)
			{
				Console.WriteLine("\n ERRO! Não foi possivel deletar o leão! ");
			}
        }

        public static void SelectAllLeaoView()
        {
            Console.WriteLine("\n Selecionar todos Leões");
            try
			{
				LeaoControllers.SelectLeao();
			}
			catch(Exception)
			{
				Console.WriteLine("\n ERRO! Não foi possivel selecionar os leões! ");
			}
        }

        public static void SelectOneLeaoView()
        {
            int Id = 0;
            Console.WriteLine("\n Selecionar Leão Especifico");
			Console.WriteLine("\n Informe o Id: ");
			try
			{
				Id = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Id inválido!");
			}
            try
			{
				LeaoControllers.SelectLeaoEspec(Id);
			}
			catch(Exception)
			{
				Console.WriteLine("\n Erro no metodo para selecionar Leão especifico");
			}
        }

        public static void InsertLeaoView()
        {
            string Nome = "";
			int Id = 0;
			int Alimento = 0;
			int Visita = 0;
            Console.WriteLine("\n Cadastrar Leão");
			Console.WriteLine("\n Informe o Id: ");
			try
			{
				Id = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Id inválido!");
			}
			Console.WriteLine("\n Informe o nome: ");
			try
			{
				Nome = Console.ReadLine();
			}
			catch(Exception)
			{
				Console.WriteLine("\n Nome inválido!");
			}
			
			Console.WriteLine("\n Informe a quantidade de visita: ");
			try
			{
				Visita = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Visita inválida!");
			}
			
			Console.WriteLine("\n Informe a quantidade de alimento: ");
			try
			{
				Alimento = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Quantidade de Alimento inválido!");
			}
			try
			{
				LeaoControllers.InsertLeao(Id, Nome, Visita, Alimento);
			}
			catch(Exception)
			{
				Console.WriteLine("\n ERRO! Não foi possivel cadastrar o leão! ");
			}
        }
    }
}