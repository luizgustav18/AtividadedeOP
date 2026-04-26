using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadedePO05
{
    public class hopedes
    {
        public string nome;
        public int cpf;
        public int telefone;

        public void Receberdados()
        {
                Console.Write("Digite o nome do cliente: ");
                nome = Console.ReadLine();
    
                Console.Write("Digite o CPF do cliente: ");
                cpf = int.Parse(Console.ReadLine());
    
                Console.Write("Digite o telefone do cliente: ");
                telefone = int.Parse(Console.ReadLine());
            Console.WriteLine( );

        }
        public void exibirdados()
        {
            Console.WriteLine("\n--- Dados do hospedes ---");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Telefone: " + telefone);
        }

    }

}
