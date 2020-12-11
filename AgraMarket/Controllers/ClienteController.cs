using Microsoft.AspNetCore.Mvc;
using AgraMarket.Services;
using AgraMarket.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AgraMarket.ViewModels;
using System;

namespace AgraMarket.Controllers
{
    [Route("[Controller]")]
    public class ClienteController : Controller 
    {
        #region Properties
        private readonly AgraMarketDBContext dBContext;

        #endregion Properties

        #region Constructor

        public ClienteController(AgraMarketDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet("ListaProductos")]

        public async Task<IActionResult> Index()
        {  
            ClienteIndexViewModel vm =  new ClienteIndexViewModel();
            try
            {
                vm.Productos = await dBContext.Productos.ToListAsync();
                if (vm.Productos.Count == 0)
                    throw new Exception("No hay productos aún");
                return View(vm); 
            }
            catch(Exception e)
            {
                vm.HayLibros = false;
                return View(vm); 
            }
        }
        #endregion Constructor

    }
}