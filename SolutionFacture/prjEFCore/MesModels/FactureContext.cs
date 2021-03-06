using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace prjEFCore.Models
{
    public partial class FactureContext : DbContext
    {
        //don't touch
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#if DEBUG
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yves\\github\\factureIDEC2022\\SolutionFacture\\ProjetFactureCore\\Facture2022.mdf;Integrated Security=True");
#else
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(
                    "Server=facture2022.mssql.somee.com;Database=facture2022;User Id=monanibis2000_SQLLogin_2;Password=m8ny4163mx;"
                    );
#endif
            }
        }
    }
}
