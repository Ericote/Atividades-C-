using System;

namespace Models
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public string NomeAnimal { get; set; }
        
        public Animal(int IdAnimal, string NomeAnimal)
        {
            this.IdAnimal = IdAnimal;
            this.NomeAnimal = NomeAnimal;
        }

        public override string ToString()
        {
        return "\n ============================ " +
               "\n Id: " + IdAnimal +
			   "\n Nome: " + NomeAnimal +
               "\n ============================ ";
        }
    }
}