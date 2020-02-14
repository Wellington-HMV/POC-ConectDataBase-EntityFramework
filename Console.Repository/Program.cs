using System.Collections.Generic;
using EntityRepository;
using Repository.DAL.Repositories;

namespace Repository.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adicionar();
        }

        private static void Adicionar()
        {
            using (var repClientes = new ClientRespository())
            {
                new List<Cliente>
                {
                    new Cliente {  Nome="teste01" , Email = "well@well" , CPF = 12312312},
                    new Cliente {  Nome="teste02" , Email = "well@well" , CPF = 12312312},
                    new Cliente {  Nome="teste03" , Email = "well@well" , CPF = 12312312}

                }.ForEach(repClientes.Adicionar);

                repClientes.SalvarTodos();

                System.Console.WriteLine("Clientes adicionadas com sucesso.");

                System.Console.WriteLine("=======  clientes cadastrados ===========");
                foreach (var c in repClientes.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.Id, c.Nome);
                }

                System.Console.ReadKey();
            }
        }
    }
}