using AgraMarket.Models;
using System.Collections.Generic;
using System;

namespace AgraMarket.ViewModels
{
    public class ClienteIndexViewModel
    {
        public List<ProductoModel> Productos { get; set; }

        public ClienteIndexViewModel()
        {
            Productos = new List<ProductoModel>();
        }
    }
}