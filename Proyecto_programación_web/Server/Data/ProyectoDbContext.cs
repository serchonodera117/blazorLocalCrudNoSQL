using Microsoft.EntityFrameworkCore;
using Proyecto_programación_web.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_programación_web.Server.Data
{
    public class ProyectoDbContext:DbContext
    {
        public ProyectoDbContext(DbContextOptions<ProyectoDbContext> options):base(options) 
        {
        }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }

    }
}
