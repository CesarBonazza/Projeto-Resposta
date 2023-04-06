using BibliotecaData;
using InterfacesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenteNiver_AT_DR1
{
    public class PesquisarAmigo : IFuncionalidade
    {
        public void Funcionalidade(Amigo amigo)
        {
            RepositorioAmigos rep = new RepositorioAmigos();
            if (amigo != null) 
            {
                Console.WriteLine("Amigo encontrado com sucesso!");
                rep.Pesquisar(amigo);
            }
        }
    }
}
