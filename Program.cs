using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03_Condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            string snome;
            string end;
            string bair;
            string cid;
            string es;

            int viagens_ap;
            int viagens_planejadas;
            

            Console.WriteLine("\nBem-Vindo ao sistema de clientes de Conrado Fring! \n");
            Console.WriteLine("\nPor favor, digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nAgora, digite seu sobrenome: ");
            snome = Console.ReadLine();

            Console.WriteLine($"\nOlá, Sr(a). {nome} {snome}, vamos continuar com seu cadastro...");
            Console.WriteLine("\nDigite seu endereço: ");
            end = Console.ReadLine();

            Console.WriteLine("\nDigite seu bairro: ");
            bair = Console.ReadLine();

            Console.WriteLine("\nDigite sua cidade: ");
            cid = Console.ReadLine();

            Console.WriteLine("\nDigite seu Estado: ");
            es = Console.ReadLine();

            Console.WriteLine($"\nO Sr(a). {snome} mora na cidade de {cid}-{es}, no endereço {end}, localizado no bairro {bair}. ");
            Console.WriteLine("\nPor favor, informe o número de viagens realizadas no ano passado: ");
            viagens_ap = int.Parse( Console.ReadLine() );

            Console.WriteLine("\nPor favor, informe o número de viagens planejadas para este ano: ");
            viagens_planejadas = int.Parse( Console.ReadLine() );
            
            //variaveis 2
            int m_viagens = viagens_ap + viagens_planejadas / 2;
            int viagens_10 = 10 - (viagens_ap + viagens_planejadas);
            int viagem_t = viagens_planejadas + viagens_ap;

            Console.WriteLine($"\n\nVocê possui um total de {viagem_t} viagens feitas!");
            Console.WriteLine($"\n\nPara você completar 10 viagens feitas, faltam {viagens_10}. ");
            Console.WriteLine($"\n\nEntre os anos passado e atual, você fez uma média de {m_viagens} viagens.");
            Console.WriteLine($"\n\nSeu intervalo entre cada viagem deste ano é de {12 / viagens_planejadas} meses para cada viagem.");
            Console.WriteLine($"\n\nObrigado {nome} {snome}, seu cadastro foi realizado com sucesso! ");

            //Etapa 2

            string cupom;
            string geralt;


            Console.WriteLine("\nDigite seu Cupom de desconto: ");
            cupom = Console.ReadLine();
            if (cupom == "Conradito10" )
            {

                Console.WriteLine("\nParabéns, sua próxima viagem terá 10% de desconto!");

            }
            else
            {
                Console.WriteLine("\nEste cupom não existe ou já foi utilizado.");
            }

            Console.WriteLine($"\nVocê gostaria de receber promoções em seu e-mail?, digite SIM ou NÃO");
            geralt = Console.ReadLine();
            if (geralt == "SIM")
            {

                Console.WriteLine($"\nObrigado por se registrar {nome}, você receberá novos e-mails em breve.");

            }

            else
            {
                Console.WriteLine("\nOk, não enviaremos e-mails promocionais.");
            }

            Console.WriteLine("\n\nObrigado e volte sempre!");
            Console.ReadKey();
        }
    }
}
