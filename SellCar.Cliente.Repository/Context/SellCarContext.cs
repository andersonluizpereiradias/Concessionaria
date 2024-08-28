using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellCar.Cliente.Model.Models;
using SellCar.Cliente.Repository.Mapping;

namespace SellCar.Cliente.Repository
{
    public class SellCarContext : DbContext
    {
        public DbSet<TipoProfissaoModel> TipoProfissoes { get; set; }
        public DbSet<ProfissaoModel> Profissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoProfissaoMap());
            ModelBuilder modelBuilder1 = modelBuilder.ApplyConfiguration(new ProfissaoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
