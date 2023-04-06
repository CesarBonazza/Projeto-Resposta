using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BibliotecaData
{
    public class Amigo_dataArquivo
    {
        //--------------------------------------------------------------------------------------
        // Vai pedir permissão de administrador do visual studio... retorna erro se não estiver
        private string diretorioArquivo = @"C:\\Program Files";
        //--------------------------------------------------------------------------------------
        private string nomeArquivo = "Registro_de_Amigos.txt";
        
        public void escreverArq (Amigo amigo) 
        {
            string caminho = Path.Combine(diretorioArquivo, nomeArquivo);
            if (amigo != null ) 
            {
                StreamWriter SW = new StreamWriter(caminho, true);
                SW.WriteLine(amigo.Nome + "," + amigo.Sobrenome + "," + amigo.dataAniversario.ToString("dd/MM/yyyy"));
                SW.Close();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ocorreu um erro e seu amigo não pôde ser adicionado... :(");
            }
        }
        public List<Amigo> lerRegistro()
        {
            string caminho = Path.Combine(diretorioArquivo, nomeArquivo);
            var linhasArquivo = File.ReadAllLines(caminho);
            var registroAmigos = new List<Amigo>();

            foreach (var linha in linhasArquivo) 
            {
                string[] registro = linha.Split(',');
                
                string nomeRegistro = registro[0];
                string sobrenomeRegistro = registro[1];
                string dataniverRegistro = registro[2];
                
                Amigo amigo = new Amigo();
                amigo.Nome = nomeRegistro;
                amigo.Sobrenome = sobrenomeRegistro;
                amigo.dataAniversario = Convert.ToDateTime(dataniverRegistro);
                registroAmigos.Add(amigo);
            }
            return registroAmigos;
        }
        public void removerRegistro(Amigo amigo)
        {   
            foreach (var amg in lerRegistro()) 
            {
                if (amg.Nome == amigo.Nome|| amg.Sobrenome == amigo.Sobrenome) 
                {
                    lerRegistro().Remove(amg);
                    Console.Clear();
                    Console.WriteLine("Amigo Removido com sucesso!");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer TECLA, para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Amigo não encontrado...");
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer TECLA, para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
