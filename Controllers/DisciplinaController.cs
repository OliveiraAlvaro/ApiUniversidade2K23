using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiUniversidade.Model;
using apiUniversidade.Context;

namespace apiUniversidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly ILogger<DisciplinaController> _logger;
        private readonly apiUniversidadeContext _context;

         public DisciplinaController(ILogger<DisciplinaController> logger, apiUniversidadeContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Disciplina>> Get()
        {
            var disciplinas = _context.Disciplinas.ToList();
            if (disciplinas is null)
                return NotFound();

            return disciplinas;
        }
        [HttpPost]
        public ActionResult Post(Disciplina disciplina)
        {
            _context.Disciplinas.Add(disciplina); 
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetDisciplina", new { id = disciplina.ID }, disciplina); 
        }

    }
}