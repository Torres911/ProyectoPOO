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
                return View(vm); 
            }
        }
        #endregion Constructor*/
        
        //https://Localhost:5001/Cliente/RecargarDinero
        [HttpGet("RecargarDinero")]
        public async Task<IActionResult> RecargarDinero(long id)
        {
            try
            {
                UsuarioModel user = await dBContext.Usuarios.FindAsync(id); //user.codigo
                if(user == null)
                {
                    return Content("Hubo un error encontrado el usuario. Intentalo de nuevo.");
                }
                return RedirectToAction("UpdateRecarga", "Cliente", user);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        //https://Localhost:5001/User/UpdateRecarga
        [HttpPost("UpdateRecarga")]
        public async Task<IActionResult> UpdateRecarga(UsuarioModel usuario)
        {
            try
            {
                dBContext.Entry(usuario).State = EntityState.Modified;
                await dBContext.SaveChangesAsync();
                usuario.Monto = usuario.Monto + 100000;
                return RedirectToAction("ClientePage", usuario);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        //https://Localhost:5001/User/BuscarProdutco
        [HttpPost("BuscarProductos")]
        public async Task<IActionResult> BuscarProductos()
        {
            List<ProductoModel> completa = new List<ProductoModel>();
            completa = await dBContext.Productos.ToListAsync();
            if (completa == null)
            {
                return Content("Aún no hay productos para ti, pero pronto tendremos muchos :).");
            }
            return View("MostrarProductos", completa);
        }
        
    }
}
