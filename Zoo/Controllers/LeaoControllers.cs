using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class LeaoControllers
    {
        public static void UpdateLeao(int Id, string Nome, int Visita, int Alimento)
        {
            Leao leao;
            leao = Leao.Leoes.Find(leao => leao.IdAnimal == Id);  
            if (leao == null) 
            {
                throw new Exception($"Leão não encontrado.");
            }
            if (!String.IsNullOrEmpty(Nome)) 
            {
                    leao.NomeAnimal = Nome;
            }
            if (Alimento > 0) 
            {
                leao.Alimento = Alimento;
            }
                leao.Visita = Visita;  
        }

        public static void InsertLeao(int Id, string Nome, int Visita, int Alimento)
        {
            new Leao(Id, Nome, Visita, Alimento);
        }

        public static void DeleteLeao(int Id)
        {
            Console.WriteLine("\n Informe o id: ");
			try
            {
			    Leao.Leoes.RemoveAt(Id);
                Console.WriteLine("\n Leão deletado! ");
            }
            catch(Exception)
            {
                Console.WriteLine("Leão não foi deletado!");
            }
        }

        public static void SelectLeao()
        {
            foreach(object it in Leao.Leoes)
			{
				Console.WriteLine(it);
			}
        }

        public static void SelectLeaoEspec(int Id)
        {
            IEnumerable<Leao> foo = from Leao in Leao.Leoes where Leao.IdAnimal == Id select Leao;
            Leao leao = Leao.Leoes.Find(leao => leao.IdAnimal == Id);

            Leao.Leoes.Where(leao => leao.IdAnimal == Id).First();

            foreach(Leao Leoes in foo)
            {
                Console.WriteLine(Leoes.ToString());
            }

            if (leao == null) 
            {
                throw new Exception($"Leão não encontrado.");
            }
        }

    }
}
