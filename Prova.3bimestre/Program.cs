using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha o funcionario que deseja cadastrar: ");
            Console.WriteLine("1 - Funcionario");
            Console.WriteLine("2 - Medico");
            Console.WriteLine("3 - Administrativo");
            Console.WriteLine("4 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            
            if (opcao == 1) 
            {
                Console.Write("Qual o nome? ");
                string nome = Console.ReadLine();

                Console.Write("Qual o cpf? ");
                string cpf = Console.ReadLine();

                Console.Write("Qual a matricula? ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual a data de nascimento? \n");
                DateTime dataN = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Qual o sexo: ");
                string sexo = Console.ReadLine();

                Console.Write("Qual o salario? ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Write($"O nome de seu funcionario é {nome}\nO seu cpf é {cpf}\nSua matricula é {matricula}\nSua data de nascimento é {dataN}\nO seu sexo é {sexo}\nO seu salario é de:{salario}\n\n");
                
            }
            else if(opcao == 2) 
            {
                Console.Write("Qual o nome? ");
                string nome = Console.ReadLine();

                Console.Write("Qual o cpf? ");
                string cpf = Console.ReadLine();

                Console.Write("Qual a matricula? ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual a data de nascimento? ");
                DateTime dataN = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Qual o sexo? ");
                string sexo = Console.ReadLine();

                Console.Write("Qual o salario? ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Possui registro no conselho(CRM)? ");
                string crm = Console.ReadLine();

                Console.Write("Qual o valor da hora extra?");
                double horaExtra = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual a especialidade?");
                string especialidade = Console.ReadLine();

                double salarioTotal = (salario * 0.2) + salario;
                Console.Write($"O nome de seu medico é {nome}\nO seu cpf é {cpf}\nSua matricula é {matricula}\nSua data de nascimento é {dataN}\nO seu sexo é {sexo}\nO seu salrio {salario}\nO valor de sua hora extra é de {horaExtra}\nSua especialidade é {especialidade}\nE o seu salario total é de {salarioTotal}\n\n");
            }
            else if(opcao == 3) 
            {

                Console.Write("Qual o nome? ");
                string nome = Console.ReadLine();

                Console.Write("Qual o cpf? ");
                string cpf = Console.ReadLine();

                Console.Write("Qual a matricula? ");
                int matricula = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual a data de nascimento? \n");
                DateTime dataN = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Qual o sexo: ");
                string sexo = Console.ReadLine();

                Console.Write("Qual o salario? ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual a sua funcão? ");
                string funcao = Console.ReadLine();

                double salarioTotal = (salario * 0.15) + salario + 150;
                Console.Write($"O nome de seu funcionario é {nome}\nO seu cpf é {cpf}\nSua matricula é {matricula}\nSua data de nascimento é {dataN}\nO seu sexo é {sexo}\nO seu salario total é {salarioTotal}\n\n");
            }
            else if(opcao == 4) 
            {
                break;
            }
        }
    }
}
