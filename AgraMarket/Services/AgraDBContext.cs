namespace AgraMarket.Services{
    public class AgraDBContext : DbContext{
        
        #region Constructor
        
        public AgraDBContext(DbContextOptins<AgraDBContext> options)
                    : base(options) { }
        
        #endregion Constructor
    }
    

} 