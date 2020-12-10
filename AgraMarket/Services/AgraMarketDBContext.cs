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
        public DbSet<CuentaAhorrosModel> CuentaAhorros { get; set; }
        public DbSet<DatosBasicosModel> DatosBasicos { get; set; }
        public DbSet<DatosPagoModel> DatosPago { get; set; }
        public DbSet<DomicilioModel> Domicilios { get; set; }
        public DbSet<PayPalModel> Paypal { get; set; }
        public DbSet<TarjetaCreditoModel> TarjetaCredito { get; set; }
        public DbSet<VentasModel> Ventas { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }

        #endregion Tablas
    }

} 