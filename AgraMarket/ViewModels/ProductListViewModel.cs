using System.Collections.Generic;
using AgraMarket.Models;

namespace AgraMarket.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductoModel> ProductosVM { get; set; }
        public long IdVendedor {get; set;}
        public ProductListViewModel()
        {
            List<ProductoModel> listaProductos = new List<ProductoModel>();
            IdVendedor = 0;
        }
    }
}