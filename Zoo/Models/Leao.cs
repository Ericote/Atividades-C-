using System;
using System.Collections.Generic;

namespace Models
{
    public class Leao : Animal
    {
        // Static quando pertence a propria classe (Tipo o List, vai ter somente um para todos Leoes)
        public static List<Leao> Leoes = new List<Leao>();
        public int Visita { get; set; }
        public int Alimento { get; set; }
        
        public Leao(int IdAnimal,
                    string NomeAnimal, 
                    int Visita, 
                    int Alimento) : 
                    base(IdAnimal, NomeAnimal)
        {
            this.Visita = Visita;
            this.Alimento = Alimento;

            Leoes.Add(this);
        }

        public override string ToString()
        {
        return "\n ============================ " +
               "\n Id: " + base.IdAnimal +
			   "\n Nome: " + base.NomeAnimal +
			   "\n Visitantes: " + Visita +
			   "\n Tempo de Alimentação: " + Alimento +
               "\n ============================ ";
        }
    }
}