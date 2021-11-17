
/*
Código retirado de https://social.msdn.microsoft.com/Forums/pt-BR/856aa46d-9ff9-444c-a51d-527f61f834aa/lista-encadeada-em-console-aplication?forum=vscsharppt Incluso aqui somente 
para fins de armazenamento e apresentação.

*/

using System;
using System.Collections.Generic;

namespace TrabalhoLp{

public class Pessoa
    {
        public Pessoa() {}

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            this.Idade = idade;
            this.Nome = nome;
        }
    }


class Program
    {
        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(50, "Macoratti"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            Console.ReadKey();



     
}
    }
}
