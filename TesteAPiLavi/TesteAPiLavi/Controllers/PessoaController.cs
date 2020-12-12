using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteAPiLavi.Models;
using TesteAPiLavi.Repository;

namespace TesteAPiLavi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private List<string> _listaEstatica = new List<string>();

        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(ILogger<PessoaController> logger, IPessoaRepository pessoaRepository)
        {
          
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        [Route("ListarEstatico")]
        public IActionResult GetLista()
        {
           
            for (int i = 0; i < 10; i++)
            {
                _listaEstatica.Add($"Objeto lista {i}");
            }

            return Ok(_listaEstatica);
        }

        [HttpGet]
        [Produces(typeof(Pessoa))]
        [Route("ListarBanco")]
        public IActionResult GetPessoa()
        {
            var pessoas = _pessoaRepository.GetAll();

            if (pessoas.Count() == 0)
                return NoContent();

            return Ok(pessoas);
        }


    }
}
