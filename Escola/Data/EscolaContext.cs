using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Models;

namespace Escola.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext (DbContextOptions<EscolaContext> options)
            : base(options)
        {
        }

        public DbSet<Escola.Models.Turma> Turma { get; set; } = default!;

        public DbSet<Escola.Models.Aluno> Aluno { get; set; }
    }
}
