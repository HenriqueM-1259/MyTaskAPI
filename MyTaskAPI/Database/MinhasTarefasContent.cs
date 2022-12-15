using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTaskAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskAPI.Database
{
    public class MinhasTarefasContent : IdentityDbContext<ApplicationUser>
    {
        public MinhasTarefasContent(DbContextOptions<MinhasTarefasContent> options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefas {get;set;}
    }
}

