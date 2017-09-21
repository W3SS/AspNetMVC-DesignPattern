using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public interface IJogadorRepository
    {
        void Cadastrar(Jogador jogador);
        Jogador Buscar(int id);
        void Deletar(int id);
        void Alterar(Jogador jogador);
        ICollection<Jogador> Listar();
        IEnumerable<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);
    }
}
