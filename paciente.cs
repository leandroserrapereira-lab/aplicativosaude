using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{

    public class paciente()
    {
        public string nome;
        public int idadepaciente;
        public int niveldor;
        public string idadepacientestring;
        List<string> listavermelha = new List<string>();
        List<string> listaamarela = new List<string>();
        List<string> listaverde = new List<string>();
        List<string> listapaciente = new List<string>();
        int contam;
        int contvd;
        int i;
        int contver;




        // métodos(ações que pertence a minha classe)
        // adcionar paciente

        public void Adicionarpaciente()
        {
            Console.WriteLine("informe o nome do paciente");
            nome = Console.ReadLine();
            Console.WriteLine("informe a idada  do paciente");
            idadepacientestring = Console.ReadLine();

            if (int.TryParse(idadepacientestring, out idadepaciente))
            {
                Console.WriteLine("digite o nível de  dor  do paciente");
                if (int.TryParse(Console.ReadLine(), out niveldor))
                {
                    ClassificarPrioridade(nome, idadepaciente, niveldor);
                }
            }
        }

        public void ClassificarPrioridade(string nomepaciente, int idade, int niveldor)
        {
            if (niveldor >= 9 || idadepaciente >= 80)

            {

                Console.WriteLine("prioridade alta");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("prioridade alta - pulseira vermelha");
                listavermelha.Add(nome);
                Console.ResetColor();



            }
            else if (niveldor >= 5)
            {
                Console.WriteLine("prioridade alta");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("prioridade média - pulseira amarela");
                listaamarela.Add(nome);
                Console.ResetColor();



            }
            else
            {

                Console.WriteLine("prioridade alta");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" baixa - pulseira verde");
                listaverde.Add(nome);
                Console.ResetColor();

            }
        }


        public void listarpaciente()




        {
            foreach (var item in listavermelha)
            {
                listapaciente.Add(item);

            } while (contam < listaamarela.Count() || contvd < listaverde.Count())

                while (contam < listaamarela.Count() && i < 2) ;
            {
                listapaciente.Add(listaverde[contvd]);
                contam++;
                i++;
            }
            listapaciente.Add(listaverde[contvd]);

            contvd++;

        }






        public void chamarproximo()
        {
            // saber  o primeiro  da  fila 
            listarpaciente();
            //  listarpaciente[0] localização  do próximo  paciente ;
            // mostrar na  tela  quem  é  sr fulano  dirigi-se  ao consultório 
            // remover paciente
        }

        public void excluipaciente()
        {
            // remove da listapacietes
            listapaciente.RemoveAt(0);
            // MOSTRAR A  LISTA   DE  PRIORIDADES  ; PRECISO  ENCONTRAR  EM  QUAL LISTA   ESTÁ  E  REMOVER
            if (listavermelha.Contains(listapaciente[0]))
            {
                listavermelha.RemoveAt(0);

            }
            else if (listaamarela.Contains(listapaciente[0]))
            {

                listaamarela.RemoveAt(0);

            }
            else
            {
                listaverde.RemoveAt(0);
                  
                 

               













            }
        }
    }
}














