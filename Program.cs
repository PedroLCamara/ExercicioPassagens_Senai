using System;

namespace DesafioPassagens
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            bool voltar = false;
            string[] nome = new string[5];
            string[] origem = new string[nome.Length];
            string[] destino = new string[nome.Length];
            string[] data = new string[nome.Length];
            string senha;
            int contador = 0;
            int senha_errada = 0;
            do
            {
                Console.WriteLine("Seja bem vindo ao portal do passageiro da Viajante Viagens, por favor, insira a senha:");
                senha = Console.ReadLine();
                Console.WriteLine();
                if (senha != "123456")
                {
                    senha_errada = senha_errada + 1;
                    Console.WriteLine($"Senha incorreta, acesso negado. Chance {senha_errada} de 3");
                    Console.WriteLine();
                }
                else
                {
                    do
                    {
                        voltar = false;
                        Console.WriteLine($@"Seja bem-vindo usuário001, o que deseja fazer hoje?
* Cadastrar passagens
* Listar passagens
* Sair");
                        string menu = Console.ReadLine().ToUpper().Substring(0, 1);
                        Console.WriteLine();
                        do
                        {
                            switch (menu)
                            {
                                case "C":
                                    Console.WriteLine($@"Bem vindo ao cadastro de passagens. Deseja prosseguir ou voltar ao início?
* Prosseguir (O limite de passagens é igual a cinco. Você possui {contador} passagens)
* Voltar");
                                    string prosseguir = Console.ReadLine().ToUpper().Substring(0, 1);
                                    Console.WriteLine();
                                    if (prosseguir == "P" && contador == 5 || prosseguir == "C" && contador == 5)
                                    {
                                        Console.WriteLine("Limite de passagens registradas atingido, voltando ao início...");
                                        Console.WriteLine();
                                        voltar = true;
                                    }
                                    else if (prosseguir == "P" && contador < 5 || prosseguir == "C" && contador < 5)
                                    {
                                        for (var i = contador; i == contador;)
                                        {
                                            contador = contador + 1;
                                            Console.WriteLine("Certo, primeiro será preciso coletar as informações necessárias para a emissão da passagem.");
                                            Console.WriteLine();
                                            Console.WriteLine("Digite o nome do passageiro");
                                            nome[i] = Console.ReadLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Digite o local de origem do voo");
                                            origem[i] = Console.ReadLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Digite o local de destino do voo");
                                            destino[i] = Console.ReadLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Digite a data do voo");
                                            data[i] = Console.ReadLine();
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                    else if (prosseguir == "V" || prosseguir == "S")
                                    {
                                        Console.WriteLine("Entendido, voltando ao início...");
                                        voltar = true;
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro 002, digite 'prosseguir' para prosseguir ou 'voltar' para voltar");
                                    }
                                    break;
                                case "L":
                                    if (contador >= 1)
                                    {
                                        Console.WriteLine("Suas passagens atuais são:");
                                        Console.WriteLine();
                                        Console.WriteLine($@"
                                ============================================================
                                |      Nome    |    Origem    |     Destino   |    Data    |");
                                        for (var i = 0; i < contador; i++)
                                        {
                                            Console.WriteLine($@"
                                ============================================================
                                |      {nome[i]}    |    {origem[i]}    |     {destino[i]}   |    {data[i]}    |");
                                        }
                                        voltar = true;
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sem passagens registradas...");
                                        voltar = true;
                                        Console.WriteLine();
                                    }
                                    break;
                                case "S":
                                    Console.WriteLine(@"Tem certeza?
*Sim
*Não");
                                    string certeza = Console.ReadLine().ToUpper().Substring(0, 1);
                                    if (certeza == "S")
                                    {
                                        Console.WriteLine("Tudo bem, finalizando o sitema...");
                                        voltar = true;
                                        sair = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Certo, voltando ao início...");
                                        voltar = true;
                                        Console.WriteLine();
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Erro 001: Digite 'Cadastrar passagens' para cadastar uma passagem, 'Listar passagens' para listar uma passagem e 'sair' para finalizar o sistema.");
                                    Console.WriteLine();
                                    voltar = true;
                                    break;
                            }
                        } while (voltar == false);
                    } while (sair == false);
                }
            } while (senha != "123456" && senha_errada < 3);
        }
    }
}