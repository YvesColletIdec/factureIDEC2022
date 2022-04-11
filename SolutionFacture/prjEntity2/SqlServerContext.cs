using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEntity2.MesClasses
{
    public partial class SqlServerContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yves\github\factureIDEC2022\SolutionFacture\ProjetFactureCore\Facture2022.mdf;Integrated Security=True");
        }
    }
}
