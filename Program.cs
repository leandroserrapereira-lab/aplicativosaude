using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace desafio1;

public class Program()

{


    public static void Main(string[] args)

    {
        int opcao;
        string resposta="s";

        paciente pacienteatendiemnto = new paciente();
        Console.ResetColor();
        Console.WriteLine("healthconnct");
        do
        {
            Console.WriteLine("menu");
            Console.WriteLine("1 - adicionar paciente \n 2 - ver fila atual \n 3 - chamar o próximo \n 4  -sair");
            Console.WriteLine("digite a opção desejada");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:

                        pacienteatendiemnto.Adicionarpaciente();
                        break;
                    case 2:
                        pacienteatendiemnto.listarpaciente();
                        break;
                    case 3:
                        pacienteatendiemnto.chamarproximo();
                        break;
                    case 4:
                        resposta = "n";
                        Console.WriteLine("programa finalizado");
                        break;
                    default:
                        Console.WriteLine("opção incorreta. digite um número entre 1  e 4");
                        break;
                }
            }
            else
            {
                Console.WriteLine("opção incorreta. digite um número");
            }

        } while (resposta == "s");
    }
    }
        
        



                
                
            
       


        


        



    






















    











