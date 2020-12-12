using Microsoft.EntityFrameworkCore;
using AgraMarket.Models;

namespace AgraMarket.Services{
    public class AgraMarketDBContext : DbContext{
        
        #region Constructor
        
        public AgraMarketDBContext(DbContextOptions<AgraMarketDBContext> options)
                    : base(options) { }
        
        #endregion Constructor

        #region Tablas
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ComprasModel> Compras { get; set; }
        public DbSet<VentasModel> Ventas { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }

        #endregion Tablas
    }

} 