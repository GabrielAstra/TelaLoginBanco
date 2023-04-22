using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claz.Dominio
{
    public class Usuario
    {
        private string _nome;
        public int Idade { get; set; }
        public string Nome 
        { 
            get => _nome.ToUpper(); 

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
                
            }  
        }

        public double Salario { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"O nome do usuário é {Nome}, a idade é {Idade} e o salario é {Salario}");
        }
    }
}