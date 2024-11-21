using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Contexts
{
    public class Contest : DbContext
    {
        public Contest(){

        }
        public Contest( DbContextOptions<Contest> options) : base(options) { }
    
    


    // onconfigurig possui a cofiguracao da conexao com o banco de dados
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder){
if (!optionsBuilder.IsConfigured)

optionsBuilder.UseSqlServer(@"Data Source=NOTE28-S28\SQLEXPRESS; Initial Catalog = Bibliotec;
 User Id=sa; Password=abc123; Integrated Security=true;
  TrustServerCertificate = true");
    }
    
    
    //as referencias das nossas tabelas no banco de dados:
public DbSet<Categoria> Categorias { get; set; }
public DbSet<Livro> Livro { get; set; }
public DbSet<Usuario> Usuario { get; set; }
public DbSet<LivroCategoria> LivroCategoria { get; set; }
public DbSet<LivroReserva> LivroReserva { get; set; }



    
    }


}