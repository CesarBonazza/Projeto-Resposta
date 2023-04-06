using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaData
{
    public class RepositorioAmigos
    {
        Amigo_dataArquivo amigo_DataArquivo = new Amigo_dataArquivo();
        public void Adicionar(Amigo amigo)
        {
            amigo_DataArquivo.escreverArq(amigo);
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Amigo adicionado com sucesso!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pressione qualquer TECLA, para continuar.");
            Console.ReadKey();
        }
        public void Remover(Amigo amigo)
        {
            amigo_DataArquivo.removerRegistro(amigo);
        }
        public void Listar()
        {
            var lstAmigos = amigo_DataArquivo.lerRegistro();
            Console.WriteLine("Segue uma lista completa de " + lstAmigos.Count + " amigos");
            foreach (var amg in lstAmigos)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(amg.Nome);
                Console.WriteLine(amg.Sobrenome);
                Console.WriteLine(amg.dataAniversario.ToString("dd/MM/yyyy"));
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("Pressione qualquer TECLA, para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
        public void Pesquisar(Amigo amigo)
        {
            foreach (var amg in amigo_DataArquivo.lerRegistro())
            {
                if (amigo.Nome == amg.Nome || amigo.Sobrenome == amg.Sobrenome)
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Nome: " + amg.Nome);
                    Console.WriteLine("Sobrenome: " + amg.Sobrenome);
                    Console.WriteLine("Data de Nascimento: " + amg.dataAniversario.ToString("dd/MM/yyyy"));
                    DateTime dateTime = DateTime.Now;
                    int anoNiver = dateTime.Year - amg.dataAniversario.Year;
                    DateTime proximoNiver = amg.dataAniversario.AddYears(anoNiver + 1);
                    TimeSpan diasRestantes = proximoNiver - dateTime;
                    Console.WriteLine("Faltam exatamente "
                        + diasRestantes.Days +
                        " dias, " +
                        diasRestantes.Hours +
                        " horas e " +
                        diasRestantes.Minutes +
                        " minutos para o próximo aniversário de " +
                        amg.Nome);
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            Console.WriteLine("Pressione qualquer TECLA, para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
        public void amigoDataAtual()
        {
            var dataAtual = DateTime.Today.ToString("dd/MM");
            if (File.Exists(@"C:\\Program Files\Registro_de_Amigos.txt"))
            {
                foreach (var amg in amigo_DataArquivo.lerRegistro())
                {
                    if (amg.dataAniversario.ToString("dd/MM") == dataAtual)
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Veja os aniversariantes que temos para hoje - dia " + dataAtual);
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Nome: " + amg.Nome);
                        Console.WriteLine("Sobrenome: " + amg.Sobrenome);
                        Console.WriteLine("Data de Nascimento: " + amg.dataAniversario.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }
    }
}
