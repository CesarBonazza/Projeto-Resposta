using BibliotecaData;
using GerenteNiver_AT_DR1;
using InterfacesData;

namespace GerenteNiver
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolharUsuario = 0;
            while (escolharUsuario != 5) 
            {
                Console.WriteLine("#===== Bem-Vindo ao Gerenciador de Aniversários! =====#");
                RepositorioAmigos rep = new RepositorioAmigos();
                Console.WriteLine("");
                rep.amigoDataAtual();
                Console.WriteLine("");
                Console.WriteLine("#----- Selecione uma das opções abaixo:");
                Console.WriteLine("");
                Console.WriteLine("1 - Para listar todos os amigos cadastradas.");
                Console.WriteLine("2 - Para adicionar uma pessoa a lista de cadastrados.");
                Console.WriteLine("3 - Para pesquisar pessoas já cadastradas.");
                Console.WriteLine("4 - Para excluir um amigo da lista.");
                Console.WriteLine("5 - Para sair da aplicação.");
                Console.WriteLine("");
                Console.WriteLine("Digite sua escolha: ");
                try
                {
                    escolharUsuario = Convert.ToInt32(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Opa... parece que você digitou algo errado");
                }

                Tarefa tarefa = new Tarefa();

                switch (escolharUsuario)
                {
                    case 1:
                        Console.Clear();
                        rep.Listar();
                        break;
                    case 2:
                        Console.Clear();
                        Amigo newAmigo = new Amigo();

                        Console.WriteLine("Digite o primeiro nome do amigo que gostaria de adicionar: ");
                        newAmigo.Nome = Console.ReadLine();
                        //--------------------------------------------------------------------------------

                        Console.WriteLine("Perfeito, agora, digite o sobrenome: ");
                        newAmigo.Sobrenome = Console.ReadLine();
                        //--------------------------------------------------------------------------------

                        Console.WriteLine("Digite a data de nascimento do amigo");
                        Console.WriteLine("Por fim, digite a data de nascimento do amigo:");
                        Console.WriteLine("Exemplo: 10/10/2020");
                        try
                        {
                            string DataAniversario = Console.ReadLine();
                            newAmigo.dataAniversario = Convert.ToDateTime(DataAniversario);
                        }
                        catch
                        {
                            Console.WriteLine("A data foi inserida incorretamente.");
                        }
                        AdicionarAmigo adicionarAmigo = new AdicionarAmigo();
                        tarefa.Aplicar = adicionarAmigo;
                        tarefa.Aplicar.Funcionalidade(newAmigo);
                        break;
                    case 3:
                        Console.Clear();
                        newAmigo = new Amigo();
                        Console.WriteLine("Digite o nome do amigo cadastrado:");
                        newAmigo.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do amigo cadastrado:");
                        newAmigo.Sobrenome = Console.ReadLine();
                        Console.Clear();
                        PesquisarAmigo pesquisarAmigo = new PesquisarAmigo();
                        tarefa.Aplicar = pesquisarAmigo;
                        tarefa.Aplicar.Funcionalidade(newAmigo);
                        break;
                    case 4:
                        Console.Clear();
                        newAmigo = new Amigo();
                        Console.WriteLine("Digite o nome do amigo cadastrado:");
                        newAmigo.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do amigo cadastrado:");
                        newAmigo.Sobrenome = Console.ReadLine();
                        RemoverAmigo removerAmigo = new RemoverAmigo();
                        tarefa.Aplicar = removerAmigo;
                        tarefa.Aplicar.Funcionalidade(newAmigo);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Você escolheu sair...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}