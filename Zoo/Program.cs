using System;
using System.Collections.Generic;
using Models;
using Controllers;
using Views;

namespace Menu
{
	public class Program
	{
		public static void Main()
		{
			string Nome = "";
			int Id = 0;
			int Alimento = 0;
			int Visita = 0;
			int Opt = 0;
			do 
			{
				Console.WriteLine("|-------------------|");
				Console.WriteLine("| 	    MENU       |");
				Console.WriteLine("|-------------------|");
				Console.WriteLine("|   [1] - Insert    |");
				Console.WriteLine("|   [2] - Delete    |");
				Console.WriteLine("|   [3] - Update    |");
				Console.WriteLine("|   [4] - Select    |");
				Console.WriteLine("|   [5] - Select Id |");
				Console.WriteLine("|   [6] - Sair 	   |");
				Console.WriteLine("|-------------------|");
				Console.WriteLine("\n Escolha uma opção: ");
				try
				{
				Opt = Convert.ToInt32(Console.ReadLine());
				}
				catch(Exception)
				{
					Console.WriteLine("\n Escolha inválida! Informe um dos númericos de 1 á 6");
				}
				
				switch(Opt)
				{
					case 1:
					// ==================== CADASTRAR LEÃO =======================
						try
						{
							LeaoViews.InsertLeaoView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n ERRO! Não foi possivel cadastrar o Leão! ");
						}
						break;
					case 2:
					// ================== DELETAR LEAO ======================
						try
						{
							LeaoViews.DeleteLeaoView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n ERRO! Não foi possivel deletar o Leão!");
						}
						break;
					case 3:
					// ========================= Atualizar Leão =======================
						try
						{
							LeaoViews.UpdateLeaoView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n ERRO! Não foi possivel atualizar o Leão!");
						}
						break;

					case 4:
					// ====================== SELECIONAR TODOS LEÕES ==========================
						try
						{
							LeaoViews.SelectAllLeaoView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n ERRO! Não foi possivel selecionar os Leões!");
						}
						break;
					case 5:
					// =========================== SELECT UM LEAO ==========================
						try
						{
							LeaoViews.SelectOneLeaoView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n ERRO! Não foi possivel selecionar o Leão!");
						}
						break;
					default:
						Console.WriteLine("\n Tchau Tchau, Obrigado por usar o programa!");
						break;
				}
			} 
			while(Opt != 6);
		}
	}
}