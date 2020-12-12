using System.Collections.Generic;
using TesteAPiLavi.Models;

namespace TesteAPiLavi.Repository
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
    }
}
