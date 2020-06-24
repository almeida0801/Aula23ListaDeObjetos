using System;
using System.Collections.Generic; //Para uso de listas


namespace Aula23ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de uma nova lista do tipo "Produto"
            List<Produto> produtos = new List<Produto>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("---ELETRODOMESTICOS---");
            System.Console.WriteLine("");

            // Criação de um produto através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTV LG";
            produto1.Preco = 3999.99f;

            // Adicionar o produro criado na lista

            produtos.Add(produto1);

            //Adicionamos mais produtos utilizando o novo construtor
            produtos.Add( new Produto(2, "Geladeira Eletrolux", 6800.90f));
            produtos.Add( new Produto(3, "Microondas", 499.90f));
            produtos.Add( new Produto(4, "Liquidificador", 89.90f));
            produtos.Add( new Produto(5, "Máquina de lavar LG", 699.90f));
            produtos.Add( new Produto(6, "Fogão", 1299.90f));
           

            //Varremos a lista com FOREACH
            foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {item.Nome} - R$ {item.Preco} ");
                Console.ResetColor();
            }

            //Remover item passando o objeto como argumento
            produtos.Remove(produto1);

            //Remover item pelo índice
            produtos.RemoveAt(2);

             foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {item.Nome} - R$ {item.Preco} ");
                Console.ResetColor();
            }

            //Usar expressão lambda para eliminar (RemoveAll) ou achar (Find) um registro

            Produto Microondas = produtos.Find( x => x.Codigo == 3);
            Console.WriteLine ("Microondas - R$"+Microondas.Preco);

             //LISTA DE CARTÃO

            List<Cartao> cartoes = new List<Cartao>();
            System.Console.WriteLine("");
            System.Console.WriteLine("--Informações de cartão--");
            System.Console.WriteLine("");
            // Criação de um produto através do construtor padrão
            Cartao cartao1 = new Cartao();
            cartao1.Titular = "Paulo Brandão";
            cartao1.numero = 4598556;
            cartao1.bandeira = "Visa";
            cartao1.cvv = 656;

            Console.WriteLine("");
            // Adicionar o produro criado na lista

            cartoes.Add(cartao1);

            //Adicionamos mais produtos utilizando o novo construtor
            cartoes.Add( new Cartao("Leroy Sané", 8674937, "MasterCard", 896));
            cartoes.Add( new Cartao("Chico Buarque", 8167595, "Elo", 969));
            cartoes.Add( new Cartao("Caetano Veloso", 5955236, "Hipercard", 014));
            cartoes.Add( new Cartao("Milton Nascimento", 895456, "American Express", 213));
            cartoes.Add( new Cartao("Dries Mertens", 3052556, "Sodexo", 786));
           

            //Varremos a lista com FOREACH
            foreach (Cartao item in cartoes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine($" Titular: {item.Titular} ");
                Console.WriteLine($" Numero: {item.numero} ");
                Console.WriteLine($" Bandeira: {item.bandeira} ");
                Console.ResetColor();
            }


        }
    }
}
