using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    public class Conta
    {
        string numeroDaConta;
        string donoDaConta;
        double saldoDaConta = 100;
        double limiteDaConta;


        public void Menu()
        {
            int op, quantUsers, opUser;
            double depos;
            const int SAIR = 0;
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();

            Console.WriteLine("\t\t-+-+-+Bem vindo ao banco de dados dos funcionários do Banco Santander!-+-+-+");



            // Quantidade de users desejados
            Console.WriteLine("Quanto usuários deseja cadastrar: ");
            Console.WriteLine("(1) Usuário\n(2) Usuários");
            quantUsers = int.Parse(Console.ReadLine());


            // Recebendo dados da quantidade de user desejados 
            if (quantUsers == 1)
            {
                Console.WriteLine("Digite os dados do primeiro usuário: ");
                conta1.ReceberDados();
            }
            else if (quantUsers == 2)
            {
                Console.WriteLine("Digite os dados do primeiro usuário: ");
                conta1.ReceberDados();
                Console.WriteLine("\nDigite os dados do Segundo usuário: ");
                conta2.ReceberDados();
            }
            else
            {
                Console.WriteLine("Opcao inválida!");
            }


            // Menu Main
            do
            {
                Console.WriteLine("Menu Santander");
                if (quantUsers == 1)
                {
                    Console.WriteLine("(0) - SAIR DO APP");
                    Console.WriteLine("(1) - USER 01");
                    Console.Write("\nOpção Desejada: ");
                    opUser = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("(0) - SAIR DO APP");
                    Console.WriteLine("(1) - USER 01");
                    Console.WriteLine("(2) - USER 02");
                    Console.Write("\nOpção Desejada: ");
                    opUser = int.Parse(Console.ReadLine());

                }

                switch (opUser)
                {
                    // Case sair do app
                    case 0:
                        Console.WriteLine("Aplicativo sendo fechado... Volte sempre!");
                        break;

                    // Usuário 1
                    case 1:

                        do
                        {

                            Console.WriteLine("\nMENU DO CLIENTE: ");
                            Console.WriteLine("(0) - SAIR DO USER");
                            Console.WriteLine("(1) - ACESSAR DADOS DA CONTA");
                            Console.WriteLine("(2) - DEPOSITAR");
                            Console.Write("\nOpção Desejada: ");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {
                                case SAIR:
                                    Console.WriteLine("Obrigado por user o Banco Santander, volte sempre!");
                                    break;
                                case 1:
                                    conta1.ImprimirDados();
                                    break;
                                case 2:
                                    Console.Write("Digite a quantidade que deseja depositar: ");
                                    depos = double.Parse(Console.ReadLine());
                                    conta1.Depositar(depos);
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (op != SAIR); // Saindo do User 1

                        break;


                    // Usuário 2
                    case 2:

                        do
                        {

                            Console.WriteLine("\nMENU DO CLIENTE: ");
                            Console.WriteLine("(0) - SAIR DO USER");
                            Console.WriteLine("(1) - ACESSAR DADOS DA CONTA");
                            Console.WriteLine("(2) - DEPOSITAR");
                            Console.Write("\nOpção Desejada: ");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {
                                case 0:
                                    Console.WriteLine("Obrigado por user o Banco Santander, volte sempre!");
                                    break;
                                case 1:
                                    conta2.ImprimirDados();
                                    break;
                                case 2:
                                    Console.Write("Digite a quantidade que deseja depositar: ");
                                    depos = double.Parse(Console.ReadLine());
                                    conta2.Depositar(depos);
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }

                        } while (op != SAIR); // Saindo do User 2

                        break;

                    // Caso opção de usuário seja inválida
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                // Sair do laço maior
            } while (opUser != SAIR);
        }
        

        public void ReceberDados()
        {
            Console.Write("Nome: ");
            this.donoDaConta = Console.ReadLine();
            Console.Write("Id da conta: ");
            this.numeroDaConta = Console.ReadLine();
            Console.Write("Saldo: ");
            this.saldoDaConta = double.Parse(Console.ReadLine());
            Console.Write("Limite: ");
            this.limiteDaConta = double.Parse(Console.ReadLine());
            Console.WriteLine("\n" +
                "-----------------------------------" +
                "| Cliente cadastrado com sucesso! |" +
                "-----------------------------------");

        }
        
        public void ImprimirDados()
        {
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("Id....: " + numeroDaConta);
            Console.WriteLine("Saldo.: " + saldoDaConta);
            Console.WriteLine("Limite: " + limiteDaConta);
            Console.WriteLine("+---------------------------------+");
        }
        public void Depositar(double quantidade)
        {
            double deposito = quantidade;
            this.saldoDaConta = saldoDaConta + deposito;
            Console.WriteLine("\n\n" +
                "-----------------------------------" +
                "| Depósito realizado com sucesso! |" +
                "-----------------------------------");
        }
    }
}
