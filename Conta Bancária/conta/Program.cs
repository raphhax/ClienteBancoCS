using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables and Objects from C#

            /*
            double depos;
            Conta conta = new Conta();
            Conta conta2 = new Conta();
            */

            /*----------------------------------------------------------*/

            /* Testando referências/ponteiros em c#
            
            
            // Primeira conta e seu saldo
            Console.WriteLine("Primeira conta e seu saldo: ");            
            conta.ImprimirDados();

            // Depositando na primeira conta
            Console.Write("\n\nQuantos reais Depositar na primeira: ");
            depos = double.Parse(Console.ReadLine());
            conta.Depositar(depos);           
            conta.ImprimirDados(); // Dados + Depósito

            Console.WriteLine("\nDados iniciais de 2: ");
            // Tem q ter 100
            conta2.ImprimirDados();

            // Conta vai ir para o mesmo lugar de conta
            conta2 = conta;

            // Vendo se agora ela tem os novos dados de c1
            Console.WriteLine("\nDados de 2 depois de associa a user 1: ");
            conta2.ImprimirDados();

            

            // Vendo agora os dados
            Console.WriteLine("\nDados de 1: ");
            conta.ImprimirDados();

            // Adicionando 100 ao 2
            conta2.Depositar(100);

            Console.WriteLine("\nDados de 2 com + 100 reais: ");
            conta2.ImprimirDados();
            
            Console.WriteLine("\nDados de 1: ");
            conta.ImprimirDados();
            */

            /*----------------------------------------------------------*/

            /*TESTE USANDO DUAS CONTAS DE FUNCIONÁRIOS*/

            /*
            Console.WriteLine("Segunda conta: ");
            conta2.ReceberDados();
            conta2.ImprimirDados();
            */
            /*
            Console.WriteLine("Aqui estao as 2 contas: ");
            conta.ImprimirDados();
            conta2.ImprimirDados();
            */

            /*
            // Add quanto quer depositar e passar o valor para o método "Depositar", este irá adicionar o valor a uma variável da class Conta e depois vai imprimir essa variável dela no método "ImprimirDados"
            Console.Write("\n\nQuantos reais Depositar: ");
            depos = double.Parse(Console.ReadLine());
            conta.Depositar(depos);

            // Imprimir novos dados com o depósito realizado anteriormente
            Console.WriteLine("Conta com depósito: ");
            conta.ImprimirDados();
            */


            /*----------------------------------------------------------*/

            // Criando um básico em casa


            // Variáveis, constantes e objetos

            Conta menu = new Conta();

            menu.Menu();


            // ENTER para Fechar programa
            Console.WriteLine("Sucesso na aplicação!");
            Console.ReadLine();
        }
    }
}
