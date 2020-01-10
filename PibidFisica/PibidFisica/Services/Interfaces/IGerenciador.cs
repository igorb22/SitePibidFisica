using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PibidFisica.Services.Interfaces
{
    public interface IGerenciador<T>
    {
        // bool Inserir(T objeto);
        // bool Editar(T objeto);
        // bool Remover(int id);
        List<T> ObterTodos(string programa);
        T ObterPorId(int id);
    }
}
