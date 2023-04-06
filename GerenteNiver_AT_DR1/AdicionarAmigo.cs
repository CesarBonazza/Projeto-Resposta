using BibliotecaData;
using InterfacesData;

namespace GerenteNiver_AT_DR1
{
    public class AdicionarAmigo : IFuncionalidade
    { 
        public void Funcionalidade(Amigo amigo)
        {
            RepositorioAmigos rep = new RepositorioAmigos();
            rep.Adicionar(amigo);
            Console.WriteLine("Amigo adicionado com sucesso!");
            Console.Clear();
        }
    }
}
