using Microsoft.EntityFrameworkCore;
using MvcEscola.Models;

namespace MvcEscola.Data
{
    public class MvcEscolaContext : DbContext
    {
        public MvcEscolaContext (DbContextOptions<MvcEscolaContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
    }
}